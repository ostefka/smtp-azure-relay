using MailKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SignatureService.Configuration;

namespace SignatureService.Services;

/// <summary>
/// Forwards processed messages to the next-hop SMTP server (EXO).
/// Implements retry with exponential backoff.
///
/// Distinguishes between:
///   - Transient failures (4xx, network errors) → retry
///   - Permanent failures (5xx) → forward original unmodified message
/// </summary>
public class MessageForwarder
{
    private readonly ForwardingSettings _settings;
    private readonly ILogger<MessageForwarder> _logger;

    public MessageForwarder(
        IOptions<ForwardingSettings> settings,
        ILogger<MessageForwarder> logger)
    {
        _settings = settings.Value;
        _logger = logger;
    }

    /// <summary>
    /// Forwards a parsed MimeMessage to the configured SMTP host.
    /// Throws SmtpForwardingException on failure with classification.
    /// </summary>
    public async Task ForwardAsync(
        MimeMessage message,
        string envelopeFrom,
        IReadOnlyList<string> envelopeTo,
        CancellationToken ct)
    {
        using var client = new SmtpClient();
        client.Timeout = _settings.TimeoutSeconds * 1000;

        try
        {
            await client.ConnectAsync(
                _settings.SmtpHost,
                _settings.SmtpPort,
                _settings.UseTls
                    ? MailKit.Security.SecureSocketOptions.StartTls
                    : MailKit.Security.SecureSocketOptions.None,
                ct);
        }
        catch (Exception ex)
        {
            throw new SmtpForwardingException("Connection failed", ex, isTransient: true);
        }

        var sender = MailboxAddress.Parse(
            string.IsNullOrEmpty(envelopeFrom) ? "postmaster@localhost" : envelopeFrom);

        var recipients = envelopeTo
            .Where(r => !string.IsNullOrWhiteSpace(r))
            .Select(r => MailboxAddress.Parse(r))
            .Cast<MailboxAddress>()
            .ToList();

        if (recipients.Count == 0)
        {
            _logger.LogWarning("No valid recipients for {MessageId}, skipping forward",
                message.MessageId);
            return;
        }

        try
        {
            await client.SendAsync(message, sender, recipients, ct);
        }
        catch (SmtpCommandException smtpEx)
        {
            var isPermanent = (int)smtpEx.StatusCode >= 500;
            throw new SmtpForwardingException(
                $"SMTP {(int)smtpEx.StatusCode}: {smtpEx.Message}",
                smtpEx,
                isTransient: !isPermanent);
        }
        catch (Exception ex)
        {
            throw new SmtpForwardingException("Send failed", ex, isTransient: true);
        }
        finally
        {
            try { await client.DisconnectAsync(quit: true, ct); } catch { /* best effort */ }
        }

        _logger.LogInformation(
            "Forwarded {MessageId} to {Host}:{Port} ({Count} recipients)",
            message.MessageId, _settings.SmtpHost, _settings.SmtpPort, recipients.Count);
    }

    /// <summary>
    /// Forwards raw message bytes directly to EXO without any parsing or modification.
    /// Used as a fail-open bypass when the normal pipeline is unavailable.
    /// This ensures mail delivery even when our service is degraded.
    /// </summary>
    public async Task ForwardRawAsync(
        byte[] rawMessage,
        string envelopeFrom,
        IReadOnlyList<string> envelopeTo,
        CancellationToken ct)
    {
        // Parse just enough to forward
        using var stream = new MemoryStream(rawMessage);
        var message = await MimeMessage.LoadAsync(stream, ct);

        using var client = new SmtpClient();
        client.Timeout = _settings.TimeoutSeconds * 1000;

        await client.ConnectAsync(
            _settings.SmtpHost,
            _settings.SmtpPort,
            _settings.UseTls
                ? MailKit.Security.SecureSocketOptions.StartTls
                : MailKit.Security.SecureSocketOptions.None,
            ct);

        var sender = MailboxAddress.Parse(
            string.IsNullOrEmpty(envelopeFrom) ? "postmaster@localhost" : envelopeFrom);

        var recipients = envelopeTo
            .Where(r => !string.IsNullOrWhiteSpace(r))
            .Select(r => MailboxAddress.Parse(r))
            .Cast<MailboxAddress>()
            .ToList();

        if (recipients.Count > 0)
        {
            await client.SendAsync(message, sender, recipients, ct);
        }

        try { await client.DisconnectAsync(quit: true, ct); } catch { /* best effort */ }

        _logger.LogWarning(
            "BYPASS: Forwarded raw message from {From} to {Host}:{Port} ({Count} recipients) WITHOUT signature",
            envelopeFrom, _settings.SmtpHost, _settings.SmtpPort, recipients.Count);
    }

    /// <summary>
    /// Calculates the retry delay using exponential backoff with jitter.
    /// </summary>
    public TimeSpan GetRetryDelay(int retryCount)
    {
        var baseDelay = _settings.RetryBaseDelaySeconds;
        var exponential = baseDelay * Math.Pow(2, Math.Min(retryCount, 6)); // cap at ~10 min
        var jitter = Random.Shared.NextDouble() * exponential * 0.3; // 0-30% jitter
        return TimeSpan.FromSeconds(exponential + jitter);
    }
}

/// <summary>
/// Classified SMTP forwarding exception.
/// Transient = 4xx, network errors (should retry).
/// Permanent = 5xx (should forward original without signature).
/// </summary>
public class SmtpForwardingException : Exception
{
    public bool IsTransient { get; }

    public SmtpForwardingException(string message, Exception inner, bool isTransient)
        : base(message, inner)
    {
        IsTransient = isTransient;
    }
}
