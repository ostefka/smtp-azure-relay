using System.Buffers;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmtpToSql.Configuration;

namespace SmtpToSql.Services;

public class DurableMessageStore : IMessageStore
{
    private readonly SqlSettings _sqlSettings;
    private readonly FallbackStorageSettings _fallbackSettings;
    private readonly ILogger<DurableMessageStore> _logger;

    public DurableMessageStore(
        IOptions<SqlSettings> sqlSettings,
        IOptions<FallbackStorageSettings> fallbackSettings,
        ILogger<DurableMessageStore> logger)
    {
        _sqlSettings = sqlSettings.Value;
        _fallbackSettings = fallbackSettings.Value;
        _logger = logger;

        Directory.CreateDirectory(_fallbackSettings.Path);
    }

    public async Task<Guid> StoreRawMessageAsync(byte[] rawMessage, string envelopeFrom, string envelopeTo, CancellationToken ct)
    {
        var messageId = Guid.NewGuid();
        var receivedUtc = DateTime.UtcNow;

        try
        {
            await StoreToSqlAsync(messageId, rawMessage, envelopeFrom, envelopeTo, receivedUtc, ct);
            _logger.LogInformation("Message {MessageId} stored to SQL ({Size} bytes)", messageId, rawMessage.Length);
        }
        catch (Exception ex)
        {
            // SQL is down — fall back to filesystem to avoid rejecting the message
            _logger.LogWarning(ex, "SQL unavailable, falling back to filesystem for message {MessageId}", messageId);
            await StoreToFilesystemAsync(messageId, rawMessage, envelopeFrom, envelopeTo, receivedUtc);
            _logger.LogInformation("Message {MessageId} stored to fallback filesystem ({Size} bytes)", messageId, rawMessage.Length);
        }

        return messageId;
    }

    private async Task StoreToSqlAsync(Guid messageId, byte[] rawMessage, string envelopeFrom, string envelopeTo, DateTime receivedUtc, CancellationToken ct)
    {
        const string sql = """
            INSERT INTO RawMessages (Id, RawMessage, EnvelopeFrom, EnvelopeTo, ReceivedUtc, Status, RetryCount)
            VALUES (@Id, @RawMessage, @EnvelopeFrom, @EnvelopeTo, @ReceivedUtc, 0, 0)
            """;

        await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
        await connection.OpenAsync(ct);

        await using var cmd = new SqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@Id", messageId);
        cmd.Parameters.AddWithValue("@RawMessage", rawMessage);
        cmd.Parameters.AddWithValue("@EnvelopeFrom", envelopeFrom);
        cmd.Parameters.AddWithValue("@EnvelopeTo", envelopeTo);
        cmd.Parameters.AddWithValue("@ReceivedUtc", receivedUtc);

        await cmd.ExecuteNonQueryAsync(ct);
    }

    private async Task StoreToFilesystemAsync(Guid messageId, byte[] rawMessage, string envelopeFrom, string envelopeTo, DateTime receivedUtc)
    {
        // Write raw message bytes to an .eml file, metadata to a .meta file
        var emlPath = Path.Combine(_fallbackSettings.Path, $"{messageId}.eml");
        var metaPath = Path.Combine(_fallbackSettings.Path, $"{messageId}.meta");

        await File.WriteAllBytesAsync(emlPath, rawMessage);
        await File.WriteAllTextAsync(metaPath, $"{envelopeFrom}\n{envelopeTo}\n{receivedUtc:O}");
    }

    public async Task<IReadOnlyList<RawMessageRecord>> GetPendingMessagesAsync(int batchSize, CancellationToken ct)
    {
        const string sql = """
            SELECT TOP (@BatchSize) Id, RawMessage, EnvelopeFrom, EnvelopeTo, ReceivedUtc, RetryCount
            FROM RawMessages
            WHERE Status = 0 AND RetryCount < 10
            ORDER BY ReceivedUtc ASC
            """;

        await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
        await connection.OpenAsync(ct);

        await using var cmd = new SqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@BatchSize", batchSize);

        var results = new List<RawMessageRecord>();
        await using var reader = await cmd.ExecuteReaderAsync(ct);

        while (await reader.ReadAsync(ct))
        {
            results.Add(new RawMessageRecord(
                reader.GetGuid(0),
                (byte[])reader[1],
                reader.GetString(2),
                reader.GetString(3),
                reader.GetDateTime(4),
                reader.GetInt32(5)));
        }

        return results;
    }

    public async Task MarkAsProcessedAsync(Guid messageId, CancellationToken ct)
    {
        const string sql = "UPDATE RawMessages SET Status = 1, ProcessedUtc = @ProcessedUtc WHERE Id = @Id";

        await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
        await connection.OpenAsync(ct);

        await using var cmd = new SqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@Id", messageId);
        cmd.Parameters.AddWithValue("@ProcessedUtc", DateTime.UtcNow);

        await cmd.ExecuteNonQueryAsync(ct);
    }

    public async Task MarkAsFailedAsync(Guid messageId, string error, CancellationToken ct)
    {
        const string sql = """
            UPDATE RawMessages 
            SET RetryCount = RetryCount + 1, LastError = @Error, LastRetryUtc = @RetryUtc
            WHERE Id = @Id
            """;

        await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
        await connection.OpenAsync(ct);

        await using var cmd = new SqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@Id", messageId);
        cmd.Parameters.AddWithValue("@Error", error);
        cmd.Parameters.AddWithValue("@RetryUtc", DateTime.UtcNow);

        await cmd.ExecuteNonQueryAsync(ct);
    }

    public async Task RecoverFallbackMessagesAsync(CancellationToken ct)
    {
        var emlFiles = Directory.GetFiles(_fallbackSettings.Path, "*.eml");
        if (emlFiles.Length == 0) return;

        _logger.LogInformation("Recovering {Count} messages from fallback storage", emlFiles.Length);

        foreach (var emlPath in emlFiles)
        {
            ct.ThrowIfCancellationRequested();

            var messageIdStr = Path.GetFileNameWithoutExtension(emlPath);
            if (!Guid.TryParse(messageIdStr, out var messageId)) continue;

            var metaPath = Path.ChangeExtension(emlPath, ".meta");
            if (!File.Exists(metaPath)) continue;

            try
            {
                var rawMessage = await File.ReadAllBytesAsync(emlPath, ct);
                var metaLines = await File.ReadAllLinesAsync(metaPath, ct);

                if (metaLines.Length < 3) continue;

                var envelopeFrom = metaLines[0];
                var envelopeTo = metaLines[1];
                var receivedUtc = DateTime.Parse(metaLines[2], null, System.Globalization.DateTimeStyles.RoundtripKind);

                await StoreToSqlAsync(messageId, rawMessage, envelopeFrom, envelopeTo, receivedUtc, ct);

                File.Delete(emlPath);
                File.Delete(metaPath);

                _logger.LogInformation("Recovered fallback message {MessageId} to SQL", messageId);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Failed to recover fallback message {MessageId}, will retry later", messageId);
            }
        }
    }
}
