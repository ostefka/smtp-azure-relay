using System.Text.Json;
using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Queues;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmtpRelay.Configuration;

namespace SmtpRelay.Storage;

/// <summary>
/// Stores raw email messages to Azure Blob Storage and enqueues a processing
/// message to Azure Queue Storage. This is the critical path — called during
/// the SMTP transaction before returning 250 OK.
///
/// Design: Blob write must succeed (or fall back to local disk) before we
/// acknowledge the message. Queue enqueue is best-effort — a startup sweep
/// catches any blobs that were stored but not queued.
/// </summary>
public class AzureMessageStore
{
    private readonly BlobContainerClient _blobContainer;
    private readonly QueueClient _queue;
    private readonly AzureStorageSettings _settings;
    private readonly ILogger<AzureMessageStore> _logger;
    private readonly string _fallbackPath;

    public AzureMessageStore(
        IOptions<AzureStorageSettings> settings,
        ILogger<AzureMessageStore> logger)
    {
        _settings = settings.Value;
        _logger = logger;
        _fallbackPath = Path.Combine(AppContext.BaseDirectory, "fallback");

        if (_settings.UseManagedIdentity)
        {
            var credential = new DefaultAzureCredential();
            var blobService = new BlobServiceClient(_settings.BlobServiceUri, credential);
            _blobContainer = blobService.GetBlobContainerClient(_settings.BlobContainerName);
            var queueService = new QueueServiceClient(_settings.QueueServiceUri, credential);
            _queue = queueService.GetQueueClient(_settings.QueueName);
        }
        else
        {
            _blobContainer = new BlobContainerClient(_settings.ConnectionString, _settings.BlobContainerName);
            _queue = new QueueClient(_settings.ConnectionString, _settings.QueueName);
        }
    }

    public async Task InitializeAsync(CancellationToken ct)
    {
        await _blobContainer.CreateIfNotExistsAsync(cancellationToken: ct);
        await _queue.CreateIfNotExistsAsync(cancellationToken: ct);
        Directory.CreateDirectory(_fallbackPath);
    }

    /// <summary>
    /// Stores the raw message bytes. Called on the SMTP critical path.
    /// Returns the blob name for reference.
    /// </summary>
    public async Task<string> StoreRawMessageAsync(
        byte[] rawMessage, string envelopeFrom, string envelopeTo, CancellationToken ct)
    {
        var id = Guid.NewGuid().ToString();
        var receivedUtc = DateTimeOffset.UtcNow;
        var blobName = $"{receivedUtc:yyyy/MM/dd}/{id}.eml";

        try
        {
            // 1. Write raw bytes to blob — this is the durable store
            var blobClient = _blobContainer.GetBlobClient(blobName);
            await blobClient.UploadAsync(new BinaryData(rawMessage), overwrite: false, cancellationToken: ct);

            _logger.LogInformation("Blob stored: {BlobName} ({Size} bytes)", blobName, rawMessage.Length);

            // 2. Enqueue processing message (best-effort — sweep catches misses)
            try
            {
                var queueMsg = new QueueMessage(id, blobName, envelopeFrom, envelopeTo, receivedUtc);
                await _queue.SendMessageAsync(
                    JsonSerializer.Serialize(queueMsg), cancellationToken: ct);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Queue enqueue failed for {BlobName}, will be caught by sweep", blobName);
            }
        }
        catch (Exception ex)
        {
            // Azure Storage is down — fall back to local filesystem
            _logger.LogError(ex, "Blob upload failed, falling back to local disk for {Id}", id);
            await StoreToFallbackAsync(id, rawMessage, envelopeFrom, envelopeTo, receivedUtc);
        }

        return blobName;
    }

    private async Task StoreToFallbackAsync(
        string id, byte[] rawMessage, string envelopeFrom, string envelopeTo, DateTimeOffset receivedUtc)
    {
        var emlPath = Path.Combine(_fallbackPath, $"{id}.eml");
        var metaPath = Path.Combine(_fallbackPath, $"{id}.meta");

        await File.WriteAllBytesAsync(emlPath, rawMessage);
        await File.WriteAllTextAsync(metaPath, $"{envelopeFrom}\n{envelopeTo}\n{receivedUtc:O}");

        _logger.LogInformation("Fallback stored: {Id} ({Size} bytes)", id, rawMessage.Length);
    }

    /// <summary>
    /// Recovers messages from local fallback to Azure Storage.
    /// Called on startup.
    /// </summary>
    public async Task RecoverFallbackAsync(CancellationToken ct)
    {
        if (!Directory.Exists(_fallbackPath)) return;

        var emlFiles = Directory.GetFiles(_fallbackPath, "*.eml");
        if (emlFiles.Length == 0) return;

        _logger.LogInformation("Recovering {Count} fallback messages", emlFiles.Length);

        foreach (var emlPath in emlFiles)
        {
            ct.ThrowIfCancellationRequested();
            var id = Path.GetFileNameWithoutExtension(emlPath);
            var metaPath = Path.ChangeExtension(emlPath, ".meta");

            try
            {
                var rawMessage = await File.ReadAllBytesAsync(emlPath, ct);
                var metaLines = await File.ReadAllLinesAsync(metaPath, ct);
                if (metaLines.Length < 3) continue;

                var envelopeFrom = metaLines[0];
                var envelopeTo = metaLines[1];
                var receivedUtc = DateTimeOffset.Parse(metaLines[2], null, System.Globalization.DateTimeStyles.RoundtripKind);

                var blobName = $"{receivedUtc:yyyy/MM/dd}/{id}.eml";
                var blobClient = _blobContainer.GetBlobClient(blobName);
                await blobClient.UploadAsync(new BinaryData(rawMessage), overwrite: false, cancellationToken: ct);

                var queueMsg = new QueueMessage(id, blobName, envelopeFrom, envelopeTo, receivedUtc);
                await _queue.SendMessageAsync(
                    JsonSerializer.Serialize(queueMsg), cancellationToken: ct);

                File.Delete(emlPath);
                File.Delete(metaPath);

                _logger.LogInformation("Recovered fallback message {Id}", id);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Failed to recover {Id}, will retry next startup", id);
            }
        }
    }
}

public record QueueMessage(
    string Id,
    string BlobName,
    string EnvelopeFrom,
    string EnvelopeTo,
    DateTimeOffset ReceivedUtc);
