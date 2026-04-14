using SignatureService.Domain;

namespace SignatureService.Configuration;

public class SmtpSettings
{
    public int Port { get; set; } = 25;
    public string ServerName { get; set; } = "signature-service";
    public int MaxMessageSizeKb { get; set; } = 35840; // 35 MB

    /// <summary>Path to PFX certificate for STARTTLS. Empty = no TLS.</summary>
    public string TlsCertificatePath { get; set; } = string.Empty;

    /// <summary>Password for the PFX certificate file.</summary>
    public string TlsCertificatePassword { get; set; } = string.Empty;

    /// <summary>
    /// CIDR ranges allowed to connect. Empty = allow all (DANGEROUS).
    /// EXO outbound IPs: 40.92.0.0/15, 40.107.0.0/16, 52.100.0.0/14, 104.47.0.0/17
    /// </summary>
    public List<string> AllowedClientCidrs { get; set; } = new();
}

public class ForwardingSettings
{
    /// <summary>EXO MX endpoint, e.g. "yourdomain.mail.protection.outlook.com"</summary>
    public string SmtpHost { get; set; } = string.Empty;
    public int SmtpPort { get; set; } = 25;
    public bool UseTls { get; set; } = false;
    public int TimeoutSeconds { get; set; } = 30;
    public int MaxRetries { get; set; } = 5;
    public int RetryBaseDelaySeconds { get; set; } = 10;
}

public class StorageSettings
{
    /// <summary>Base path for the durable queue and fallback storage.</summary>
    public string BasePath { get; set; } = "data";

    /// <summary>Subdirectory for messages pending processing.</summary>
    public string PendingFolder { get; set; } = "pending";

    /// <summary>Subdirectory for poison/dead-letter messages.</summary>
    public string PoisonFolder { get; set; } = "poison";
}

public class ProcessingSettings
{
    /// <summary>How many messages to process in one batch.</summary>
    public int BatchSize { get; set; } = 20;

    /// <summary>Polling interval when queue is empty.</summary>
    public int IdlePollIntervalSeconds { get; set; } = 2;

    /// <summary>Polling interval when queue has messages (tight loop).</summary>
    public int ActivePollIntervalMs { get; set; } = 100;

    /// <summary>Max retry count before moving to poison.</summary>
    public int MaxRetries { get; set; } = 10;

    /// <summary>Header stamped on processed messages to prevent loops.</summary>
    public string LoopPreventionHeader { get; set; } = "X-Signature-Applied";

    /// <summary>Domains considered "internal" for recipient scope rules.</summary>
    public List<string> InternalDomains { get; set; } = new();

    /// <summary>Consecutive failures before circuit breaker opens.</summary>
    public int CircuitBreakerThreshold { get; set; } = 5;

    /// <summary>Seconds before circuit breaker attempts recovery (half-open).</summary>
    public int CircuitBreakerRecoverySeconds { get; set; } = 60;
}

public class SignatureSettings
{
    /// <summary>Path to signature template files (HTML/TXT).</summary>
    public string TemplatesPath { get; set; } = "templates";

    /// <summary>Signature rules evaluated in priority order.</summary>
    public List<SignatureRule> Rules { get; set; } = new();

    /// <summary>Inline template definitions (alternative to file-based).</summary>
    public List<SignatureTemplate> Templates { get; set; } = new();

    /// <summary>
    /// Static sender identity mappings for template variable resolution.
    /// Key = email address (lowercase), Value = identity data.
    /// </summary>
    public List<SenderIdentity> SenderIdentities { get; set; } = new();

    /// <summary>
    /// Default identity used when sender doesn't match any SenderIdentities entry.
    /// </summary>
    public SenderIdentity DefaultIdentity { get; set; } = new();
}
