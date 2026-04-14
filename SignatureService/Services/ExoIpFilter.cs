using System.Net;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SignatureService.Configuration;
using SmtpServer;
using SmtpServer.Mail;
using SmtpServer.Net;
using SmtpServer.Storage;

namespace SignatureService.Services;

/// <summary>
/// Mailbox filter that rejects connections from IP addresses not in the allowed
/// CIDR ranges. Designed to restrict access to Exchange Online outbound IPs only.
///
/// Implements IMailboxFilterFactory + IMailboxFilter — called on MAIL FROM command.
/// Blocked connections get a 550 permanent rejection.
/// </summary>
public class ExoIpFilter : IMailboxFilter, IMailboxFilterFactory
{
    private readonly List<(IPAddress Network, int PrefixLength)> _allowedRanges;
    private readonly ILogger<ExoIpFilter> _logger;
    private readonly bool _enabled;

    public ExoIpFilter(
        IOptions<SmtpSettings> settings,
        ILogger<ExoIpFilter> logger)
    {
        _logger = logger;
        _allowedRanges = new List<(IPAddress, int)>();

        var cidrs = settings.Value.AllowedClientCidrs;
        if (cidrs == null || cidrs.Count == 0)
        {
            _enabled = false;
            _logger.LogWarning("IP filtering DISABLED — no AllowedClientCidrs configured. " +
                "Any IP can connect to the SMTP listener.");
            return;
        }

        foreach (var cidr in cidrs)
        {
            if (TryParseCidr(cidr, out var network, out var prefix))
            {
                _allowedRanges.Add((network, prefix));
            }
            else
            {
                _logger.LogError("Invalid CIDR notation in AllowedClientCidrs: {Cidr}", cidr);
            }
        }

        _enabled = _allowedRanges.Count > 0;
        _logger.LogInformation("IP filter enabled with {Count} CIDR ranges", _allowedRanges.Count);
    }

    public IMailboxFilter CreateInstance(ISessionContext context) => this;

    public Task<bool> CanAcceptFromAsync(
        ISessionContext context, IMailbox from, int size, CancellationToken ct)
    {
        if (!_enabled)
            return Task.FromResult(true);

        var remoteIp = GetRemoteIp(context);
        if (remoteIp == null)
        {
            _logger.LogWarning("Cannot determine remote IP — allowing (fail-open)");
            return Task.FromResult(true);
        }

        if (IsAllowed(remoteIp))
        {
            return Task.FromResult(true);
        }

        _logger.LogWarning("REJECTED connection from {RemoteIp} — not in allowed EXO IP ranges",
            remoteIp);
        return Task.FromResult(false);
    }

    public Task<bool> CanDeliverToAsync(
        ISessionContext context, IMailbox to, IMailbox from, CancellationToken ct)
    {
        // Already validated on CanAcceptFrom — no need to re-check per recipient
        return Task.FromResult(true);
    }

    private bool IsAllowed(IPAddress clientIp)
    {
        // Map IPv4-mapped IPv6 addresses to IPv4 for comparison
        var ip = clientIp.IsIPv4MappedToIPv6 ? clientIp.MapToIPv4() : clientIp;

        foreach (var (network, prefixLength) in _allowedRanges)
        {
            if (IsInRange(ip, network, prefixLength))
                return true;
        }

        return false;
    }

    private static IPAddress? GetRemoteIp(ISessionContext context)
    {
        if (context.Properties.TryGetValue(EndpointListener.RemoteEndPointKey, out var ep)
            && ep is IPEndPoint ipEndPoint)
        {
            return ipEndPoint.Address;
        }

        return null;
    }

    /// <summary>
    /// Checks if an IP address falls within a CIDR range using bitwise comparison.
    /// </summary>
    private static bool IsInRange(IPAddress address, IPAddress network, int prefixLength)
    {
        var addressBytes = address.GetAddressBytes();
        var networkBytes = network.GetAddressBytes();

        if (addressBytes.Length != networkBytes.Length)
            return false;

        // Compare full bytes
        var fullBytes = prefixLength / 8;
        for (int i = 0; i < fullBytes && i < addressBytes.Length; i++)
        {
            if (addressBytes[i] != networkBytes[i])
                return false;
        }

        // Compare remaining bits
        var remainingBits = prefixLength % 8;
        if (remainingBits > 0 && fullBytes < addressBytes.Length)
        {
            var mask = (byte)(0xFF << (8 - remainingBits));
            if ((addressBytes[fullBytes] & mask) != (networkBytes[fullBytes] & mask))
                return false;
        }

        return true;
    }

    private static bool TryParseCidr(string cidr, out IPAddress network, out int prefixLength)
    {
        network = IPAddress.None;
        prefixLength = 0;

        var parts = cidr.Trim().Split('/');
        if (parts.Length != 2)
            return false;

        if (!IPAddress.TryParse(parts[0], out var addr))
            return false;

        if (!int.TryParse(parts[1], out var prefix))
            return false;

        var maxPrefix = addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork ? 32 : 128;
        if (prefix < 0 || prefix > maxPrefix)
            return false;

        network = addr;
        prefixLength = prefix;
        return true;
    }
}
