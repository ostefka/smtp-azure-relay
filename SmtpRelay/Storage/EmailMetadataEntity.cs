using Azure.Data.Tables;

namespace SmtpRelay.Storage;

/// <summary>
/// Table Storage entity for parsed email metadata.
/// PartitionKey = date (yyyy-MM-dd) for efficient range queries.
/// RowKey = message GUID for uniqueness.
/// </summary>
public class EmailMetadataEntity : ITableEntity
{
    public string PartitionKey { get; set; } = string.Empty;
    public string RowKey { get; set; } = string.Empty;
    public DateTimeOffset? Timestamp { get; set; }
    public Azure.ETag ETag { get; set; }

    // Envelope
    public string EnvelopeFrom { get; set; } = string.Empty;
    public string EnvelopeTo { get; set; } = string.Empty;

    // Parsed headers
    public string From { get; set; } = string.Empty;
    public string To { get; set; } = string.Empty;
    public string Cc { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string MessageId { get; set; } = string.Empty;
    public string InReplyTo { get; set; } = string.Empty;
    public DateTimeOffset MessageDate { get; set; }

    // Storage references
    public string BlobName { get; set; } = string.Empty;
    public long SizeBytes { get; set; }
    public bool HasAttachments { get; set; }
    public int AttachmentCount { get; set; }

    // Processing
    public DateTimeOffset ReceivedUtc { get; set; }
    public DateTimeOffset? ProcessedUtc { get; set; }
    public string Status { get; set; } = "Pending"; // Pending, Processed, Failed
}
