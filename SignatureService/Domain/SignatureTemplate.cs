namespace SignatureService.Domain;

/// <summary>
/// A signature template with HTML and plain text variants.
/// Supports placeholder variables resolved from sender identity data.
/// </summary>
public class SignatureTemplate
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// HTML signature body. Supports {{placeholders}} resolved at processing time.
    /// Example: {{DisplayName}}, {{Title}}, {{Department}}, {{Phone}}, {{Email}}
    /// </summary>
    public string HtmlBody { get; set; } = string.Empty;

    /// <summary>
    /// Plain text signature body. Same {{placeholders}} as HTML.
    /// </summary>
    public string TextBody { get; set; } = string.Empty;
}

/// <summary>
/// Static identity data for a sender, used to resolve template placeholders.
/// Loaded from configuration. Replaceable with Graph API / Entra ID later.
/// </summary>
public class SenderIdentity
{
    public string Email { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;

    /// <summary>
    /// Arbitrary additional properties for custom template placeholders.
    /// Key = placeholder name, Value = replacement text.
    /// </summary>
    public Dictionary<string, string> CustomProperties { get; set; } = new();
}
