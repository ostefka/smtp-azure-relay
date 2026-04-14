using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SignatureService.Configuration;
using SignatureService.Domain;

namespace SignatureService.Engine;

/// <summary>
/// Evaluates signature rules against a message context.
/// Rules are evaluated in Priority order; first match wins.
/// </summary>
public class RuleEvaluator
{
    private readonly List<SignatureRule> _rules;
    private readonly List<string> _internalDomains;
    private readonly string _loopHeader;
    private readonly ILogger<RuleEvaluator> _logger;

    public RuleEvaluator(
        IOptions<SignatureSettings> sigSettings,
        IOptions<ProcessingSettings> procSettings,
        ILogger<RuleEvaluator> logger)
    {
        _rules = sigSettings.Value.Rules
            .Where(r => r.Enabled)
            .OrderBy(r => r.Priority)
            .ToList();

        _internalDomains = procSettings.Value.InternalDomains
            .Select(d => d.ToLowerInvariant())
            .ToList();

        _loopHeader = procSettings.Value.LoopPreventionHeader;
        _logger = logger;

        _logger.LogInformation("Rule evaluator loaded {Count} active rules", _rules.Count);
    }

    /// <summary>
    /// Evaluates all rules against the message context. Returns the first matching rule, or null.
    /// </summary>
    public SignatureRule? Evaluate(MessageContext ctx)
    {
        foreach (var rule in _rules)
        {
            if (Matches(rule, ctx))
            {
                _logger.LogDebug("Rule {RuleId} '{RuleName}' matched for {Sender}",
                    rule.Id, rule.Name, ctx.SenderEmail);
                return rule;
            }
        }

        _logger.LogDebug("No rule matched for {Sender}", ctx.SenderEmail);
        return null;
    }

    private bool Matches(SignatureRule rule, MessageContext ctx)
    {
        var cond = rule.Conditions;

        // Check skip conditions first
        if (cond.Skip.SkipEncrypted && ctx.IsEncrypted) return false;
        if (cond.Skip.SkipAlreadySigned && ctx.HasLoopHeader) return false;
        if (cond.Skip.SkipNoBody && ctx.HasNoTextBody) return false;

        // Sender match
        if (cond.SenderPatterns.Count > 0)
        {
            if (!cond.SenderPatterns.Any(p => MatchesSenderPattern(p, ctx.SenderEmail)))
                return false;
        }

        // Message type match
        if (cond.MessageTypes.Count > 0)
        {
            if (!cond.MessageTypes.Contains(ctx.MessageType))
                return false;
        }

        // Recipient scope match
        if (!MatchesRecipientScope(cond.RecipientScope, cond.InternalDomains, ctx))
            return false;

        return true;
    }

    private static bool MatchesSenderPattern(string pattern, string senderEmail)
    {
        if (string.IsNullOrEmpty(senderEmail)) return false;
        var sender = senderEmail.ToLowerInvariant();
        var pat = pattern.ToLowerInvariant();

        if (pat == "*") return true;
        if (!pat.Contains('*')) return sender == pat;

        // *@domain.com
        if (pat.StartsWith('*'))
        {
            var suffix = pat[1..]; // @domain.com
            return sender.EndsWith(suffix, StringComparison.OrdinalIgnoreCase);
        }

        // user@*.domain.com — convert to simple ends-with on the domain part
        var parts = pat.Split('@', 2);
        if (parts.Length == 2 && parts[1].StartsWith("*."))
        {
            var domainSuffix = parts[1][1..]; // .domain.com
            var senderParts = sender.Split('@', 2);
            if (senderParts.Length != 2) return false;
            return (parts[0] == "*" || senderParts[0] == parts[0])
                && senderParts[1].EndsWith(domainSuffix, StringComparison.OrdinalIgnoreCase);
        }

        return false;
    }

    private bool MatchesRecipientScope(
        RecipientScope scope,
        List<string> ruleInternalDomains,
        MessageContext ctx)
    {
        if (scope == RecipientScope.All) return true;

        var domains = ruleInternalDomains.Count > 0
            ? ruleInternalDomains.Select(d => d.ToLowerInvariant()).ToList()
            : _internalDomains;

        bool IsInternal(string email)
        {
            var atIdx = email.LastIndexOf('@');
            if (atIdx < 0) return false;
            var domain = email[(atIdx + 1)..].ToLowerInvariant();
            return domains.Contains(domain);
        }

        var allInternal = ctx.RecipientEmails.All(IsInternal);
        var anyExternal = ctx.RecipientEmails.Any(r => !IsInternal(r));

        return scope switch
        {
            RecipientScope.ExternalOnly => !allInternal && ctx.RecipientEmails.All(r => !IsInternal(r)),
            RecipientScope.InternalOnly => allInternal,
            RecipientScope.AnyExternal => anyExternal,
            _ => true
        };
    }
}

/// <summary>
/// Pre-computed message properties passed to rule evaluation.
/// Avoids re-inspecting the MimeMessage on each rule check.
/// </summary>
public class MessageContext
{
    public string SenderEmail { get; init; } = string.Empty;
    public IReadOnlyList<string> RecipientEmails { get; init; } = Array.Empty<string>();
    public MessageType MessageType { get; init; }
    public bool IsEncrypted { get; init; }
    public bool HasLoopHeader { get; init; }
    public bool HasNoTextBody { get; init; }
}
