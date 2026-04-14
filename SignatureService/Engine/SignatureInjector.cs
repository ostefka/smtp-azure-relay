using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SignatureService.Configuration;
using SignatureService.Domain;

namespace SignatureService.Engine;

/// <summary>
/// Orchestrates the full signature injection pipeline for a single message:
/// 1. Inspect message (type, encrypted, etc.)
/// 2. Evaluate rules → find matching rule
/// 3. Resolve template with sender identity
/// 4. Detect reply boundary in body
/// 5. Inject signature HTML/text at the right position
/// 6. Stamp loop-prevention header
/// </summary>
public class SignatureInjector
{
    private readonly RuleEvaluator _ruleEvaluator;
    private readonly TemplateEngine _templateEngine;
    private readonly ReplyBoundaryDetector _boundaryDetector;
    private readonly ProcessingSettings _processingSettings;
    private readonly ILogger<SignatureInjector> _logger;

    private const string SignatureWrapperStart = "<div class=\"org-email-signature\" data-signature=\"auto\">";
    private const string SignatureWrapperEnd = "</div>";

    public SignatureInjector(
        RuleEvaluator ruleEvaluator,
        TemplateEngine templateEngine,
        ReplyBoundaryDetector boundaryDetector,
        IOptions<ProcessingSettings> processingSettings,
        ILogger<SignatureInjector> logger)
    {
        _ruleEvaluator = ruleEvaluator;
        _templateEngine = templateEngine;
        _boundaryDetector = boundaryDetector;
        _processingSettings = processingSettings.Value;
        _logger = logger;
    }

    /// <summary>
    /// Processes a MimeMessage: evaluates rules, injects signature if applicable.
    /// Modifies the message in place. Returns the processing result.
    /// </summary>
    public ProcessingResult Process(MimeMessage message, IReadOnlyList<string> envelopeTo)
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        var result = new ProcessingResult
        {
            MessageId = message.MessageId ?? string.Empty,
            ProcessedUtc = DateTimeOffset.UtcNow
        };

        try
        {
            // 1. Inspect message
            var senderEmail = message.From?.Mailboxes.FirstOrDefault()?.Address ?? string.Empty;
            var messageType = MessageInspector.DetectMessageType(message);
            var isEncrypted = MessageInspector.IsEncryptedOrSigned(message);
            var hasNoBody = MessageInspector.HasNoTextBody(message);
            var hasLoopHeader = message.Headers.Contains(_processingSettings.LoopPreventionHeader);

            result.DetectedMessageType = messageType;

            // 2. Build context and evaluate rules
            var ctx = new MessageContext
            {
                SenderEmail = senderEmail,
                RecipientEmails = envelopeTo,
                MessageType = messageType,
                IsEncrypted = isEncrypted,
                HasLoopHeader = hasLoopHeader,
                HasNoTextBody = hasNoBody
            };

            var rule = _ruleEvaluator.Evaluate(ctx);
            if (rule == null)
            {
                result.Outcome = ProcessingOutcome.NoMatchingRule;
                _logger.LogDebug("No rule matched for {MessageId} from {Sender}",
                    message.MessageId, senderEmail);
                sw.Stop();
                result.ProcessingMs = sw.Elapsed.TotalMilliseconds;
                return result;
            }

            result.MatchedRuleId = rule.Id;
            result.TemplateId = rule.TemplateId;

            // Check if explicitly skipped by skip conditions (already handled in rule eval,
            // but report it clearly)
            if (isEncrypted || hasLoopHeader || hasNoBody)
            {
                result.Outcome = ProcessingOutcome.Skipped;
                result.SkipReason = isEncrypted ? "Encrypted/Signed"
                    : hasLoopHeader ? "AlreadySigned"
                    : "NoTextBody";
                sw.Stop();
                result.ProcessingMs = sw.Elapsed.TotalMilliseconds;
                return result;
            }

            // 3. Resolve template
            var signature = _templateEngine.Resolve(rule.TemplateId, senderEmail);
            if (signature == null)
            {
                _logger.LogWarning("Template {TemplateId} not found for rule {RuleId}",
                    rule.TemplateId, rule.Id);
                result.Outcome = ProcessingOutcome.NoMatchingRule;
                result.SkipReason = "TemplateNotFound";
                sw.Stop();
                result.ProcessingMs = sw.Elapsed.TotalMilliseconds;
                return result;
            }

            // 4-5. Inject into body parts
            var modified = false;
            foreach (var part in message.BodyParts.OfType<MimeKit.TextPart>())
            {
                if (part.IsHtml && !string.IsNullOrEmpty(signature.Html))
                {
                    part.Text = InjectHtml(part.Text, signature.Html, rule.Placement);
                    modified = true;
                }
                else if (!part.IsHtml && !string.IsNullOrEmpty(signature.Text))
                {
                    part.Text = InjectPlainText(part.Text, signature.Text, rule.Placement);
                    modified = true;
                }
            }

            // 6. Stamp header
            if (modified)
            {
                message.Headers.Add(_processingSettings.LoopPreventionHeader, "true");
                result.Outcome = ProcessingOutcome.SignatureApplied;
                _logger.LogInformation(
                    "Signature applied to {MessageId} (rule={RuleId}, type={Type}, sender={Sender})",
                    message.MessageId, rule.Id, messageType, senderEmail);
            }
            else
            {
                result.Outcome = ProcessingOutcome.Skipped;
                result.SkipReason = "NoModifiableBodyParts";
            }
        }
        catch (Exception ex)
        {
            result.Outcome = ProcessingOutcome.ProcessingError;
            result.ErrorMessage = ex.Message;
            _logger.LogError(ex, "Error processing {MessageId}", message.MessageId);
        }

