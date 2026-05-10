using System.Text.RegularExpressions;
using MimeKit;
using MimeKit.Cryptography;
using Microsoft.Extensions.Logging;
using SignatureAnalyzer.Models;
using SignatureService.Engine;

namespace SignatureAnalyzer.Analysis;

/// <summary>
/// Computes a structural fingerprint for a MimeMessage — captures everything
/// relevant to signature injection without any message content.
/// </summary>
public class FingerprintEngine
{
    private readonly ReplyBoundaryDetector _boundaryDetector;
    private readonly ILogger<FingerprintEngine> _logger;

    // Known client patterns from X-Mailer, User-Agent, X-MimeOLE
    private static readonly (string Pattern, string Family)[] ClientPatterns =
    [
        ("Microsoft Outlook 16", "Outlook-Desktop"),
        ("Microsoft Outlook 15", "Outlook-Desktop"),
        ("Microsoft Outlook", "Outlook-Desktop"),
        ("Outlook-iOS", "Outlook-Mobile"),
        ("Outlook-Android", "Outlook-Mobile"),
        ("Microsoft-MacOutlook", "Outlook-Mac"),
        ("OWA", "OWA"),
        // OWA messages often lack X-Mailer but have x-ms-exchange headers
        ("Thunderbird", "Thunderbird"),
        ("Apple Mail", "AppleMail"),
        ("iPhone Mail", "AppleMail-iOS"),
        ("iPad Mail", "AppleMail-iOS"),
        ("Gmail", "Gmail"),
        ("Evolution", "Evolution"),
        ("Mutt", "Mutt"),
        ("Lotus Notes", "LotusNotes"),
        ("The Bat!", "TheBat"),
        ("Postfix", "Postfix"),
    ];

    // Known HTML body wrapper patterns (class/id on container divs)
    private static readonly (string Pattern, string Name)[] BodyWrapperPatterns =
    [
        ("class=\"elementToProof\"", "OWA-elementToProof"),
        ("class=\"x_elementToProof\"", "OWA-x_elementToProof"),
        ("id=\"divtagdefaultwrapper\"", "OWA-divtagdefaultwrapper"),
        ("id=\"bodyTable\"", "template-bodyTable"),
        ("class=\"WordSection1\"", "Outlook-WordSection1"),
        ("class=\"MsoNormal\"", "Outlook-MsoNormal"),
        ("dir=\"ltr\"", "generic-ltr"),
        ("dir=\"rtl\"", "generic-rtl"),
    ];

    // Existing signature markers
    private static readonly (string Pattern, string Name)[] SignaturePatterns =
    [
        ("class=\"gmail_signature\"", "Gmail-signature"),
        ("id=\"Signature\"", "OWA-Signature"),
        ("id=\"signature\"", "generic-id-signature"),
        ("class=\"signature\"", "generic-class-signature"),
        ("id=\"mail-signature\"", "generic-mail-signature"),
        ("-- \r\n", "sigdash-crlf"),
        ("-- \n", "sigdash-lf"),
        ("_______________", "outlook-underscore-separator"),
        ("class=\"moz-signature\"", "thunderbird-signature"),
    ];

    public FingerprintEngine(
        ReplyBoundaryDetector boundaryDetector,
        ILogger<FingerprintEngine> logger)
    {
        _boundaryDetector = boundaryDetector;
        _logger = logger;
    }

    public MessageFingerprint ComputeFingerprint(MimeMessage message)
    {
        var fp = new MessageFingerprint();

        // 1. Client identification
        var (client, family) = DetectClient(message);
        fp.Client = client;
        fp.ClientFamily = family;

        // 2. Message type
        fp.MessageType = DetectMessageType(message);

        // 3. MIME tree shape
        fp.MimeTreeShape = BuildMimeTreeShape(message.Body);

        // 4. Primary content type
        fp.PrimaryContentType = GetPrimaryContentType(message);

        // 5. HTML part analysis
        var htmlPart = FindHtmlPart(message.Body);
        if (htmlPart != null)
        {
            fp.HtmlEncoding = htmlPart.ContentTransferEncoding.ToString().ToLower();
            fp.HtmlCharset = htmlPart.ContentType.Charset?.ToLower() ?? "unspecified";

            var html = htmlPart.GetText(System.Text.Encoding.UTF8);
            if (!string.IsNullOrEmpty(html))
            {
                // Reply boundary detection
                var boundary = _boundaryDetector.FindHtmlBoundary(html);
                fp.ReplyBoundaryPattern = boundary.Index >= 0 ? boundary.DetectorName : "none";

                // Well-formed check
                fp.IsWellFormedHtml = html.Contains("<html", StringComparison.OrdinalIgnoreCase)
                    && html.Contains("<body", StringComparison.OrdinalIgnoreCase);

                // CSS style block
                fp.HasCssStyleBlock = html.Contains("<style", StringComparison.OrdinalIgnoreCase);

                // Body wrapper pattern
                fp.BodyWrapperPattern = DetectBodyWrapper(html);

                // Existing signature
                var (hasSig, sigPattern) = DetectExistingSignature(html);
                fp.HasExistingSignature = hasSig;
                fp.ExistingSignaturePattern = sigPattern;
            }
        }
        else
        {
            // Plain text only — check for text reply boundary
            var textPart = FindTextPart(message.Body);
            if (textPart != null)
            {
                var text = textPart.GetText(System.Text.Encoding.UTF8);
                if (!string.IsNullOrEmpty(text))
                {
                    var boundary = _boundaryDetector.FindPlainTextBoundary(text);
                    fp.ReplyBoundaryPattern = boundary.Index >= 0 ? boundary.DetectorName : "none";

                    var (hasSig, sigPattern) = DetectExistingSignatureText(text);
                    fp.HasExistingSignature = hasSig;
                    fp.ExistingSignaturePattern = sigPattern;
                }

                fp.HtmlEncoding = textPart.ContentTransferEncoding.ToString().ToLower();
                fp.HtmlCharset = textPart.ContentType.Charset?.ToLower() ?? "unspecified";
            }
        }

        // 6. Inline images
        fp.HasInlineImages = HasInlineContent(message.Body);

        // 7. Attachments
        fp.HasAttachments = message.Attachments.Any();

        // 8. Encryption
        fp.IsEncrypted = message.Body is MultipartEncrypted
            || message.Body is ApplicationPkcs7Mime;

        // 9. Reply chain depth
        fp.ReplyChainDepth = message.References.Count;

        return fp;
    }

