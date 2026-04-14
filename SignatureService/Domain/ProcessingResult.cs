namespace SignatureService.Domain;

/// <summary>
/// Result of processing a message through the signature pipeline.
/// Used for logging, metrics, and debugging.
/// </summary>
public class ProcessingResult
{
    public string MessageId { get; set; } = string.Empty;
    public string QueueItemId { get; set; } = string.Empty;
    public ProcessingOutcome Outcome { get; set; }
    public string? MatchedRuleId { get; set; }
    public string? TemplateId { get; set; }
    public MessageType? DetectedMessageType { get; set; }
    public string? DetectedReplyBoundary { get; set; }
    public string? SkipReason { get; set; }
    public string? ErrorMessage { get; set; }
    public int RetryCount { get; set; }
    public DateTimeOffset ProcessedUtc { get; set; }
    public double ProcessingMs { get; set; }
}

public enum ProcessingOutcome
{
    /// <summary>Signature injected and message forwarded successfully.</summary>
    SignatureApplied,

    /// <summary>No matching rule — forwarded without modification.</summary>
    NoMatchingRule,

    /// <summary>Skipped due to skip condition — forwarded without modification.</summary>
    Skipped,

    /// <summary>Forwarding failed — will be retried.</summary>
    ForwardingFailed,

    /// <summary>Processing failed — will be retried.</summary>
    ProcessingError,

    /// <summary>Exceeded max retries — moved to poison/dead-letter.</summary>
    Poisoned
}
