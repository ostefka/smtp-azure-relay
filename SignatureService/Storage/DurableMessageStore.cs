using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SignatureService.Configuration;

namespace SignatureService.Storage;

/// <summary>
/// Filesystem-based durable message queue. Messages are written to disk during
/// the SMTP transaction (critical path), then processed asynchronously by the worker.
///
/// Layout:
///   data/pending/{id}.eml   — raw email bytes
///   data/pending/{id}.meta  — envelope + processing metadata (JSON)
///   data/poison/{id}.eml    — messages that exceeded max retries
///   data/poison/{id}.meta
///
/// Guarantees:
///   - No message is lost: .eml is written and fsynced before SMTP 250 OK
///   - At-least-once processing: meta tracks retry count, worker is idempotent
///   - Poison isolation: failed messages don't block the queue
/// </summary>
public class DurableMessageStore
{
    private readonly string _pendingPath;
    private readonly string _poisonPath;
    private readonly ILogger<DurableMessageStore> _logger;

    public DurableMessageStore(
        IOptions<StorageSettings> settings,
        ILogger<DurableMessageStore> logger)
    {
        var basePath = Path.IsPathRooted(settings.Value.BasePath)
            ? settings.Value.BasePath
            : Path.Combine(AppContext.BaseDirectory, settings.Value.BasePath);

        _pendingPath = Path.Combine(basePath, settings.Value.PendingFolder);
        _poisonPath = Path.Combine(basePath, settings.Value.PoisonFolder);
        _logger = logger;
    }

    public void Initialize()
    {
        Directory.CreateDirectory(_pendingPath);
        Directory.CreateDirectory(_poisonPath);
        _logger.LogInformation("Durable store initialized: pending={Pending}, poison={Poison}",
            _pendingPath, _poisonPath);
    }

    /// <summary>Count of messages in pending queue (for health/metrics).</summary>
    public int PendingCount => Directory.Exists(_pendingPath)
        ? Directory.GetFiles(_pendingPath, "*.eml").Length : 0;

    /// <summary>Count of messages in poison queue (for health/metrics).</summary>
    public int PoisonCount => Directory.Exists(_poisonPath)
        ? Directory.GetFiles(_poisonPath, "*.eml").Length : 0;

