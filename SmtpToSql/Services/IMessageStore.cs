namespace SmtpToSql.Services;

/// <summary>
/// Durable store for raw SMTP messages. Provides two-phase reliability:
/// Phase 1 (SMTP time): StoreRawMessageAsync - must succeed before 250 OK is returned.
/// Phase 2 (async worker): GetPendingMessagesAsync / MarkAsProcessedAsync - can retry safely.
/// </summary>
public interface IMessageStore
{
    /// <summary>
    /// Durably stores the raw RFC 5322 message bytes. Called during SMTP transaction.
    /// Must be fast and reliable - this is the critical path.
    /// Falls back to filesystem if SQL is unavailable.
    /// </summary>
    Task<Guid> StoreRawMessageAsync(byte[] rawMessage, string envelopeFrom, string envelopeTo, CancellationToken ct);

    /// <summary>
    /// Returns unprocessed messages for the background worker to parse and store in CRM tables.
    /// </summary>
    Task<IReadOnlyList<RawMessageRecord>> GetPendingMessagesAsync(int batchSize, CancellationToken ct);

    /// <summary>
    /// Marks a message as successfully processed (parsed and written to CRM tables).
    /// </summary>
    Task MarkAsProcessedAsync(Guid messageId, CancellationToken ct);

    /// <summary>
    /// Marks a message as failed with error details for investigation.
    /// </summary>
    Task MarkAsFailedAsync(Guid messageId, string error, CancellationToken ct);

    /// <summary>
    /// Recovers any messages that were written to fallback filesystem storage
    /// and moves them into the primary SQL store.
    /// </summary>
    Task RecoverFallbackMessagesAsync(CancellationToken ct);
}

public record RawMessageRecord(
    Guid Id,
    byte[] RawMessage,
    string EnvelopeFrom,
    string EnvelopeTo,
    DateTime ReceivedUtc,
    int RetryCount);
