using System.CommandLine;
using System.Diagnostics;
using Azure.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using Serilog;
using SignatureAnalyzer.Analysis;
using SignatureService.Configuration;
using SignatureService.Engine;

/// <summary>
/// SignatureAnalyzer — Read-only email pattern analysis tool.
///
/// SAFETY GUARANTEES:
/// - NO SMTP client or MailKit SmtpClient in dependencies
/// - NO message forwarding or sending capability
/// - Graph API used in READ-ONLY mode (Mail.Read permission)
/// - All output goes to local filesystem only
/// - Specimen emails are anonymized before saving
/// </summary>

var rootCommand = new RootCommand("Signature injection pattern analyzer — scans mailboxes for unique email patterns");

var mailboxOption = new Option<string>(
    "--mailbox",
    "Target mailbox UPN or user ID to scan")
{ IsRequired = true };

var foldersOption = new Option<string[]>(
    "--folders",
    () => new[] { "SentItems" },
    "Mail folders to scan (default: SentItems)");

var outputOption = new Option<string>(
    "--output",
    () => "./analysis-output",
    "Output directory for specimens and reports");

var maxOption = new Option<int>(
    "--max",
    () => 10000,
    "Maximum messages to scan per folder");

var tenantOption = new Option<string>(
    "--tenant",
    "Azure AD tenant ID (for MI or client credentials)");

var clientIdOption = new Option<string>(
    "--client-id",
    "Client ID (for client credentials auth, or MI client ID)");

var clientSecretOption = new Option<string?>(
    "--client-secret",
    () => null,
    "Client secret (for client credentials auth; omit for Managed Identity)");

var templateDirOption = new Option<string>(
    "--templates",
    () => "../SignatureService/templates",
    "Path to signature templates directory");

rootCommand.AddOption(mailboxOption);
rootCommand.AddOption(foldersOption);
rootCommand.AddOption(outputOption);
rootCommand.AddOption(maxOption);
rootCommand.AddOption(tenantOption);
rootCommand.AddOption(clientIdOption);
rootCommand.AddOption(clientSecretOption);
rootCommand.AddOption(templateDirOption);

rootCommand.SetHandler(async (context) =>
{
    var mailbox = context.ParseResult.GetValueForOption(mailboxOption)!;
    var folders = context.ParseResult.GetValueForOption(foldersOption)!;
    var output = context.ParseResult.GetValueForOption(outputOption)!;
    var max = context.ParseResult.GetValueForOption(maxOption);
    var tenant = context.ParseResult.GetValueForOption(tenantOption);
    var clientId = context.ParseResult.GetValueForOption(clientIdOption);
    var clientSecret = context.ParseResult.GetValueForOption(clientSecretOption);
    var templateDir = context.ParseResult.GetValueForOption(templateDirOption)!;

    // Setup logging
    Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Information()
        .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
        .WriteTo.File(Path.Combine(output, "analyzer.log"),
            outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
        .CreateLogger();

    var loggerFactory = LoggerFactory.Create(b => b.AddSerilog());

    Log.Information("SignatureAnalyzer starting — READ-ONLY mode, no email sending capability");
    Log.Information("Target: {Mailbox}, Folders: {Folders}, Max: {Max}", mailbox, string.Join(",", folders), max);

    // Build Graph client
    var graphClient = CreateGraphClient(tenant, clientId, clientSecret);

    // Build engine components (same as SignatureService, but no SMTP/forwarding)
    var boundaryDetector = new ReplyBoundaryDetector(
        loggerFactory.CreateLogger<ReplyBoundaryDetector>());

    var fingerprintEngine = new FingerprintEngine(
        boundaryDetector,
        loggerFactory.CreateLogger<FingerprintEngine>());

    var scanner = new MailboxScanner(
        graphClient,
        fingerprintEngine,
        loggerFactory.CreateLogger<MailboxScanner>());

    // Build injection dry-run components
    var ruleEvaluator = new RuleEvaluator(
        Options.Create(new SignatureSettings()),
        Options.Create(new ProcessingSettings()),
        loggerFactory.CreateLogger<RuleEvaluator>());

    var identityResolver = new StaticIdentityResolver(
        Options.Create(new SignatureSettings()));

    var templateEngine = new TemplateEngine(
        Options.Create(new SignatureSettings { TemplatesPath = templateDir }),
        identityResolver,
        loggerFactory.CreateLogger<TemplateEngine>());

    var injector = new SignatureInjector(
        ruleEvaluator,
        templateEngine,
        boundaryDetector,
        Options.Create(new ProcessingSettings()),
        loggerFactory.CreateLogger<SignatureInjector>());

    var dryRun = new InjectionDryRun(
        injector,
        boundaryDetector,
        loggerFactory.CreateLogger<InjectionDryRun>());

    // Create output directory
    var specimenDir = Path.Combine(output, "specimens");
    Directory.CreateDirectory(specimenDir);

    // Scan
    var sw = Stopwatch.StartNew();

    foreach (var folder in folders)
    {
        Log.Information("Scanning folder: {Folder}", folder);
        await scanner.ScanFolderAsync(mailbox, folder, specimenDir, max, context.GetCancellationToken());
    }

    sw.Stop();

    // Generate report
    Log.Information("Generating analysis report...");
    var report = ReportGenerator.BuildReport(scanner, dryRun, mailbox, folders, sw.Elapsed);

    ReportGenerator.SaveJson(report, Path.Combine(output, "report.json"));
    ReportGenerator.SaveMarkdown(report, Path.Combine(output, "report.md"));

    Log.Information("Analysis complete:");
    Log.Information("  Scanned: {Count} messages", report.TotalMessagesScanned);
    Log.Information("  Unique patterns: {Count}", report.UniquePatterns);
    Log.Information("  Injection pass rate: {Rate:F1}%", report.InjectionPassRate);
    Log.Information("  Failed patterns: {Count}", report.InjectionFail);
    Log.Information("  Undetected boundaries: {Count}", report.UndetectedBoundaryPatterns.Count);
    Log.Information("  Report: {Path}", Path.GetFullPath(Path.Combine(output, "report.md")));
});

return await rootCommand.InvokeAsync(args);

// ============================================================================

static GraphServiceClient CreateGraphClient(
    string? tenantId, string? clientId, string? clientSecret)
{
    Azure.Core.TokenCredential credential;

    if (!string.IsNullOrEmpty(clientSecret))
    {
        // Client credentials flow (app registration with secret)
        credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
    }
    else if (!string.IsNullOrEmpty(clientId))
    {
        // Managed Identity (user-assigned)
        credential = new DefaultAzureCredential(new DefaultAzureCredentialOptions
        {
            TenantId = tenantId,
            ManagedIdentityClientId = clientId
        });
    }
    else
    {
        // Default: Interactive / Azure CLI / environment
        credential = new DefaultAzureCredential(new DefaultAzureCredentialOptions
        {
            TenantId = tenantId,
            ManagedIdentityClientId = clientId
        });
    }

    return new GraphServiceClient(credential, new[] { "https://graph.microsoft.com/.default" });
}
