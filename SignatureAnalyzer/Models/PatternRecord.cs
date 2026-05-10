namespace SignatureAnalyzer.Models;

/// <summary>
/// Represents a unique structural pattern found in the corpus with
/// occurrence statistics and injection test results.
/// </summary>
public class PatternRecord
{
    public int PatternId { get; set; }
    public MessageFingerprint Fingerprint { get; set; } = new();

    /// <summary>How many messages in the corpus matched this fingerprint.</summary>
    public int OccurrenceCount { get; set; } = 1;

    /// <summary>Percentage of total scanned messages.</summary>
    public double OccurrencePercent { get; set; }

    /// <summary>Graph message ID of the first specimen (for re-fetching).</summary>
    public string SpecimenMessageId { get; set; } = "";

    /// <summary>Local path to saved specimen .eml file.</summary>
    public string SpecimenPath { get; set; } = "";

    /// <summary>Injection dry-run result.</summary>
    public InjectionResult? InjectionResult { get; set; }

    /// <summary>Example subjects (first 3, anonymized).</summary>
    public List<string> ExampleSubjects { get; set; } = new();
}

/// <summary>
/// Result of running the specimen through the SignatureInjector without sending.
/// </summary>
public class InjectionResult
{
    public bool Success { get; set; }
    public string Outcome { get; set; } = ""; // SignatureApplied, NoMatch, Error
    public string? DetectedBoundary { get; set; }
    public string? InjectionPoint { get; set; } // "before-boundary", "end-of-body", etc.
    public bool OutputMimeValid { get; set; }
    public bool OutputHtmlWellFormed { get; set; }
    public bool TextPartUpdated { get; set; }
    public bool EncodingPreserved { get; set; }
    public string? ErrorMessage { get; set; }
    public long ProcessingTimeMs { get; set; }

    /// <summary>Size delta between input and output HTML (signature bytes added).</summary>
    public int HtmlSizeDelta { get; set; }
}
