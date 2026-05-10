using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using SignatureAnalyzer.Models;

namespace SignatureAnalyzer.Analysis;

/// <summary>
/// Generates analysis reports in both JSON and human-readable Markdown format.
/// </summary>
public static class ReportGenerator
{
    public static AnalysisReport BuildReport(
        MailboxScanner scanner,
        InjectionDryRun dryRun,
        string mailbox,
        string[] folders,
        TimeSpan duration)
    {
        var patterns = scanner.GetPatterns().Values.ToList();
        var total = scanner.ScannedCount;

        // Run injection dry-run on each specimen
        foreach (var pattern in patterns)
        {
            if (File.Exists(pattern.SpecimenPath))
            {
                pattern.InjectionResult = dryRun.Test(pattern.SpecimenPath);
            }
        }

        // Compute percentages
        foreach (var p in patterns)
            p.OccurrencePercent = total > 0 ? (double)p.OccurrenceCount / total * 100 : 0;

        // Sort by occurrence
        patterns = patterns.OrderByDescending(p => p.OccurrenceCount).ToList();

        var report = new AnalysisReport
        {
            TargetMailbox = mailbox,
            FoldersScanned = folders,
            TotalMessagesScanned = total,
            UniquePatterns = patterns.Count,
            SpecimensSaved = patterns.Count,
            SkippedDuplicates = scanner.SkippedDuplicates,
            SkippedEncrypted = scanner.SkippedEncrypted,
            ScanDuration = duration,
            Patterns = patterns,
            InjectionPass = patterns.Count(p => p.InjectionResult?.Success == true),
            InjectionFail = patterns.Count(p => p.InjectionResult?.Success == false),
            FailedPatterns = patterns.Where(p => p.InjectionResult?.Success == false).ToList(),
            UndetectedBoundaryPatterns = patterns
                .Where(p => p.Fingerprint.MessageType != "New"
                    && p.Fingerprint.ReplyBoundaryPattern == "none")
                .ToList(),
        };

        // Distributions
        report.ClientFamilyDistribution = patterns
            .GroupBy(p => p.Fingerprint.ClientFamily)
            .ToDictionary(g => g.Key, g => g.Sum(p => p.OccurrenceCount));

        report.MessageTypeDistribution = patterns
            .GroupBy(p => p.Fingerprint.MessageType)
            .ToDictionary(g => g.Key, g => g.Sum(p => p.OccurrenceCount));

        report.BoundaryPatternDistribution = patterns
            .Where(p => p.Fingerprint.ReplyBoundaryPattern != "none")
            .GroupBy(p => p.Fingerprint.ReplyBoundaryPattern)
            .ToDictionary(g => g.Key, g => g.Sum(p => p.OccurrenceCount));

        report.MimeStructureDistribution = patterns
            .GroupBy(p => p.Fingerprint.MimeTreeShape)
            .ToDictionary(g => g.Key, g => g.Sum(p => p.OccurrenceCount));

        return report;
    }

