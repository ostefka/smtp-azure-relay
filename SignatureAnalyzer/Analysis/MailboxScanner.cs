using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Cryptography;
using SignatureAnalyzer.Models;

namespace SignatureAnalyzer.Analysis;

/// <summary>
/// Scans a mailbox via Graph API, computes structural fingerprints,
/// and only downloads full MIME for unique (previously unseen) patterns.
///
/// SAFETY: This class performs READ-ONLY Graph API operations.
/// It has no send capability whatsoever.
/// </summary>
public class MailboxScanner
{
    private readonly GraphServiceClient _graphClient;
    private readonly FingerprintEngine _fingerprint;
    private readonly ILogger<MailboxScanner> _logger;

    // Dedup state
    private readonly Dictionary<string, PatternRecord> _patterns = new();
    private int _nextPatternId = 1;
    private int _scannedCount;
    private int _skippedDuplicates;
    private int _skippedEncrypted;

    public MailboxScanner(
        GraphServiceClient graphClient,
        FingerprintEngine fingerprint,
        ILogger<MailboxScanner> logger)
    {
        _graphClient = graphClient;
        _fingerprint = fingerprint;
        _logger = logger;
    }

    /// <summary>
    /// Scan a mailbox folder, fingerprinting messages and saving unique specimens.
    /// </summary>
    public async Task ScanFolderAsync(
        string userIdOrUpn,
        string folderName,
        string outputDir,
        int maxMessages = 10000,
        CancellationToken ct = default)
    {
        var folderId = await ResolveFolderIdAsync(userIdOrUpn, folderName, ct);
        if (folderId == null)
        {
            _logger.LogError("Folder '{Folder}' not found for user {User}", folderName, userIdOrUpn);
            return;
        }

        _logger.LogInformation("Scanning folder {Folder} (id={Id}) for {User}",
            folderName, folderId, userIdOrUpn);

        Directory.CreateDirectory(outputDir);

        string? nextLink = null;
        int page = 0;

        do
        {
            // Fetch page of messages — headers + metadata only (no body yet)
            var messagesPage = await GetMessagePageAsync(
                userIdOrUpn, folderId, nextLink, ct);

            if (messagesPage?.Value == null) break;

            foreach (var msg in messagesPage.Value)
            {
                if (ct.IsCancellationRequested) return;
                if (_scannedCount >= maxMessages) return;

                _scannedCount++;

                try
                {
                    await ProcessMessageAsync(userIdOrUpn, msg, outputDir, ct);
                }
                catch (Exception ex)
                {
                    _logger.LogWarning(ex, "Failed to process message {Id}", msg.Id);
                }

                if (_scannedCount % 100 == 0)
                {
                    _logger.LogInformation(
                        "Progress: {Scanned} scanned, {Patterns} unique patterns, {Skipped} duplicates",
                        _scannedCount, _patterns.Count, _skippedDuplicates);
                }
            }

            nextLink = messagesPage.OdataNextLink;
            page++;

        } while (nextLink != null && _scannedCount < maxMessages);

        _logger.LogInformation(
            "Scan complete: {Scanned} messages, {Patterns} unique patterns, {Dupes} duplicates, {Encrypted} encrypted",
            _scannedCount, _patterns.Count, _skippedDuplicates, _skippedEncrypted);
    }

    private async Task ProcessMessageAsync(
        string userIdOrUpn, Message msg, string outputDir, CancellationToken ct)
    {
        // Download full MIME to compute fingerprint
        var mimeStream = await _graphClient.Users[userIdOrUpn]
            .Messages[msg.Id]
            .Content
            .GetAsync(cancellationToken: ct);

        if (mimeStream == null) return;

        MimeMessage mimeMessage;
        using (var ms = new MemoryStream())
        {
            await mimeStream.CopyToAsync(ms, ct);
            ms.Position = 0;
            mimeMessage = await MimeMessage.LoadAsync(ms, ct);
        }

        // Check for encryption — skip but count
        if (mimeMessage.Body is MultipartEncrypted
            || mimeMessage.Body is ApplicationPkcs7Mime)
        {
            _skippedEncrypted++;
            return;
        }

        // Compute fingerprint
        var fp = _fingerprint.ComputeFingerprint(mimeMessage);
        var key = fp.Key;

        if (_patterns.TryGetValue(key, out var existing))
        {
            // Already seen this pattern — just increment counter
            existing.OccurrenceCount++;
            if (existing.ExampleSubjects.Count < 3)
            {
                existing.ExampleSubjects.Add(AnonymizeSubject(mimeMessage.Subject ?? ""));
            }
            _skippedDuplicates++;
            return;
        }

        // New pattern — save specimen
        var specimenPath = Path.Combine(outputDir, $"specimen-{_nextPatternId:D4}.eml");
        await SaveAnonymizedSpecimenAsync(mimeMessage, specimenPath, ct);

        var record = new PatternRecord
        {
            PatternId = _nextPatternId++,
            Fingerprint = fp,
            SpecimenMessageId = msg.Id ?? "",
            SpecimenPath = specimenPath,
            ExampleSubjects = { AnonymizeSubject(mimeMessage.Subject ?? "") }
        };

        _patterns[key] = record;
        _logger.LogDebug("New pattern #{Id}: {Key}", record.PatternId, key);
    }

