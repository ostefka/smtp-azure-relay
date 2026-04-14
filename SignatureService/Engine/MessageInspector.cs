using System.Text.RegularExpressions;
using MimeKit;
using MimeKit.Cryptography;
using SignatureService.Domain;

namespace SignatureService.Engine;

/// <summary>
/// Utility methods for inspecting MimeMessage properties that affect 
/// signature processing: message type detection, encryption check, etc.
/// </summary>
public static class MessageInspector
{
    /// <summary>
    /// Detects whether the message is a new compose, reply, or forward
    /// based on standard MIME headers and subject prefix conventions.
    /// </summary>
    public static MessageType DetectMessageType(MimeMessage message)
    {
        // Check In-Reply-To and References headers — replies always have these
        if (!string.IsNullOrEmpty(message.InReplyTo) || message.References.Count > 0)
        {
            // Distinguish reply from forward by subject prefix
            var subject = message.Subject?.TrimStart() ?? string.Empty;
            if (IsForwardPrefix(subject))
                return MessageType.Forward;

            return MessageType.Reply;
        }

        // No reply headers — check subject prefix as fallback
        var subj = message.Subject?.TrimStart() ?? string.Empty;
        if (IsReplyPrefix(subj))
            return MessageType.Reply;
        if (IsForwardPrefix(subj))
            return MessageType.Forward;

        return MessageType.New;
    }

    /// <summary>
    /// Returns true if the message is S/MIME encrypted or OpenPGP encrypted.
    /// These messages cannot be modified without breaking the encryption.
    /// </summary>
    public static bool IsEncryptedOrSigned(MimeMessage message)
    {
        if (message.Body is MultipartEncrypted)
            return true;

        if (message.Body is MultipartSigned)
            return true;

        // S/MIME: application/pkcs7-mime
        if (message.Body is MimePart part)
        {
            var ct = part.ContentType;
            if (ct.MimeType.Equals("application/pkcs7-mime", StringComparison.OrdinalIgnoreCase) ||
                ct.MimeType.Equals("application/x-pkcs7-mime", StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }

    /// <summary>
    /// Returns true if the message has no text body parts at all
    /// (e.g. calendar-only, DSN, or attachment-only messages).
    /// </summary>
    public static bool HasNoTextBody(MimeMessage message)
    {
        return !message.BodyParts.OfType<MimeKit.TextPart>().Any();
    }

    // Common reply prefixes across languages
    private static readonly Regex ReplyPrefixRegex = new(
        @"^(Re|AW|SV|Odp|Vá|VS|RE|Ref|Rif|BLS|RES)\s*[:：]",
        RegexOptions.IgnoreCase | RegexOptions.Compiled);

    // Common forward prefixes across languages  
    private static readonly Regex ForwardPrefixRegex = new(
        @"^(Fw|Fwd|WG|VS|Doorst|TR|ENC|RV|FS|I|Továbbítás)\s*[:：]",
        RegexOptions.IgnoreCase | RegexOptions.Compiled);

    private static bool IsReplyPrefix(string subject) => ReplyPrefixRegex.IsMatch(subject);
    private static bool IsForwardPrefix(string subject) => ForwardPrefixRegex.IsMatch(subject);
}
