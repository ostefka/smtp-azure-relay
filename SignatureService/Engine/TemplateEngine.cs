using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SignatureService.Configuration;
using SignatureService.Domain;

namespace SignatureService.Engine;

/// <summary>
/// Loads signature templates from config and/or disk.
/// Resolves placeholder variables against sender identity data.
/// </summary>
public class TemplateEngine
{
    private readonly Dictionary<string, SignatureTemplate> _templates = new();
    private readonly IIdentityResolver _identityResolver;
    private readonly ILogger<TemplateEngine> _logger;

    // Matches {{PropertyName}} placeholders
    private static readonly Regex PlaceholderRegex = new(
        @"\{\{(\w+)\}\}",
        RegexOptions.Compiled);

    public TemplateEngine(
        IOptions<SignatureSettings> settings,
        IIdentityResolver identityResolver,
        ILogger<TemplateEngine> logger)
    {
        _identityResolver = identityResolver;
        _logger = logger;
        LoadTemplates(settings.Value);
    }

    private void LoadTemplates(SignatureSettings settings)
    {
        // Load inline templates from config
        foreach (var template in settings.Templates)
        {
            _templates[template.Id] = template;
            _logger.LogInformation("Loaded inline template: {Id}", template.Id);
        }

        // Load file-based templates
        var basePath = Path.IsPathRooted(settings.TemplatesPath)
            ? settings.TemplatesPath
            : Path.Combine(AppContext.BaseDirectory, settings.TemplatesPath);

        if (!Directory.Exists(basePath))
        {
            _logger.LogWarning("Templates directory not found: {Path}", basePath);
            return;
        }

        // Each template is a pair: {id}.html + {id}.txt
        var htmlFiles = Directory.GetFiles(basePath, "*.html");
        foreach (var htmlPath in htmlFiles)
        {
            var id = Path.GetFileNameWithoutExtension(htmlPath);
            if (_templates.ContainsKey(id))
            {
                _logger.LogDebug("Skipping file template {Id} — already defined inline", id);
                continue;
            }

            var textPath = Path.ChangeExtension(htmlPath, ".txt");
            var template = new SignatureTemplate
            {
                Id = id,
                Name = id,
                HtmlBody = File.ReadAllText(htmlPath),
                TextBody = File.Exists(textPath) ? File.ReadAllText(textPath) : string.Empty
            };

            _templates[id] = template;
            _logger.LogInformation("Loaded file template: {Id} from {Path}", id, htmlPath);
        }

        _logger.LogInformation("Total templates loaded: {Count}", _templates.Count);
    }

    /// <summary>
    /// Resolves a template for a specific sender, substituting all placeholders.
    /// </summary>
    public ResolvedSignature? Resolve(string templateId, string senderEmail)
    {
        if (!_templates.TryGetValue(templateId, out var template))
        {
            _logger.LogWarning("Template not found: {Id}", templateId);
            return null;
        }

        var identity = _identityResolver.Resolve(senderEmail);
        var replacements = BuildReplacements(identity, senderEmail);

        var html = ResolvePlaceholders(template.HtmlBody, replacements);
        var text = ResolvePlaceholders(template.TextBody, replacements);

        return new ResolvedSignature(html, text);
    }

    private Dictionary<string, string> BuildReplacements(SenderIdentity identity, string senderEmail)
    {
        var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["DisplayName"] = identity.DisplayName,
            ["Title"] = identity.Title,
            ["Department"] = identity.Department,
            ["Phone"] = identity.Phone,
            ["Mobile"] = identity.Mobile,
            ["Company"] = identity.Company,
            ["Website"] = identity.Website,
            ["Email"] = string.IsNullOrEmpty(identity.Email) ? senderEmail : identity.Email,
        };

        // Merge custom properties (override built-ins if same key)
        foreach (var kvp in identity.CustomProperties)
        {
            dict[kvp.Key] = kvp.Value;
        }

        return dict;
    }

    private static string ResolvePlaceholders(string template, Dictionary<string, string> replacements)
    {
        if (string.IsNullOrEmpty(template)) return template;

        return PlaceholderRegex.Replace(template, match =>
        {
            var key = match.Groups[1].Value;
            return replacements.TryGetValue(key, out var value) ? value : match.Value;
        });
    }
}

public record ResolvedSignature(string Html, string Text);
