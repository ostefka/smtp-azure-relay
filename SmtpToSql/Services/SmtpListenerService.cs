using System.Buffers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmtpServer;
using SmtpServer.Mail;
using SmtpServer.Protocol;
using SmtpServer.Storage;
using SmtpToSql.Configuration;

// Alias to disambiguate our IMessageStore from SmtpServer.Storage.IMessageStore
using IDurableMessageStore = SmtpToSql.Services.IMessageStore;

namespace SmtpToSql.Services;

/// <summary>
/// Hosts the SMTP listener on port 25. Uses the SmtpServer library.
/// On message receipt, stores raw bytes via IMessageStore and returns 250 OK.
/// </summary>
public class SmtpListenerService : BackgroundService
{
    private readonly IDurableMessageStore _messageStore;
    private readonly SmtpSettings _smtpSettings;
    private readonly ILogger<SmtpListenerService> _logger;

    public SmtpListenerService(
        IDurableMessageStore messageStore,
        IOptions<SmtpSettings> smtpSettings,
        ILogger<SmtpListenerService> logger,
        IServiceProvider serviceProvider)
    {
        _messageStore = messageStore;
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
        serviceProvider.Add(new SmtpMessageStoreFactory(_messageStore, _logger));

        var smtpServer = new SmtpServer.SmtpServer(options, serviceProvider);

        _logger.LogInformation("SMTP server starting on port {Port} as {ServerName}",
            _smtpSettings.Port, _smtpSettings.ServerName);

        try
        {
            await smtpServer.StartAsync(stoppingToken);
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("SMTP server shutting down gracefully");
        }
    }
}

/// <summary>
/// Factory that creates message store instances for each SMTP session.
/// </summary>
internal class SmtpMessageStoreFactory : IMessageStoreFactory
{
    private readonly IDurableMessageStore _store;
    private readonly ILogger _logger;

    public SmtpMessageStoreFactory(IDurableMessageStore store, ILogger logger)
    {
        _store = store;
        _logger = logger;
    }

    public SmtpServer.Storage.IMessageStore CreateInstance(ISessionContext context)
    {
        return new SmtpMessageHandler(_store, _logger);
    }
}

/// <summary>
/// Handles individual SMTP message delivery. The critical path:
/// receive bytes → store durably → return success.
/// </summary>
internal class SmtpMessageHandler : MessageStore
{
    private readonly IDurableMessageStore _durableStore;
    private readonly ILogger _logger;

    public SmtpMessageHandler(IDurableMessageStore durableStore, ILogger logger)
    {
        _durableStore = durableStore;
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
            var rawMessage = buffer.ToArray();
            var envelopeFrom = transaction.From?.AsAddress() ?? string.Empty;
            var envelopeTo = string.Join(";",
                transaction.To?.Select(t => t.AsAddress()) ?? Enumerable.Empty<string>());

            var messageId = await _durableStore.StoreRawMessageAsync(
                rawMessage, envelopeFrom, envelopeTo, cancellationToken);

            _logger.LogDebug("Accepted message {MessageId} from {From} to {To} ({Size} bytes)",
                messageId, envelopeFrom, envelopeTo, rawMessage.Length);

            return SmtpResponse.Ok;
        }
        catch (Exception ex)
        {
            // This should be extremely rare given the fallback-to-filesystem design.
            // Return a temporary error so EXO will retry delivery.
            _logger.LogError(ex, "Critical: failed to store message, returning 451 for retry");
            return new SmtpResponse(SmtpReplyCode.ServiceUnavailable,
                "Temporary storage error, please retry");
        }
    }
}
