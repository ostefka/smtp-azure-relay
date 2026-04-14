using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SmtpSignatureProxy.Configuration;

namespace SmtpSignatureProxy.Services;

/// <summary>
/// Forwards modified messages back to EXO (or any next-hop SMTP server)
/// using MailKit's SMTP client.
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
    /// Sends the message to the configured next-hop SMTP server,
    /// preserving the original envelope sender and recipients.
    /// </summary>
    public async Task ForwardAsync(
        MimeMessage message,
        string envelopeFrom,
        IReadOnlyList<string> envelopeTo,
        CancellationToken ct)
    {
        using var client = new SmtpClient();
        client.Timeout = _settings.TimeoutSeconds * 1000;

        await client.ConnectAsync(
            _settings.SmtpHost,
            _settings.SmtpPort,
            _settings.UseTls
                ? MailKit.Security.SecureSocketOptions.StartTls
                : MailKit.Security.SecureSocketOptions.None,
            ct);

        // EXO inbound doesn't require auth when the source IP is whitelisted
        // so we skip authentication.

        var sender = MailboxAddress.Parse(
            string.IsNullOrEmpty(envelopeFrom) ? "postmaster@localhost" : envelopeFrom);

        var recipients = envelopeTo
            .Where(r => !string.IsNullOrWhiteSpace(r))
            .Select(r => MailboxAddress.Parse(r))
            .Cast<MailboxAddress>()
            .ToList();

        await client.SendAsync(message, sender, recipients, ct);
        await client.DisconnectAsync(quit: true, ct);

        _logger.LogInformation(
            "Forwarded {MessageId} to {Host}:{Port} ({RecipientCount} recipients)",
            message.MessageId, _settings.SmtpHost, _settings.SmtpPort, recipients.Count);
    }
}
