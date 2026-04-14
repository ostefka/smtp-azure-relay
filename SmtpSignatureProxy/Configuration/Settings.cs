namespace SmtpSignatureProxy.Configuration;

public class SmtpSettings
{
    public int Port { get; set; } = 25;
    public string ServerName { get; set; } = "signature-proxy";
    public int MaxMessageSizeKb { get; set; } = 35840;
}

public class ForwardingSettings
{
    /// <summary>
    /// EXO MX endpoint, e.g. "yourdomain.mail.protection.outlook.com"
    /// </summary>
    public string SmtpHost { get; set; } = string.Empty;
    public int SmtpPort { get; set; } = 25;
    public bool UseTls { get; set; } = false;
    public int TimeoutSeconds { get; set; } = 30;
}

public class SignatureSettings
{
    /// <summary>
    /// Path to the directory containing signature templates.
    /// Default looks in the app's "signatures" subfolder.
    /// </summary>
    public string TemplatesPath { get; set; } = "signatures";

    /// <summary>
    /// Default template file name (without extension).
    /// Engine looks for {name}.html and {name}.txt.
    /// </summary>
    public string DefaultTemplate { get; set; } = "default";

    /// <summary>
    /// Header stamped on processed messages to prevent loops.
    /// </summary>
    public string LoopPreventionHeader { get; set; } = "X-Signature-Applied";

    /// <summary>
    /// Skip signature if the message already has this header.
    /// </summary>
    public bool SkipIfAlreadySigned { get; set; } = true;

    /// <summary>
    /// HTML marker where the signature should be inserted.
    /// If not found, falls back to inserting before &lt;/body&gt;.
    /// </summary>
    public string HtmlInsertMarker { get; set; } = "<!-- SIGNATURE -->";
}
