namespace SignatureAnalyzer.Models;

/// <summary>
/// Overall analysis report — the final output of the analyzer.
/// </summary>
public class AnalysisReport
{
    public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;
    public string TargetMailbox { get; set; } = "";
    public string[] FoldersScanned { get; set; } = [];

    // Scan statistics
    public int TotalMessagesScanned { get; set; }
    public int UniquePatterns { get; set; }
    public int SpecimensSaved { get; set; }
    public int SkippedDuplicates { get; set; }
    public int SkippedEncrypted { get; set; }
    public TimeSpan ScanDuration { get; set; }

    // Injection results
    public int InjectionPass { get; set; }
    public int InjectionFail { get; set; }
    public double InjectionPassRate => UniquePatterns > 0
        ? (double)InjectionPass / UniquePatterns * 100 : 0;

    // Client breakdown
    public Dictionary<string, int> ClientFamilyDistribution { get; set; } = new();
    public Dictionary<string, int> MessageTypeDistribution { get; set; } = new();
    public Dictionary<string, int> BoundaryPatternDistribution { get; set; } = new();
    public Dictionary<string, int> MimeStructureDistribution { get; set; } = new();

    // Patterns
    public List<PatternRecord> Patterns { get; set; } = new();

    // Issues
    public List<PatternRecord> FailedPatterns { get; set; } = new();
    public List<PatternRecord> UndetectedBoundaryPatterns { get; set; } = new();
}
