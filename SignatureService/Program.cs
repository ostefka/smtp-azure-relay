using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using SignatureService.Configuration;
using SignatureService.Engine;
using SignatureService.Services;
using SignatureService.Storage;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    var builder = Host.CreateApplicationBuilder(args);

    builder.Services.AddSerilog(config => config.ReadFrom.Configuration(builder.Configuration));

    // Configuration
    builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("Smtp"));
    builder.Services.Configure<ForwardingSettings>(builder.Configuration.GetSection("Forwarding"));
    builder.Services.Configure<StorageSettings>(builder.Configuration.GetSection("Storage"));
    builder.Services.Configure<ProcessingSettings>(builder.Configuration.GetSection("Processing"));
    builder.Services.Configure<SignatureSettings>(builder.Configuration.GetSection("Signature"));

    // Storage
    builder.Services.AddSingleton<DurableMessageStore>();

    // Engine
    builder.Services.AddSingleton<IIdentityResolver, StaticIdentityResolver>();
    builder.Services.AddSingleton<TemplateEngine>();
    builder.Services.AddSingleton<ReplyBoundaryDetector>();
    builder.Services.AddSingleton<RuleEvaluator>();
    builder.Services.AddSingleton<SignatureInjector>();

    // Circuit breaker — opens after 5 consecutive failures, recovers after 60s
    builder.Services.AddSingleton(sp =>
    {
        var processingConfig = builder.Configuration.GetSection("Processing");
        var threshold = processingConfig.GetValue("CircuitBreakerThreshold", 5);
        var recoverySeconds = processingConfig.GetValue("CircuitBreakerRecoverySeconds", 60);
        return new CircuitBreaker(
            threshold,
            TimeSpan.FromSeconds(recoverySeconds),
            sp.GetRequiredService<ILogger<CircuitBreaker>>());
    });

    // Services
    builder.Services.AddSingleton<ExoIpFilter>();
    builder.Services.AddSingleton<MessageForwarder>();
    builder.Services.AddHostedService<SmtpListenerService>();
    builder.Services.AddHostedService<SignatureProcessingWorker>();

    // Health check endpoint
    builder.Services.AddHostedService(sp =>
    {
        var port = builder.Configuration.GetValue("HealthCheck:Port", 8080);
        return new HealthCheckService(
            sp.GetRequiredService<DurableMessageStore>(),
            sp.GetRequiredService<CircuitBreaker>(),
            sp.GetRequiredService<ILogger<HealthCheckService>>(),
            port);
    });

    var host = builder.Build();
    await host.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    await Log.CloseAndFlushAsync();
}
