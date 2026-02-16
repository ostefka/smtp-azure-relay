using System.Text.Json;
using Azure.Data.Tables;
using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Queues;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SmtpRelay.Configuration;
using SmtpRelay.Storage;

namespace SmtpRelay.Services;

/// <summary>
/// Background worker that dequeues messages from Azure Queue Storage,
/// reads the raw .eml from Blob Storage, parses with MimeKit,
/// and writes metadata to Azure Table Storage.
/// </summary>
public class MessageProcessingWorker : BackgroundService
{
    private readonly QueueClient _queue;
    private readonly BlobContainerClient _blobContainer;
    private readonly TableClient _table;
    private readonly ProcessingSettings _processingSettings;
    private readonly ILogger<MessageProcessingWorker> _logger;

    public MessageProcessingWorker(
        IOptions<AzureStorageSettings> storageSettings,
        IOptions<ProcessingSettings> processingSettings,
        ILogger<MessageProcessingWorker> logger)
    {
        var s = storageSettings.Value;
        if (s.UseManagedIdentity)
        {
            var credential = new DefaultAzureCredential();
            var blobService = new BlobServiceClient(s.BlobServiceUri, credential);
            _blobContainer = blobService.GetBlobContainerClient(s.BlobContainerName);
            var queueService = new QueueServiceClient(s.QueueServiceUri, credential);
            _queue = queueService.GetQueueClient(s.QueueName);
            _table = new TableClient(s.TableServiceUri, s.TableName, credential);
        }
        else
        {
            _queue = new QueueClient(s.ConnectionString, s.QueueName);
            _blobContainer = new BlobContainerClient(s.ConnectionString, s.BlobContainerName);
            _table = new TableClient(s.ConnectionString, s.TableName);
        }
        _processingSettings = processingSettings.Value;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await _table.CreateIfNotExistsAsync(stoppingToken);

        _logger.LogInformation("Processing worker started (batch={BatchSize}, visibility={Vis}s)",
            _processingSettings.BatchSize, _processingSettings.VisibilityTimeoutSeconds);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var response = await _queue.ReceiveMessagesAsync(
                    maxMessages: _processingSettings.BatchSize,
                    visibilityTimeout: TimeSpan.FromSeconds(_processingSettings.VisibilityTimeoutSeconds),
                    cancellationToken: stoppingToken);

                if (response.Value.Length == 0)
                {
                    await Task.Delay(TimeSpan.FromSeconds(2), stoppingToken);
                    continue;
                }

                _logger.LogInformation("Dequeued {Count} messages", response.Value.Length);

                foreach (var qMsg in response.Value)
                {
                    stoppingToken.ThrowIfCancellationRequested();
                    await ProcessQueueMessageAsync(qMsg, stoppingToken);
                }
            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
            {
                break;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Processing loop error, retrying in 5s");
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
    }

    private async Task ProcessQueueMessageAsync(Azure.Storage.Queues.Models.QueueMessage qMsg, CancellationToken ct)
    {
        Storage.QueueMessage? parsed = null;
        try
        {
            parsed = JsonSerializer.Deserialize<Storage.QueueMessage>(qMsg.Body.ToString());
            if (parsed == null)
            {
                _logger.LogWarning("Invalid queue message, deleting: {Id}", qMsg.MessageId);
                await _queue.DeleteMessageAsync(qMsg.MessageId, qMsg.PopReceipt, ct);
                return;
            }

            // Poison message check
            if (qMsg.DequeueCount > _processingSettings.MaxDequeueCount)
            {
                _logger.LogError("Poison message {Id} after {Count} attempts, parking",
                    parsed.Id, qMsg.DequeueCount);
                // Move to a poison blob path for manual inspection
                await ParkPoisonMessageAsync(parsed, ct);
                await _queue.DeleteMessageAsync(qMsg.MessageId, qMsg.PopReceipt, ct);
                return;
            }

            // Download raw .eml from blob
            var blobClient = _blobContainer.GetBlobClient(parsed.BlobName);
            var download = await blobClient.DownloadContentAsync(ct);
            var rawBytes = download.Value.Content.ToArray();

            // Parse MIME
            using var stream = new MemoryStream(rawBytes);
            var mimeMessage = await MimeMessage.LoadAsync(stream, ct);

            // Build metadata entity
            var entity = new EmailMetadataEntity
            {
                PartitionKey = parsed.ReceivedUtc.ToString("yyyy-MM-dd"),
                RowKey = parsed.Id,
                EnvelopeFrom = parsed.EnvelopeFrom,
                EnvelopeTo = parsed.EnvelopeTo,
                From = mimeMessage.From?.ToString() ?? parsed.EnvelopeFrom,
                To = mimeMessage.To?.ToString() ?? parsed.EnvelopeTo,
                Cc = mimeMessage.Cc?.ToString() ?? string.Empty,
                Subject = mimeMessage.Subject ?? string.Empty,
                MessageId = mimeMessage.MessageId ?? string.Empty,
                InReplyTo = mimeMessage.InReplyTo ?? string.Empty,
                MessageDate = mimeMessage.Date,
                BlobName = parsed.BlobName,
                SizeBytes = rawBytes.Length,
                HasAttachments = mimeMessage.Attachments.Any(),
                AttachmentCount = mimeMessage.Attachments.Count(),
                ReceivedUtc = parsed.ReceivedUtc,
                ProcessedUtc = DateTimeOffset.UtcNow,
                Status = "Processed"
            };

            await _table.UpsertEntityAsync(entity, TableUpdateMode.Replace, ct);
            await _queue.DeleteMessageAsync(qMsg.MessageId, qMsg.PopReceipt, ct);

            _logger.LogDebug("Processed {Id}: {Subject}", parsed.Id, entity.Subject);
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to process message {Id} (attempt {Count})",
                parsed?.Id ?? qMsg.MessageId, qMsg.DequeueCount);
            // Message remains in queue — visibility timeout will make it reappear
        }
    }

    private async Task ParkPoisonMessageAsync(Storage.QueueMessage msg, CancellationToken ct)
    {
        try
        {
            // Copy blob to poison path
            var sourceClient = _blobContainer.GetBlobClient(msg.BlobName);
            var poisonBlobName = $"poison/{msg.Id}.eml";
            var poisonClient = _blobContainer.GetBlobClient(poisonBlobName);
            await poisonClient.StartCopyFromUriAsync(sourceClient.Uri, cancellationToken: ct);

            // Write poison metadata to table
            var entity = new EmailMetadataEntity
            {
                PartitionKey = "POISON",
                RowKey = msg.Id,
                EnvelopeFrom = msg.EnvelopeFrom,
                EnvelopeTo = msg.EnvelopeTo,
                BlobName = poisonBlobName,
                ReceivedUtc = msg.ReceivedUtc,
                Status = "Poison"
            };
            await _table.UpsertEntityAsync(entity, TableUpdateMode.Replace, ct);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to park poison message {Id}", msg.Id);
        }
    }
}