        sw.Stop();
        result.ProcessingMs = sw.Elapsed.TotalMilliseconds;
        return result;
    }

    // ========================================================================
    // HTML injection
    // ========================================================================

    private string InjectHtml(string html, string signatureHtml, SignaturePlacement placement)
    {
        // Wrap signature in a detectable container
        var wrapped = $"\n{SignatureWrapperStart}\n{signatureHtml}\n{SignatureWrapperEnd}\n";

        if (placement == SignaturePlacement.AfterBody)
        {
            return InsertBeforeBodyClose(html, wrapped);
        }

        if (placement == SignaturePlacement.BeforeBodyClose)
        {
            return InsertBeforeBodyClose(html, wrapped);
        }

        // Default: BeforeQuotedReply
        var boundary = _boundaryDetector.FindHtmlBoundary(html);
        if (boundary.Found)
        {
            return html.Insert(boundary.Index, wrapped);
        }

        // No reply boundary found — this is a fresh compose, insert before </body>
        return InsertBeforeBodyClose(html, wrapped);
    }

    private static string InsertBeforeBodyClose(string html, string content)
    {
        var bodyClose = html.IndexOf("</body>", StringComparison.OrdinalIgnoreCase);
        if (bodyClose >= 0)
        {
            return html.Insert(bodyClose, content);
        }

        // No </body> tag — just append
        return html + content;
    }

    // ========================================================================
    // Plain text injection
    // ========================================================================

    private string InjectPlainText(string text, string signatureText, SignaturePlacement placement)
    {
        if (placement == SignaturePlacement.AfterBody)
        {
            return text.TrimEnd() + "\n\n" + signatureText;
        }

        if (placement == SignaturePlacement.BeforeBodyClose)
        {
            return text.TrimEnd() + "\n\n" + signatureText;
        }

        // Default: BeforeQuotedReply
        var boundary = _boundaryDetector.FindPlainTextBoundary(text);
        if (boundary.Found)
        {
            return text[..boundary.Index].TrimEnd() + "\n\n" + signatureText + "\n\n" + text[boundary.Index..];
        }

        // No reply boundary — fresh compose, append
        return text.TrimEnd() + "\n\n" + signatureText;
    }
}