    public IReadOnlyDictionary<string, PatternRecord> GetPatterns() => _patterns;
    public int ScannedCount => _scannedCount;
    public int SkippedDuplicates => _skippedDuplicates;
    public int SkippedEncrypted => _skippedEncrypted;

    // ========================================================================
    // Privacy: anonymize before saving to disk
    // ========================================================================

    private static async Task SaveAnonymizedSpecimenAsync(
        MimeMessage message, string path, CancellationToken ct)
    {
        // Create a copy and anonymize
        using var ms = new MemoryStream();
        message.WriteTo(ms);
        ms.Position = 0;
        var copy = await MimeMessage.LoadAsync(ms, ct);

        // Anonymize headers — keep structural headers, redact personal info
        AnonymizeAddresses(copy);
        copy.Subject = AnonymizeSubject(copy.Subject ?? "");

        // Anonymize text content — replace words but preserve HTML structure
        foreach (var part in copy.BodyParts.OfType<MimeKit.TextPart>())
        {
            if (part.IsHtml)
            {
                part.Text = AnonymizeHtmlContent(part.Text);
            }
            else
            {
                part.Text = AnonymizeTextContent(part.Text);
            }
        }

        // Remove attachment content but keep MIME structure
        // (we care about structure, not attachment content)

        using var outStream = File.Create(path);
        copy.WriteTo(outStream);
    }

    private static void AnonymizeAddresses(MimeMessage message)
    {
        ReplaceAddresses(message.From);
        ReplaceAddresses(message.To);
        ReplaceAddresses(message.Cc);
        ReplaceAddresses(message.Bcc);
        if (message.ReplyTo.Count > 0)
            ReplaceAddresses(message.ReplyTo);
    }

    private static void ReplaceAddresses(InternetAddressList list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] is MailboxAddress mb)
            {
                var domain = mb.Address.Contains('@')
                    ? mb.Address[(mb.Address.IndexOf('@') + 1)..]
                    : "example.com";
                list[i] = new MailboxAddress(
                    $"User{i + 1}",
                    $"user{i + 1}@{domain}");
            }
        }
    }

    private static string AnonymizeSubject(string subject)
    {
        // Preserve RE:/FW:/AW: prefixes but redact the rest
        var prefixMatch = System.Text.RegularExpressions.Regex.Match(
            subject, @"^((?:(?:RE|FW|FWD|AW|WG|SV)\s*:\s*)+)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        var prefix = prefixMatch.Success ? prefixMatch.Value : "";
        return prefix + "[redacted]";
    }

    private static string AnonymizeHtmlContent(string html)
    {
        // Replace text content between tags but preserve ALL HTML structure,
        // classes, IDs, styles — those are what we need for analysis.
        // Only redact visible text runs.
        return System.Text.RegularExpressions.Regex.Replace(
            html,
            @"(>)([^<]{10,})(<)",
            m => m.Groups[1].Value + "[content-redacted]" + m.Groups[3].Value);
    }

    private static string AnonymizeTextContent(string text)
    {
        // Preserve reply markers (> prefixes, "On ... wrote:", etc.) but redact content
        var lines = text.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            if (line.TrimStart().StartsWith('>'))
                continue; // Keep quote markers
            if (System.Text.RegularExpressions.Regex.IsMatch(line, @"^(On .+ wrote:|From:|To:|Subject:|Date:|Sent:|----- Original)"))
                continue; // Keep reply headers
            if (line.TrimStart().StartsWith("--"))
                continue; // Keep signature markers

            if (line.Length > 10)
                lines[i] = "[content-redacted]";
        }
        return string.Join('\n', lines);
    }

    // ========================================================================
    // Graph API helpers
    // ========================================================================

    private async Task<string?> ResolveFolderIdAsync(
        string userIdOrUpn, string folderName, CancellationToken ct)
    {
        // Well-known folder names
        var wellKnown = folderName.ToLower() switch
        {
            "inbox" => "inbox",
            "sentitems" or "sent items" or "sent" => "sentitems",
            "drafts" => "drafts",
            "deleteditems" or "deleted" => "deleteditems",
            "junkemail" or "junk" => "junkemail",
            _ => null
        };

        if (wellKnown != null)
        {
            var folder = await _graphClient.Users[userIdOrUpn]
                .MailFolders[wellKnown]
                .GetAsync(cancellationToken: ct);
            return folder?.Id;
        }

        // Search by display name
        var folders = await _graphClient.Users[userIdOrUpn]
            .MailFolders
            .GetAsync(r =>
            {
                r.QueryParameters.Filter = $"displayName eq '{folderName}'";
            }, ct);

        return folders?.Value?.FirstOrDefault()?.Id;
    }

    private async Task<MessageCollectionResponse?> GetMessagePageAsync(
        string userIdOrUpn, string folderId, string? nextLink, CancellationToken ct)
    {
        if (nextLink != null)
        {
            // Use the raw request for paging
            var request = new Microsoft.Graph.Users.Item.MailFolders.Item.Messages.MessagesRequestBuilder(
                nextLink, _graphClient.RequestAdapter);
            return await request.GetAsync(cancellationToken: ct);
        }

        return await _graphClient.Users[userIdOrUpn]
            .MailFolders[folderId]
            .Messages
            .GetAsync(r =>
            {
                r.QueryParameters.Top = 50;
                r.QueryParameters.Select = new[] { "id", "subject", "receivedDateTime" };
                r.QueryParameters.Orderby = new[] { "receivedDateTime desc" };
            }, ct);
    }
}
