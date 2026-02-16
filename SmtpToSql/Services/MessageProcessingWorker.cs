using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SmtpToSql.Configuration;

namespace SmtpToSql.Services;

/// <summary>
/// Background worker that processes raw messages from the durable store:
/// 1. Reads pending raw messages
/// 2. Parses MIME content using MimeKit
/// 3. Writes parsed data to CRM-facing SQL tables
/// 4. Marks messages as processed
/// 
/// This is the retry-safe, non-critical path. If it fails, messages remain
/// in the queue and will be retried on the next cycle.
/// </summary>
public class MessageProcessingWorker : BackgroundService
{
    private readonly IMessageStore _store;
    private readonly SqlSettings _sqlSettings;
    private readonly ILogger<MessageProcessingWorker> _logger;

    public MessageProcessingWorker(
        IMessageStore store,
        IOptions<SqlSettings> sqlSettings,
        ILogger<MessageProcessingWorker> logger)
    {
        _store = store;
        _sqlSettings = sqlSettings.Value;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Message processing worker started");

        // On startup, try to recover any messages from fallback filesystem storage
        await _store.RecoverFallbackMessagesAsync(stoppingToken);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var messages = await _store.GetPendingMessagesAsync(_sqlSettings.BatchSize, stoppingToken);

                if (messages.Count == 0)
                {
                    await Task.Delay(TimeSpan.FromSeconds(_sqlSettings.ProcessingIntervalSeconds), stoppingToken);
                    continue;
                }

                _logger.LogInformation("Processing batch of {Count} messages", messages.Count);

                foreach (var msg in messages)
                {
                    stoppingToken.ThrowIfCancellationRequested();

                    try
                    {
                        await ProcessMessageAsync(msg, stoppingToken);
                        await _store.MarkAsProcessedAsync(msg.Id, stoppingToken);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogWarning(ex, "Failed to process message {MessageId} (attempt {Retry})",
                            msg.Id, msg.RetryCount + 1);
                        await _store.MarkAsFailedAsync(msg.Id, ex.Message, stoppingToken);
                    }
                }
            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
            {
                break;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in processing loop, will retry in {Interval}s",
                    _sqlSettings.ProcessingIntervalSeconds);
                await Task.Delay(TimeSpan.FromSeconds(_sqlSettings.ProcessingIntervalSeconds), stoppingToken);
            }
        }
    }

    private async Task ProcessMessageAsync(RawMessageRecord msg, CancellationToken ct)
    {
        using var stream = new MemoryStream(msg.RawMessage);
        var mimeMessage = await MimeMessage.LoadAsync(stream, ct);

        // ─────────────────────────────────────────────────────────────
        // TODO: Replace the SQL below with your actual CRM table schema.
        // This mirrors the structure your existing Transport Agent likely writes.
        // ─────────────────────────────────────────────────────────────

        var from = mimeMessage.From?.ToString() ?? msg.EnvelopeFrom;
        var to = mimeMessage.To?.ToString() ?? msg.EnvelopeTo;
        var cc = mimeMessage.Cc?.ToString() ?? string.Empty;
        var subject = mimeMessage.Subject ?? string.Empty;
        var date = mimeMessage.Date.UtcDateTime;
        var messageId = mimeMessage.MessageId ?? string.Empty;
        var inReplyTo = mimeMessage.InReplyTo ?? string.Empty;
        var textBody = mimeMessage.TextBody ?? string.Empty;
        var htmlBody = mimeMessage.HtmlBody ?? string.Empty;

        const string sql = """
            INSERT INTO CrmEmails 
                (Id, MessageId, InReplyTo, [From], [To], Cc, Subject, DateUtc, 
                 TextBody, HtmlBody, RawMessage, EnvelopeFrom, EnvelopeTo, ReceivedUtc)
            VALUES 
                (@Id, @MessageId, @InReplyTo, @From, @To, @Cc, @Subject, @DateUtc, 
                 @TextBody, @HtmlBody, @RawMessage, @EnvelopeFrom, @EnvelopeTo, @ReceivedUtc)
            """;

        await using var connection = new Microsoft.Data.SqlClient.SqlConnection(_sqlSettings.ConnectionString);
        await connection.OpenAsync(ct);

        await using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@Id", msg.Id);
        cmd.Parameters.AddWithValue("@MessageId", messageId);
        cmd.Parameters.AddWithValue("@InReplyTo", inReplyTo);
        cmd.Parameters.AddWithValue("@From", from);
        cmd.Parameters.AddWithValue("@To", to);
        cmd.Parameters.AddWithValue("@Cc", cc);
        cmd.Parameters.AddWithValue("@Subject", subject);
        cmd.Parameters.AddWithValue("@DateUtc", date);
        cmd.Parameters.AddWithValue("@TextBody", textBody);
        cmd.Parameters.AddWithValue("@HtmlBody", htmlBody);
        cmd.Parameters.AddWithValue("@RawMessage", msg.RawMessage);
        cmd.Parameters.AddWithValue("@EnvelopeFrom", msg.EnvelopeFrom);
        cmd.Parameters.AddWithValue("@EnvelopeTo", msg.EnvelopeTo);
        cmd.Parameters.AddWithValue("@ReceivedUtc", msg.ReceivedUtc);

        await cmd.ExecuteNonQueryAsync(ct);

        _logger.LogDebug("Processed message {MessageId}: {Subject}", msg.Id, subject);

        // TODO: Extract and store attachments if your CRM needs them
        // foreach (var attachment in mimeMessage.Attachments) { ... }
    }
}