    /// <summary>
    /// Stores a raw message to disk. Called on the SMTP critical path.
    /// Returns the queue item ID.
    /// </summary>
    public async Task<string> EnqueueAsync(
        byte[] rawMessage,
        string envelopeFrom,
        IReadOnlyList<string> envelopeTo,
        CancellationToken ct)
    {
        var id = $"{DateTimeOffset.UtcNow:yyyyMMddHHmmss}-{Guid.NewGuid():N}";
        var emlPath = Path.Combine(_pendingPath, $"{id}.eml");
        var metaPath = Path.Combine(_pendingPath, $"{id}.meta");

        var meta = new QueueItemMeta
        {
            Id = id,
            EnvelopeFrom = envelopeFrom,
            EnvelopeTo = envelopeTo.ToList(),
            ReceivedUtc = DateTimeOffset.UtcNow,
            RetryCount = 0,
            LastError = null
        };

        // Write .eml first — this is the most critical write
        await File.WriteAllBytesAsync(emlPath, rawMessage, ct);

        // Flush to disk to ensure durability
        await using (var fs = new FileStream(emlPath, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            fs.Flush(flushToDisk: true);
        }

        // Write metadata
        var metaJson = JsonSerializer.Serialize(meta, _jsonOptions);
        await File.WriteAllTextAsync(metaPath, metaJson, ct);

        _logger.LogDebug("Enqueued message {Id} from {From} ({Size} bytes)",
            id, envelopeFrom, rawMessage.Length);

        return id;
    }

    /// <summary>
    /// Gets the next batch of pending messages ordered by receive time.
    /// Returns only items that have a matching .eml + .meta pair.
    /// </summary>
    public async Task<List<QueueItem>> DequeueAsync(int batchSize, CancellationToken ct)
    {
        var items = new List<QueueItem>();

        var metaFiles = Directory.GetFiles(_pendingPath, "*.meta")
            .OrderBy(f => f) // filename starts with timestamp, so this is chronological
            .Take(batchSize);

        foreach (var metaPath in metaFiles)
        {
            ct.ThrowIfCancellationRequested();

            var id = Path.GetFileNameWithoutExtension(metaPath);
            var emlPath = Path.ChangeExtension(metaPath, ".eml");

            if (!File.Exists(emlPath))
            {
                _logger.LogWarning("Orphaned meta file without .eml: {Id}, removing", id);
                TryDelete(metaPath);
                continue;
            }

            try
            {
                var metaJson = await File.ReadAllTextAsync(metaPath, ct);
                var meta = JsonSerializer.Deserialize<QueueItemMeta>(metaJson, _jsonOptions);
                if (meta == null) continue;

                var rawMessage = await File.ReadAllBytesAsync(emlPath, ct);

                items.Add(new QueueItem
                {
                    Meta = meta,
                    RawMessage = rawMessage,
                    EmlPath = emlPath,
                    MetaPath = metaPath
                });
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Failed to read queue item {Id}, will retry next cycle", id);
            }
        }

        return items;
    }

    /// <summary>
    /// Marks a message as successfully processed — removes from pending.
    /// </summary>
    public void Complete(QueueItem item)
    {
        TryDelete(item.EmlPath);
        TryDelete(item.MetaPath);
        _logger.LogDebug("Completed and removed {Id}", item.Meta.Id);
    }

    /// <summary>
    /// Updates retry count and error. If max retries exceeded, moves to poison.
    /// </summary>
    public async Task FailAsync(QueueItem item, string error, int maxRetries, CancellationToken ct)
    {
        item.Meta.RetryCount++;
        item.Meta.LastError = error;
        item.Meta.LastAttemptUtc = DateTimeOffset.UtcNow;

        if (item.Meta.RetryCount >= maxRetries)
        {
            await MoveToPoisonAsync(item, ct);
            return;
        }

        // Update meta in place
        var metaJson = JsonSerializer.Serialize(item.Meta, _jsonOptions);
        await File.WriteAllTextAsync(item.MetaPath, metaJson, ct);

        _logger.LogWarning("Failed {Id} (attempt {Retry}/{Max}): {Error}",
            item.Meta.Id, item.Meta.RetryCount, maxRetries, error);
    }

    /// <summary>
    /// Moves a message to the poison folder for manual investigation.
    /// </summary>
    private async Task MoveToPoisonAsync(QueueItem item, CancellationToken ct)
    {
        var poisonEml = Path.Combine(_poisonPath, $"{item.Meta.Id}.eml");
        var poisonMeta = Path.Combine(_poisonPath, $"{item.Meta.Id}.meta");

        try
        {
            File.Move(item.EmlPath, poisonEml, overwrite: true);
            var metaJson = JsonSerializer.Serialize(item.Meta, _jsonOptions);
            await File.WriteAllTextAsync(poisonMeta, metaJson, ct);

            _logger.LogError("Poisoned message {Id} after {Retries} retries: {Error}",
                item.Meta.Id, item.Meta.RetryCount, item.Meta.LastError);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to move {Id} to poison — leaving in pending", item.Meta.Id);
        }
    }

    /// <summary>Returns count of pending messages (for health checks / metrics).</summary>
    public int GetPendingCount()
    {
        return Directory.Exists(_pendingPath)
            ? Directory.GetFiles(_pendingPath, "*.eml").Length
            : 0;
    }

    /// <summary>Returns count of poison messages.</summary>
    public int GetPoisonCount()
    {
        return Directory.Exists(_poisonPath)
            ? Directory.GetFiles(_poisonPath, "*.eml").Length
            : 0;
    }

    private void TryDelete(string path)
    {
        try { File.Delete(path); }
        catch (Exception ex) { _logger.LogWarning(ex, "Failed to delete {Path}", path); }
    }

    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };
}

public class QueueItemMeta
{
    public string Id { get; set; } = string.Empty;
    public string EnvelopeFrom { get; set; } = string.Empty;
    public List<string> EnvelopeTo { get; set; } = new();
    public DateTimeOffset ReceivedUtc { get; set; }
    public int RetryCount { get; set; }
    public string? LastError { get; set; }
    public DateTimeOffset? LastAttemptUtc { get; set; }
}

public class QueueItem
{
    public QueueItemMeta Meta { get; set; } = new();
    public byte[] RawMessage { get; set; } = Array.Empty<byte>();
    public string EmlPath { get; set; } = string.Empty;
    public string MetaPath { get; set; } = string.Empty;
}
