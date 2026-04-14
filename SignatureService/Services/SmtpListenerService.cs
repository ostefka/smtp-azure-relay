using System.Buffers;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmtpServer;
using SmtpServer.Mail;
using SmtpServer.Protocol;
using SmtpServer.Storage;
using SignatureService.Configuration;
using SignatureService.Storage;

using ISmtpMessageStore = SmtpServer.Storage.IMessageStore;

namespace SignatureService.Services;

public class SmtpListenerService : BackgroundService
{
    private readonly DurableMessageStore _store;
    private readonly MessageForwarder _forwarder;
    private readonly ExoIpFilter _ipFilter;
    private readonly SmtpSettings _smtpSettings;
    private readonly ILogger<SmtpListenerService> _logger;

    public SmtpListenerService(
        DurableMessageStore store,
        MessageForwarder forwarder,
        ExoIpFilter ipFilter,
        IOptions<SmtpSettings> smtpSettings,
        ILogger<SmtpListenerService> logger)
    {
        _store = store;
        _forwarder = forwarder;
        _ipFilter = ipFilter;
        _smtpSettings = smtpSettings.Value;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _store.Initialize();

        var optionsBuilder = new SmtpServerOptionsBuilder()
            .ServerName(_smtpSettings.ServerName)
            .MaxMessageSize(_smtpSettings.MaxMessageSizeKb * 1024);

        // Configure endpoint with optional STARTTLS
        var certificate = LoadCertificate();
        if (certificate != null)
        {
            optionsBuilder.Endpoint(builder => builder
                .Port(_smtpSettings.Port)
                .Certificate(certificate)
                .AllowUnsecureAuthentication(false));

            _logger.LogInformation(
                "STARTTLS enabled with certificate: {Subject} (expires {Expiry})",
                certificate.Subject, certificate.NotAfter);
        }
        else
        {
            optionsBuilder.Port(_smtpSettings.Port);
            _logger.LogWarning("No TLS certificate configured — SMTP listener running WITHOUT encryption");
        }

        var options = optionsBuilder.Build();

        var serviceProvider = new SmtpServer.ComponentModel.ServiceProvider();
        serviceProvider.Add(new IngestMessageStoreFactory(_store, _forwarder, _logger));
        serviceProvider.Add((IMailboxFilterFactory)_ipFilter);

        var smtpServer = new SmtpServer.SmtpServer(options, serviceProvider);

        _logger.LogInformation(
            "Signature Service SMTP listener starting on port {Port}", _smtpSettings.Port);

        try
        {
            await smtpServer.StartAsync(stoppingToken);
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("SMTP listener shutting down");
        }
    }

    private X509Certificate2? LoadCertificate()
    {
        if (string.IsNullOrEmpty(_smtpSettings.TlsCertificatePath))
            return null;

        var certPath = Path.IsPathRooted(_smtpSettings.TlsCertificatePath)
            ? _smtpSettings.TlsCertificatePath
            : Path.Combine(AppContext.BaseDirectory, _smtpSettings.TlsCertificatePath);

        if (!File.Exists(certPath))
        {
            _logger.LogError("TLS certificate not found at {Path}", certPath);
            return null;
        }

        try
        {
            var cert = string.IsNullOrEmpty(_smtpSettings.TlsCertificatePassword)
                ? new X509Certificate2(certPath)
                : new X509Certificate2(certPath, _smtpSettings.TlsCertificatePassword);

            _logger.LogInformation("Loaded TLS certificate: {Subject}", cert.Subject);
            return cert;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to load TLS certificate from {Path}", certPath);
            return null;
        }
    }
}

/// <summary>
/// Factory that creates message handlers for each SMTP session.
/// </summary>
internal class IngestMessageStoreFactory : IMessageStoreFactory
{
    private readonly DurableMessageStore _store;
    private readonly MessageForwarder _forwarder;
    private readonly ILogger _logger;

    public IngestMessageStoreFactory(DurableMessageStore store, MessageForwarder forwarder, ILogger logger)
    {
        _store = store;
        _forwarder = forwarder;
        _logger = logger;
    }

    public ISmtpMessageStore CreateInstance(ISessionContext context) =>
        new IngestMessageHandler(_store, _forwarder, _logger);
}

/// <summary>
/// SMTP message handler — the critical path.
///
/// FAIL-OPEN DESIGN:
///   1. Try to write raw bytes to durable storage → return 250 OK (normal path)
///   2. If storage write fails → forward directly to EXO without signature → return 250 OK
///   3. Only return 451 if BOTH storage AND direct forwarding fail
///
/// This guarantees that a message is NEVER lost due to our service.
/// The worst case is a message delivered without a signature.
/// </summary>
internal class IngestMessageHandler : MessageStore
{
    private readonly DurableMessageStore _store;
    private readonly MessageForwarder _forwarder;
    private readonly ILogger _logger;

    public IngestMessageHandler(DurableMessageStore store, MessageForwarder forwarder, ILogger logger)
    {
        _store = store;
        _forwarder = forwarder;
        _logger = logger;
    }

    public override async Task<SmtpResponse> SaveAsync(
        ISessionContext context,
        IMessageTransaction transaction,
        ReadOnlySequence<byte> buffer,
        CancellationToken cancellationToken)
    {
        var rawMessage = buffer.ToArray();
        var envelopeFrom = transaction.From?.AsAddress() ?? string.Empty;
        var envelopeTo = transaction.To?
            .Select(t => t.AsAddress())
            .Where(a => !string.IsNullOrEmpty(a))
            .ToList() ?? new List<string>();

        // === Normal path: enqueue for async processing ===
        try
        {
            await _store.EnqueueAsync(rawMessage, envelopeFrom, envelopeTo, cancellationToken);

            _logger.LogDebug("Accepted message from {From} to {To} ({Size} bytes)",
                envelopeFrom, string.Join(", ", envelopeTo), rawMessage.Length);

            return SmtpResponse.Ok;
        }
        catch (Exception storeEx)
        {
            _logger.LogError(storeEx,
                "FAIL-OPEN: Storage write failed for message from {From}. " +
                "Attempting direct forwarding without signature.", envelopeFrom);
        }

        // === Fail-open bypass: forward directly without signature ===
        try
        {
            await _forwarder.ForwardRawAsync(rawMessage, envelopeFrom, envelopeTo, cancellationToken);

            _logger.LogWarning(
                "FAIL-OPEN: Message from {From} forwarded directly WITHOUT signature " +
                "(storage was unavailable)", envelopeFrom);

            return SmtpResponse.Ok;
        }
        catch (Exception fwdEx)
        {
            // Both paths failed — this is the only scenario where we return 451.
            // EXO will retry. This is better than losing the message.
            _logger.LogCritical(fwdEx,
                "CRITICAL: Both storage AND direct forwarding failed for message from {From}. " +
                "Returning 451 — EXO will retry.", envelopeFrom);

            return new SmtpResponse(SmtpReplyCode.ServiceUnavailable,
                "Temporary service error, please retry");
        }
    }
}
