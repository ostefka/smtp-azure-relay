namespace SignatureService.Domain;

/// <summary>
/// A signature rule defines WHICH messages get WHICH signature.
/// Rules are evaluated in Priority order; first match wins.
/// Loaded from configuration now, replaceable with DB/API later.
/// </summary>
public class SignatureRule
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool Enabled { get; set; } = true;

    /// <summary>Lower value = higher priority. First matching rule wins.</summary>
    public int Priority { get; set; } = 100;

    /// <summary>Conditions that must all be true for this rule to apply.</summary>
    public RuleConditions Conditions { get; set; } = new();

    /// <summary>The template to apply when this rule matches.</summary>
    public string TemplateId { get; set; } = string.Empty;

    /// <summary>Where to place the signature in the message body.</summary>
    public SignaturePlacement Placement { get; set; } = SignaturePlacement.BeforeQuotedReply;
}

public class RuleConditions
{
    /// <summary>
    /// Sender address patterns. Supports exact match and wildcard:
    /// "user@domain.com", "*@domain.com", "*@*.domain.com"
    /// Empty = matches all senders.
    /// </summary>
    public List<string> SenderPatterns { get; set; } = new();

    /// <summary>
    /// Recipient scope filter.
    /// </summary>
    public RecipientScope RecipientScope { get; set; } = RecipientScope.All;

    /// <summary>
    /// Domains considered "internal" for RecipientScope.ExternalOnly / InternalOnly.
    /// Empty = use global InternalDomains from processing settings.
    /// </summary>
    public List<string> InternalDomains { get; set; } = new();

    /// <summary>
    /// Which message types this rule applies to.
    /// Empty = applies to all types.
    /// </summary>
    public List<MessageType> MessageTypes { get; set; } = new();

    /// <summary>
    /// Skip conditions — if any of these are true, skip this rule even if
    /// sender/recipient/type match.
    /// </summary>
    public SkipConditions Skip { get; set; } = new();
}

public class SkipConditions
{
    /// <summary>Skip if message is S/MIME encrypted or signed.</summary>
    public bool SkipEncrypted { get; set; } = true;

    /// <summary>Skip if message already has the loop-prevention header.</summary>
    public bool SkipAlreadySigned { get; set; } = true;

    /// <summary>Skip if message has no body parts (e.g. DSN, calendar-only).</summary>
    public bool SkipNoBody { get; set; } = true;
}

public enum RecipientScope
{
    /// <summary>Apply to all messages regardless of recipient.</summary>
    All,

    /// <summary>Apply only when all recipients are external.</summary>
    ExternalOnly,

    /// <summary>Apply only when all recipients are internal.</summary>
    InternalOnly,

    /// <summary>Apply when at least one recipient is external.</summary>
    AnyExternal
}

public enum MessageType
{
    New,
    Reply,
    Forward
}

public enum SignaturePlacement
{
    /// <summary>Insert between the user's new text and the quoted reply/forward (default).</summary>
    BeforeQuotedReply,

    /// <summary>Insert at the very end of the body (after everything including quoted text).</summary>
    AfterBody,

    /// <summary>Insert before the closing body tag (or append if no structure).</summary>
    BeforeBodyClose
}
