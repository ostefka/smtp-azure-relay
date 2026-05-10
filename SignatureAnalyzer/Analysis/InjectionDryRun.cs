using System.Diagnostics;
using Microsoft.Extensions.Logging;
using MimeKit;
using SignatureAnalyzer.Models;
using SignatureService.Engine;

namespace SignatureAnalyzer.Analysis;

/// <summary>
/// Runs each specimen through the real SignatureInjector pipeline without
/// any network calls. Captures detailed results for analysis.
///
/// SAFETY: This class has NO SMTP client, NO network output capability.
/// It only reads .eml files and writes results to local filesystem.
/// </summary>
public class InjectionDryRun
{
    private readonly SignatureInjector _injector;
    private readonly ReplyBoundaryDetector _boundaryDetector;
    private readonly ILogger<InjectionDryRun> _logger;

    public InjectionDryRun(
        SignatureInjector injector,
        ReplyBoundaryDetector boundaryDetector,
        ILogger<InjectionDryRun> logger)
    {
        _injector = injector;
        _boundaryDetector = boundaryDetector;
        _logger = logger;
    }

    /// <summary>
    /// Run the injection pipeline on a specimen .eml file.
    /// Returns detailed results without modifying the original file.
    /// </summary>
    public InjectionResult Test(string emlPath)
    {
        var result = new InjectionResult();
        var sw = Stopwatch.StartNew();

        try
        {
            // Load message from file
            MimeMessage message;
            using (var stream = File.OpenRead(emlPath))
            {
                message = MimeMessage.Load(stream);
            }

            // Capture pre-injection state
            var preHtml = GetHtmlBody(message);
            var preText = GetTextBody(message);
            var preEncoding = GetHtmlEncoding(message);

            // Build fake envelope recipients from To/Cc headers
            var recipients = message.To.Mailboxes
                .Concat(message.Cc.Mailboxes)
                .Select(m => m.Address)
                .ToList();

            if (recipients.Count == 0)
                recipients.Add("test@example.com");

            // Run through the real injector — this modifies the message in memory only
            var processingResult = _injector.Process(message, recipients);

            result.Outcome = processingResult.Outcome.ToString();
            result.DetectedBoundary = processingResult.DetectedReplyBoundary;

            // Capture post-injection state
            var postHtml = GetHtmlBody(message);
            var postText = GetTextBody(message);
            var postEncoding = GetHtmlEncoding(message);

            // Validate output
            result.Success = processingResult.Outcome == SignatureService.Domain.ProcessingOutcome.SignatureApplied
                || processingResult.Outcome == SignatureService.Domain.ProcessingOutcome.Skipped
                || processingResult.Outcome == SignatureService.Domain.ProcessingOutcome.NoMatchingRule;

            // Check MIME validity — re-serialize and re-parse
            result.OutputMimeValid = ValidateMimeRoundtrip(message);

            // Check HTML well-formedness
            if (postHtml != null)
            {
                result.OutputHtmlWellFormed = CheckHtmlWellFormed(postHtml);
                result.HtmlSizeDelta = (postHtml?.Length ?? 0) - (preHtml?.Length ?? 0);

                // Determine injection point
                if (preHtml != null && postHtml != null && postHtml.Length > preHtml.Length)
                {
                    result.InjectionPoint = DetermineInjectionPoint(preHtml, postHtml);
                }
            }

            // Check text part updated
            result.TextPartUpdated = postText != null && postText != preText;

            // Check encoding preserved
            result.EncodingPreserved = postEncoding == preEncoding;
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.Outcome = "Error";
            result.ErrorMessage = ex.Message;
            _logger.LogError(ex, "Injection dry-run failed for {Path}", emlPath);
        }

        sw.Stop();
        result.ProcessingTimeMs = sw.ElapsedMilliseconds;
        return result;
    }

    private static string? GetHtmlBody(MimeMessage message)
    {
        foreach (var part in message.BodyParts.OfType<MimeKit.TextPart>())
        {
            if (part.IsHtml)
                return part.Text;
        }
        return null;
    }

    private static string? GetTextBody(MimeMessage message)
    {
        foreach (var part in message.BodyParts.OfType<MimeKit.TextPart>())
        {
            if (!part.IsHtml)
                return part.Text;
        }
        return null;
    }

    private static string? GetHtmlEncoding(MimeMessage message)
    {
        foreach (var part in message.BodyParts.OfType<MimeKit.TextPart>())
        {
            if (part.IsHtml)
                return part.ContentTransferEncoding.ToString();
        }
        return null;
    }

    private static bool ValidateMimeRoundtrip(MimeMessage message)
    {
        try
        {
            using var ms = new MemoryStream();
            message.WriteTo(ms);
            ms.Position = 0;
            var reparsed = MimeMessage.Load(ms);
            return reparsed.Body != null;
        }
        catch
        {
            return false;
        }
    }

    private static bool CheckHtmlWellFormed(string html)
    {
        // Basic checks — not a full parser, just structural integrity
        var hasHtml = html.Contains("<html", StringComparison.OrdinalIgnoreCase)
            || html.Contains("<body", StringComparison.OrdinalIgnoreCase);

        if (!hasHtml)
            return true; // Fragment HTML is OK

        var htmlOpen = CountOccurrences(html, "<html");
        var htmlClose = CountOccurrences(html, "</html>");
        var bodyOpen = CountOccurrences(html, "<body");
        var bodyClose = CountOccurrences(html, "</body>");

        // Should have balanced tags
        return htmlOpen == htmlClose && bodyOpen == bodyClose;
    }

    private static int CountOccurrences(string text, string pattern)
    {
        int count = 0, i = 0;
        while ((i = text.IndexOf(pattern, i, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            i += pattern.Length;
        }
        return count;
    }

    private string DetermineInjectionPoint(string preHtml, string postHtml)
    {
        // Find where the signature was inserted by comparing pre/post HTML
        var sigMarker = "org-email-signature";
        var sigIndex = postHtml.IndexOf(sigMarker, StringComparison.OrdinalIgnoreCase);
        if (sigIndex < 0) return "unknown";

        // Check what's after the signature div
        var afterSig = postHtml[(sigIndex + sigMarker.Length)..];

        if (afterSig.Contains("divRplyFwdMsg", StringComparison.OrdinalIgnoreCase)
            || afterSig.Contains("gmail_quote", StringComparison.OrdinalIgnoreCase)
            || afterSig.Contains("moz-cite-prefix", StringComparison.OrdinalIgnoreCase))
            return "before-reply-boundary";

        if (afterSig.TrimEnd().EndsWith("</body>", StringComparison.OrdinalIgnoreCase)
            || afterSig.TrimEnd().EndsWith("</html>", StringComparison.OrdinalIgnoreCase))
            return "end-of-body";

        return "mid-body";
    }
}