    public static void SaveJson(AnalysisReport report, string path)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        var json = JsonSerializer.Serialize(report, options);
        File.WriteAllText(path, json);
    }

    public static void SaveMarkdown(AnalysisReport report, string path)
    {
        var sb = new StringBuilder();

        sb.AppendLine("# Signature Injection Analysis Report");
        sb.AppendLine();
        sb.AppendLine($"**Generated:** {report.GeneratedAt:yyyy-MM-dd HH:mm:ss} UTC  ");
        sb.AppendLine($"**Mailbox:** {report.TargetMailbox}  ");
        sb.AppendLine($"**Folders:** {string.Join(", ", report.FoldersScanned)}  ");
        sb.AppendLine($"**Duration:** {report.ScanDuration:hh\\:mm\\:ss}  ");
        sb.AppendLine();

        // Summary
        sb.AppendLine("## Summary");
        sb.AppendLine();
        sb.AppendLine($"| Metric | Value |");
        sb.AppendLine($"|--------|-------|");
        sb.AppendLine($"| Messages scanned | {report.TotalMessagesScanned:N0} |");
        sb.AppendLine($"| Unique patterns | {report.UniquePatterns} |");
        sb.AppendLine($"| Duplicates skipped | {report.SkippedDuplicates:N0} |");
        sb.AppendLine($"| Encrypted (skipped) | {report.SkippedEncrypted} |");
        sb.AppendLine($"| Injection PASS | {report.InjectionPass} |");
        sb.AppendLine($"| Injection FAIL | {report.InjectionFail} |");
        sb.AppendLine($"| **Pass rate** | **{report.InjectionPassRate:F1}%** |");
        sb.AppendLine();

        // Client distribution
        sb.AppendLine("## Email Client Distribution");
        sb.AppendLine();
        sb.AppendLine("| Client | Messages | % |");
        sb.AppendLine("|--------|----------|---|");
        foreach (var (client, count) in report.ClientFamilyDistribution.OrderByDescending(kv => kv.Value))
        {
            var pct = report.TotalMessagesScanned > 0 ? (double)count / report.TotalMessagesScanned * 100 : 0;
            sb.AppendLine($"| {client} | {count:N0} | {pct:F1}% |");
        }
        sb.AppendLine();

        // Message type distribution
        sb.AppendLine("## Message Type Distribution");
        sb.AppendLine();
        sb.AppendLine("| Type | Messages | % |");
        sb.AppendLine("|------|----------|---|");
        foreach (var (type, count) in report.MessageTypeDistribution.OrderByDescending(kv => kv.Value))
        {
            var pct = report.TotalMessagesScanned > 0 ? (double)count / report.TotalMessagesScanned * 100 : 0;
            sb.AppendLine($"| {type} | {count:N0} | {pct:F1}% |");
        }
        sb.AppendLine();

        // Boundary patterns
        sb.AppendLine("## Reply Boundary Patterns Detected");
        sb.AppendLine();
        sb.AppendLine("| Pattern | Messages | % |");
        sb.AppendLine("|---------|----------|---|");
        foreach (var (pattern, count) in report.BoundaryPatternDistribution.OrderByDescending(kv => kv.Value))
        {
            var pct = report.TotalMessagesScanned > 0 ? (double)count / report.TotalMessagesScanned * 100 : 0;
            sb.AppendLine($"| {pattern} | {count:N0} | {pct:F1}% |");
        }
        sb.AppendLine();

        // MIME structures
        sb.AppendLine("## MIME Structure Distribution");
        sb.AppendLine();
        sb.AppendLine("| Structure | Patterns | Messages |");
        sb.AppendLine("|-----------|----------|----------|");
        foreach (var (structure, count) in report.MimeStructureDistribution.OrderByDescending(kv => kv.Value))
        {
            var patternCount = report.Patterns.Count(p => p.Fingerprint.MimeTreeShape == structure);
            sb.AppendLine($"| `{structure}` | {patternCount} | {count:N0} |");
        }
        sb.AppendLine();

        // Failed patterns
        if (report.FailedPatterns.Count > 0)
        {
            sb.AppendLine("## ❌ FAILED Injection Patterns");
            sb.AppendLine();
            sb.AppendLine("These patterns need fixes in the signature engine:");
            sb.AppendLine();
            foreach (var p in report.FailedPatterns)
            {
                sb.AppendLine($"### Pattern #{p.PatternId} — {p.Fingerprint.ClientFamily} / {p.Fingerprint.MessageType}");
                sb.AppendLine();
                sb.AppendLine($"- **Occurrences:** {p.OccurrenceCount:N0} ({p.OccurrencePercent:F1}%)");
                sb.AppendLine($"- **MIME:** `{p.Fingerprint.MimeTreeShape}`");
                sb.AppendLine($"- **Boundary:** {p.Fingerprint.ReplyBoundaryPattern}");
                sb.AppendLine($"- **Error:** {p.InjectionResult?.ErrorMessage ?? p.InjectionResult?.Outcome}");
                sb.AppendLine($"- **Specimen:** `{Path.GetFileName(p.SpecimenPath)}`");
                sb.AppendLine();
            }
        }

        // Undetected boundaries
        if (report.UndetectedBoundaryPatterns.Count > 0)
        {
            sb.AppendLine("## ⚠️ Reply/Forward WITHOUT Detected Boundary");
            sb.AppendLine();
            sb.AppendLine("These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:");
            sb.AppendLine();
            foreach (var p in report.UndetectedBoundaryPatterns)
            {
                sb.AppendLine($"- **Pattern #{p.PatternId}** — {p.Fingerprint.ClientFamily} / {p.Fingerprint.MessageType} " +
                    $"({p.OccurrenceCount:N0} msgs, {p.OccurrencePercent:F1}%) — `{Path.GetFileName(p.SpecimenPath)}`");
            }
            sb.AppendLine();
        }

        // All patterns table
        sb.AppendLine("## All Patterns");
        sb.AppendLine();
        sb.AppendLine("| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |");
        sb.AppendLine("|---|--------|------|------|----------|-----|------|---|--------|----------|");
        foreach (var p in report.Patterns)
        {
            var inject = p.InjectionResult?.Success == true ? "PASS" : "FAIL";
            var sig = p.Fingerprint.HasExistingSignature ? p.Fingerprint.ExistingSignaturePattern : "-";
            sb.AppendLine($"| {p.PatternId} | {p.Fingerprint.ClientFamily} | {p.Fingerprint.MessageType} " +
                $"| `{TruncateMime(p.Fingerprint.MimeTreeShape)}` | {p.Fingerprint.ReplyBoundaryPattern} " +
                $"| {sig} | {p.OccurrenceCount:N0} | {p.OccurrencePercent:F1}% " +
                $"| {inject} | `{Path.GetFileName(p.SpecimenPath)}` |");
        }

        File.WriteAllText(path, sb.ToString());
    }

    private static string TruncateMime(string mime)
    {
        return mime.Length > 60 ? mime[..57] + "..." : mime;
    }
}
