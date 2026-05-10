namespace SignatureAnalyzer.Models;

/// <summary>
/// Structural fingerprint of an email message — captures the shape of the message
/// without any content. Two messages with the same fingerprint would be processed
/// identically by the signature engine.
/// </summary>
public class MessageFingerprint
{
    /// <summary>Client identifier from X-Mailer, User-Agent, or X-MimeOLE headers.</summary>
    public string Client { get; set; } = "Unknown";

    /// <summary>Normalized client family (Outlook, OWA, Gmail, AppleMail, Thunderbird, etc.).</summary>
    public string ClientFamily { get; set; } = "Unknown";

    /// <summary>New, Reply, Forward, ReplyAll.</summary>
    public string MessageType { get; set; } = "Unknown";

    /// <summary>MIME tree shape, e.g. "multipart/mixed > multipart/alternative > text/plain + text/html".</summary>
    public string MimeTreeShape { get; set; } = "";

    /// <summary>Primary content type (text/plain, text/html, multipart/alternative).</summary>
    public string PrimaryContentType { get; set; } = "";

    /// <summary>Content-Transfer-Encoding of the HTML part (quoted-printable, base64, 7bit, 8bit).</summary>
    public string HtmlEncoding { get; set; } = "none";

    /// <summary>Charset of the HTML part.</summary>
    public string HtmlCharset { get; set; } = "none";

    /// <summary>Whether the message has inline images (CID references).</summary>
    public bool HasInlineImages { get; set; }

    /// <summary>Whether the message has file attachments.</summary>
    public bool HasAttachments { get; set; }

    /// <summary>Whether an existing signature block was detected.</summary>
    public bool HasExistingSignature { get; set; }

    /// <summary>Name of the existing signature pattern (if any).</summary>
    public string ExistingSignaturePattern { get; set; } = "none";

    /// <summary>Whether the HTML has a &lt;style&gt; block.</summary>
    public bool HasCssStyleBlock { get; set; }

    /// <summary>Whether the HTML body is wrapped in a container div with a known class/id.</summary>
    public string BodyWrapperPattern { get; set; } = "none";

    /// <summary>Reply/forward boundary pattern name (from ReplyBoundaryDetector).</summary>
    public string ReplyBoundaryPattern { get; set; } = "none";

    /// <summary>Whether the message is S/MIME encrypted or signed.</summary>
    public bool IsEncrypted { get; set; }

    /// <summary>Depth of reply chain (count of In-Reply-To / References).</summary>
    public int ReplyChainDepth { get; set; }

    /// <summary>Whether the HTML is well-formed (has html/body tags).</summary>
    public bool IsWellFormedHtml { get; set; }

    /// <summary>
    /// Compact string key used for deduplication — messages with the same key
    /// are structurally identical from the signature engine's perspective.
    /// </summary>
    public string Key => string.Join("|",
        ClientFamily, MessageType, MimeTreeShape, PrimaryContentType,
        HtmlEncoding, HasInlineImages, HasAttachments,
        HasExistingSignature ? ExistingSignaturePattern : "nosig",
        HasCssStyleBlock, BodyWrapperPattern, ReplyBoundaryPattern,
        IsEncrypted, IsWellFormedHtml);

    public override string ToString() => Key;
}
