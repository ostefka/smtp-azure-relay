using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SmtpRelay.Configuration;
using SmtpRelay.Services;
using SmtpRelay.Storage;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    var builder = Host.CreateApplicationBuilder(args);

    builder.Services.AddSerilog(config => config.ReadFrom.Configuration(builder.Configuration));

    builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("Smtp"));
    builder.Services.Configure<AzureStorageSettings>(builder.Configuration.GetSection("AzureStorage"));
    builder.Services.Configure<ProcessingSettings>(builder.Configuration.GetSection("Processing"));

    builder.Services.AddSingleton<AzureMessageStore>();
    builder.Services.AddHostedService<SmtpListenerService>();
    builder.Services.AddHostedService<MessageProcessingWorker>();

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
