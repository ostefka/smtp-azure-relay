using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SmtpSignatureProxy.Configuration;
using SmtpSignatureProxy.Services;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    var builder = Host.CreateApplicationBuilder(args);

    builder.Services.AddSerilog(config => config.ReadFrom.Configuration(builder.Configuration));

    builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("Smtp"));
    builder.Services.Configure<ForwardingSettings>(builder.Configuration.GetSection("Forwarding"));
    builder.Services.Configure<SignatureSettings>(builder.Configuration.GetSection("Signature"));

    builder.Services.AddSingleton<SignatureEngine>();
    builder.Services.AddSingleton<MessageForwarder>();
    builder.Services.AddHostedService<SmtpListenerService>();

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