    private static (string Client, string Family) DetectClient(MimeMessage message)
    {
        // Check X-Mailer, User-Agent, X-MimeOLE
        var markers = new[]
        {
            message.Headers["X-Mailer"],
            message.Headers["User-Agent"],
            message.Headers["X-MimeOLE"],
            message.Headers["X-Microsoft-Original-Message-Source"],
        };

        foreach (var marker in markers)
        {
            if (string.IsNullOrEmpty(marker)) continue;

            foreach (var (pattern, family) in ClientPatterns)
            {
                if (marker.Contains(pattern, StringComparison.OrdinalIgnoreCase))
                    return (marker.Trim(), family);
            }

            return (marker.Trim(), "Other");
        }

        // Check for OWA/EXO signatures in other headers
        if (message.Headers["X-MS-Exchange-MessageSentRepresentingType"] != null
            || message.Headers["X-MS-Has-Attach"] != null)
            return ("Exchange (headerDetected)", "Exchange-Server");

        return ("Unknown", "Unknown");
    }

    private static string DetectMessageType(MimeMessage message)
    {
        if (!string.IsNullOrEmpty(message.InReplyTo) || message.References.Count > 0)
        {
            var subject = message.Subject?.TrimStart() ?? "";
            if (Regex.IsMatch(subject, @"^(FW|FWD|WG|Wg)\s*:", RegexOptions.IgnoreCase))
                return "Forward";
            return "Reply";
        }

        var subject2 = message.Subject?.TrimStart() ?? "";
        if (Regex.IsMatch(subject2, @"^(FW|FWD|WG|Wg)\s*:", RegexOptions.IgnoreCase))
            return "Forward";
        if (Regex.IsMatch(subject2, @"^(RE|Re|AW|Aw|SV)\s*:", RegexOptions.IgnoreCase))
            return "Reply";

        return "New";
    }

    private static string BuildMimeTreeShape(MimeEntity entity, int depth = 0)
    {
        if (depth > 10) return "...";

        if (entity is Multipart multipart)
        {
            var children = multipart.Select(c => BuildMimeTreeShape(c, depth + 1));
            return $"{multipart.ContentType.MimeType}({string.Join("+", children)})";
        }

        return entity.ContentType.MimeType;
    }

    private static string GetPrimaryContentType(MimeMessage message)
    {
        if (message.Body is Multipart)
            return message.Body.ContentType.MimeType;
        return message.Body.ContentType.MimeType;
    }

    private static TextPart? FindHtmlPart(MimeEntity entity)
    {
        if (entity is TextPart text && text.IsHtml)
            return text;

        if (entity is Multipart multipart)
        {
            foreach (var child in multipart)
            {
                var found = FindHtmlPart(child);
                if (found != null) return found;
            }
        }

        return null;
    }

    private static TextPart? FindTextPart(MimeEntity entity)
    {
        if (entity is TextPart text && !text.IsHtml)
            return text;

        if (entity is Multipart multipart)
        {
            foreach (var child in multipart)
            {
                var found = FindTextPart(child);
                if (found != null) return found;
            }
        }

        return null;
    }

    private static bool HasInlineContent(MimeEntity entity)
    {
        if (entity is MimePart part
            && part.ContentDisposition?.Disposition == ContentDisposition.Inline
            && part.ContentId != null)
            return true;

        if (entity is Multipart multipart)
            return multipart.Any(c => HasInlineContent(c));

        return false;
    }

    private static string DetectBodyWrapper(string html)
    {
        foreach (var (pattern, name) in BodyWrapperPatterns)
        {
            if (html.Contains(pattern, StringComparison.OrdinalIgnoreCase))
                return name;
        }
        return "none";
    }

    private static (bool HasSignature, string Pattern) DetectExistingSignature(string html)
    {
        foreach (var (pattern, name) in SignaturePatterns)
        {
            if (html.Contains(pattern, StringComparison.OrdinalIgnoreCase))
                return (true, name);
        }
        return (false, "none");
    }

    private static (bool HasSignature, string Pattern) DetectExistingSignatureText(string text)
    {
        if (text.Contains("-- \r\n") || text.Contains("-- \n"))
            return (true, "sigdash");
        return (false, "none");
    }
}
