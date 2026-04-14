using System.Buffers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmtpServer;
using SmtpServer.Mail;
using SmtpServer.Protocol;
using SmtpServer.Storage;
using SmtpRelay.Configuration;
using SmtpRelay.Storage;

using ISmtpMessageStore = SmtpServer.Storage.IMessageStore;

namespace SmtpRelay.Services;

public class SmtpListenerService : BackgroundService
{
    private readonly AzureMessageStore _store;
    private readonly SmtpSettings _smtpSettings;
    private readonly ILogger<SmtpListenerService> _logger;

    public SmtpListenerService(
        AzureMessageStore store,
        IOptions<SmtpSettings> smtpSettings,
        ILogger<SmtpListenerService> logger)
    {
        _store = store;
        _smtpSettings = smtpSettings.Value;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Initialize storage (create containers/queues if needed)
        await _store.InitializeAsync(stoppingToken);
        await _store.RecoverFallbackAsync(stoppingToken);

        var options = new SmtpServerOptionsBuilder()
            .ServerName(_smtpSettings.ServerName)
            .Port(_smtpSettings.Port)
            .MaxMessageSize(_smtpSettings.MaxMessageSizeKb * 1024)
            .Build();

        var serviceProvider = new SmtpServer.ComponentModel.ServiceProvider();
        serviceProvider.Add(new RelayMessageStoreFactory(_store, _logger));

        var smtpServer = new SmtpServer.SmtpServer(options, serviceProvider);

        _logger.LogInformation("SMTP relay starting on port {Port}", _smtpSettings.Port);

        try
        {
            await smtpServer.StartAsync(stoppingToken);
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("SMTP relay shutting down");
        }
    }
}

internal class RelayMessageStoreFactory : IMessageStoreFactory
{
    private readonly AzureMessageStore _store;
    private readonly ILogger _logger;

    public RelayMessageStoreFactory(AzureMessageStore store, ILogger logger)
    {
        _store = store;
        _logger = logger;
    }

    public ISmtpMessageStore CreateInstance(ISessionContext context)
    {
        return new RelayMessageHandler(_store, _logger);
    }
}

internal class RelayMessageHandler : MessageStore
{
    private readonly AzureMessageStore _store;
    private readonly ILogger _logger;

    public RelayMessageHandler(AzureMessageStore store, ILogger logger)
    {
        _store = store;
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

            await _store.StoreRawMessageAsync(rawMessage, envelopeFrom, envelopeTo, cancellationToken);

            return SmtpResponse.Ok;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to store message, returning 451");
            return new SmtpResponse(SmtpReplyCode.ServiceUnavailable,
                "Temporary storage error, please retry");
        }
    }
}
