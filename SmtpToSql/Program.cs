using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SmtpToSql.Services;
using SmtpToSql.Configuration;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    var builder = Host.CreateApplicationBuilder(args);

    builder.Services.AddSerilog(config => config.ReadFrom.Configuration(builder.Configuration));

    builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("Smtp"));
    builder.Services.Configure<SqlSettings>(builder.Configuration.GetSection("Sql"));
    builder.Services.Configure<FallbackStorageSettings>(builder.Configuration.GetSection("FallbackStorage"));

    builder.Services.AddSingleton<IMessageStore, DurableMessageStore>();
    builder.Services.AddSingleton<SmtpListenerService>();
    builder.Services.AddHostedService(sp => sp.GetRequiredService<SmtpListenerService>());
    builder.Services.AddHostedService<MessageProcessingWorker>();

    builder.Services.AddWindowsService(options =>
    {
        options.ServiceName = "SmtpToSql";
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
