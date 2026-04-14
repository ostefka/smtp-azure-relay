using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SignatureService.Configuration;
using SignatureService.Domain;

namespace SignatureService.Engine;

/// <summary>
/// Resolves template placeholders using static sender identity data.
/// Designed as an interface so it can be swapped to Graph API later.
/// </summary>
public interface IIdentityResolver
{
    SenderIdentity Resolve(string senderEmail);
}

public class StaticIdentityResolver : IIdentityResolver
{
    private readonly Dictionary<string, SenderIdentity> _identities;
    private readonly SenderIdentity _defaultIdentity;

    public StaticIdentityResolver(IOptions<SignatureSettings> settings)
    {
        _defaultIdentity = settings.Value.DefaultIdentity;
        _identities = settings.Value.SenderIdentities
            .ToDictionary(s => s.Email.ToLowerInvariant(), s => s);
    }

    public SenderIdentity Resolve(string senderEmail)
    {
        var key = (senderEmail ?? string.Empty).ToLowerInvariant();
        return _identities.TryGetValue(key, out var identity)
            ? identity
            : _defaultIdentity;
    }
}
