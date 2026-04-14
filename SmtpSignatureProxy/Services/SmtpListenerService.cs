using System.Buffers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmtpServer;
using SmtpServer.Mail;
using SmtpServer.Protocol;
using SmtpServer.Storage;
using SmtpSignatureProxy.Configuration;

using ISmtpMessageStore = SmtpServer.Storage.IMessageStore;

namespace SmtpSignatureProxy.Services;

public class SmtpListenerService : BackgroundService
{
    private readonly SignatureEngine _signatureEngine;
    private readonly MessageForwarder _forwarder;
    private readonly SmtpSettings _smtpSettings;
    private readonly ILogger<SmtpListenerService> _logger;

    public SmtpListenerService(
        SignatureEngine signatureEngine,
        MessageForwarder forwarder,
        IOptions<SmtpSettings> smtpSettings,
        ILogger<SmtpListenerService> logger)
    {
        _signatureEngine = signatureEngine;
        _forwarder = forwarder;
        _smtpSettings = smtpSettings.Value;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var options = new SmtpServerOptionsBuilder()
            .ServerName(_smtpSettings.ServerName)
            .Port(_smtpSettings.Port)
            .MaxMessageSize(_smtpSettings.MaxMessageSizeKb * 1024)
            .Build();

        var serviceProvider = new SmtpServer.ComponentModel.ServiceProvider();
        serviceProvider.Add(new ProxyMessageStoreFactory(_signatureEngine, _forwarder, _logger));

        var smtpServer = new SmtpServer.SmtpServer(options, serviceProvider);

        _logger.LogInformation("Signature proxy starting on port {Port}", _smtpSettings.Port);

        try
        {
            await smtpServer.StartAsync(stoppingToken);
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Signature proxy shutting down");
        }
    }
}

internal class ProxyMessageStoreFactory : IMessageStoreFactory
{
    private readonly SignatureEngine _signatureEngine;
    private readonly MessageForwarder _forwarder;
    private readonly ILogger _logger;

    public ProxyMessageStoreFactory(
        SignatureEngine signatureEngine, MessageForwarder forwarder, ILogger logger)
    {
        _signatureEngine = signatureEngine;
        _forwarder = forwarder;
        _logger = logger;
    }

    public ISmtpMessageStore CreateInstance(ISessionContext context)
    {
        return new ProxyMessageHandler(_signatureEngine, _forwarder, _logger);
    }
}

internal class ProxyMessageHandler : MessageStore
{
    private readonly SignatureEngine _signatureEngine;
    private readonly MessageForwarder _forwarder;
    private readonly ILogger _logger;

    public ProxyMessageHandler(
        SignatureEngine signatureEngine, MessageForwarder forwarder, ILogger logger)
    {
        _signatureEngine = signatureEngine;
        _forwarder = forwarder;
        _logger = logger;
    }

    public override async Task<SmtpResponse> SaveAsync(
        ISessionContext context,
        IMessageTransaction transaction,
        ReadOnlySequence<byte> buffer,
        CancellationToken cancellationToken)
    {
        try
        {
            var envelopeFrom = transaction.From?.AsAddress() ?? string.Empty;
            var envelopeTo = transaction.To?
                .Select(t => t.AsAddress())
                .Where(a => !string.IsNullOrEmpty(a))
                .ToList() ?? new List<string>();

            // Parse MIME
            using var stream = new MemoryStream(buffer.ToArray());
            var message = await MimeKit.MimeMessage.LoadAsync(stream, cancellationToken);

            _logger.LogInformation(
                "Received: {From} → {To} | Subject: {Subject}",
                envelopeFrom,
                string.Join(", ", envelopeTo),
                message.Subject);

            // Check loop prevention
            if (_signatureEngine.IsAlreadySigned(message))
            {
                _logger.LogInformation("Message {MessageId} already signed, forwarding as-is", message.MessageId);
            }
            else
            {
                _signatureEngine.ApplySignature(message);
            }

            // Forward to next hop (EXO)
            await _forwarder.ForwardAsync(message, envelopeFrom, envelopeTo, cancellationToken);

            return SmtpResponse.Ok;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to process/forward message, returning 451");
            return new SmtpResponse(SmtpReplyCode.ServiceUnavailable,
                "Temporary processing error, please retry");
        }
    }
}
