using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SmtpSignatureProxy.Configuration;

namespace SmtpSignatureProxy.Services;

/// <summary>
/// Loads signature templates from disk and injects them into MIME messages.
/// Handles HTML, plain-text, and multipart/alternative bodies.
/// </summary>
public class SignatureEngine
{
    private readonly SignatureSettings _settings;
    private readonly ILogger<SignatureEngine> _logger;
    private string? _htmlSignature;
    private string? _textSignature;

    public SignatureEngine(
        IOptions<SignatureSettings> settings,
        ILogger<SignatureEngine> logger)
    {
        _settings = settings.Value;
        _logger = logger;
        LoadTemplates();
    }

    private void LoadTemplates()
    {
        var basePath = Path.IsPathRooted(_settings.TemplatesPath)
            ? _settings.TemplatesPath
            : Path.Combine(AppContext.BaseDirectory, _settings.TemplatesPath);

        var htmlPath = Path.Combine(basePath, $"{_settings.DefaultTemplate}.html");
        var textPath = Path.Combine(basePath, $"{_settings.DefaultTemplate}.txt");

        if (File.Exists(htmlPath))
        {
            _htmlSignature = File.ReadAllText(htmlPath);
            _logger.LogInformation("Loaded HTML signature template: {Path}", htmlPath);
        }
        else
        {
            _logger.LogWarning("HTML signature template not found: {Path}", htmlPath);
        }

        if (File.Exists(textPath))
        {
            _textSignature = File.ReadAllText(textPath);
            _logger.LogInformation("Loaded text signature template: {Path}", textPath);
        }
        else
        {
            _logger.LogWarning("Text signature template not found: {Path}", textPath);
        }
    }

    /// <summary>
    /// Returns true if the message already has the loop-prevention header.
    /// </summary>
    public bool IsAlreadySigned(MimeMessage message)
    {
        return _settings.SkipIfAlreadySigned
            && message.Headers.Contains(_settings.LoopPreventionHeader);
    }

    /// <summary>
    /// Injects the signature into the message body and stamps the loop header.
    /// Modifies the message in place.
    /// </summary>
    public void ApplySignature(MimeMessage message)
    {
        if (_htmlSignature == null && _textSignature == null)
        {
            _logger.LogWarning("No signature templates loaded, skipping");
            return;
        }

        var modified = false;

        // Walk all body parts — handles multipart/alternative (HTML + text) correctly
        foreach (var part in message.BodyParts.OfType<TextPart>())
        {
            if (part.IsHtml && _htmlSignature != null)
            {
                part.Text = InjectHtml(part.Text, _htmlSignature);
                modified = true;
            }
            else if (!part.IsHtml && _textSignature != null)
            {
                part.Text = InjectPlainText(part.Text, _textSignature);
                modified = true;
            }
        }

        if (modified)
        {
            message.Headers.Add(_settings.LoopPreventionHeader, "true");
            _logger.LogDebug("Signature applied to message {MessageId}", message.MessageId);
        }
        else
        {
            _logger.LogDebug("No suitable body parts found for signature in {MessageId}", message.MessageId);
        }
    }

    private string InjectHtml(string html, string signature)
    {
        // Try custom marker first
        var marker = _settings.HtmlInsertMarker;
        if (!string.IsNullOrEmpty(marker))
        {
            var markerIndex = html.IndexOf(marker, StringComparison.OrdinalIgnoreCase);
            if (markerIndex >= 0)
            {
                return html.Insert(markerIndex, signature);
            }
        }

        // Fall back to before </body>
        var bodyClose = html.IndexOf("</body>", StringComparison.OrdinalIgnoreCase);
        if (bodyClose >= 0)
        {
            return html.Insert(bodyClose, signature);
        }

        // No structure — just append
        return html + signature;
    }

    private static string InjectPlainText(string text, string signature)
    {
        return text.TrimEnd() + "\n\n" + signature;
    }
}
