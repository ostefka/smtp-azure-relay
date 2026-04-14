using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SignatureService.Engine;
using SignatureService.Storage;

namespace SignatureService.Services;

/// <summary>
/// Minimal HTTP health probe endpoint for Azure Container Apps.
/// Runs on a configurable port (default 8080), exposes:
///   GET /health    → 200 OK with service status JSON
///   GET /ready     → 200 if ready, 503 if not
///   GET /metrics   → queue depth, poison count, circuit state
///
/// Used by:
///   - Container Apps liveness probe → /health
///   - Container Apps readiness probe → /ready
///   - Azure Monitor / custom alerts → /metrics
/// </summary>
public class HealthCheckService : BackgroundService
{
    private readonly DurableMessageStore _store;
    private readonly CircuitBreaker _circuitBreaker;
    private readonly ILogger<HealthCheckService> _logger;
    private readonly int _port;

    public HealthCheckService(
        DurableMessageStore store,
        CircuitBreaker circuitBreaker,
        ILogger<HealthCheckService> logger,
        int port = 8080)
    {
        _store = store;
        _circuitBreaker = circuitBreaker;
        _logger = logger;
        _port = port;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var listener = new System.Net.HttpListener();
        listener.Prefixes.Add($"http://+:{_port}/");

        try
        {
            listener.Start();
            _logger.LogInformation("Health check endpoint listening on port {Port}", _port);

            while (!stoppingToken.IsCancellationRequested)
            {
                var contextTask = listener.GetContextAsync();
                var completedTask = await Task.WhenAny(contextTask, Task.Delay(Timeout.Infinite, stoppingToken));

                if (completedTask != contextTask) break;

                var ctx = await contextTask;
                await HandleRequestAsync(ctx);
            }
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
        {
            // Normal shutdown
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Health check endpoint error");
        }
        finally
        {
            listener.Stop();
        }
    }

    private async Task HandleRequestAsync(System.Net.HttpListenerContext ctx)
    {
        try
        {
            var path = ctx.Request.Url?.AbsolutePath?.TrimEnd('/') ?? "";

            var (statusCode, body) = path switch
            {
                "/health" => GetHealth(),
                "/ready" => GetReady(),
                "/metrics" => GetMetrics(),
                _ => (404, "{\"error\":\"not found\"}")
            };

            ctx.Response.StatusCode = statusCode;
            ctx.Response.ContentType = "application/json";
            var bytes = System.Text.Encoding.UTF8.GetBytes(body);
            await ctx.Response.OutputStream.WriteAsync(bytes);
            ctx.Response.Close();
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Error handling health check request");
            try { ctx.Response.StatusCode = 500; ctx.Response.Close(); } catch { }
        }
    }

    private (int, string) GetHealth()
    {
        var status = new
        {
            status = "healthy",
            timestamp = DateTimeOffset.UtcNow,
            circuit = _circuitBreaker.State,
            uptime = (DateTimeOffset.UtcNow - _startTime).TotalSeconds
        };
        return (200, JsonSerializer.Serialize(status));
    }

    private (int, string) GetReady()
    {
        // Ready if we can access the durable store
        try
        {
            var pending = _store.PendingCount;
            return (200, JsonSerializer.Serialize(new
            {
                ready = true,
                pendingMessages = pending
            }));
        }
        catch
        {
            return (503, JsonSerializer.Serialize(new { ready = false, reason = "storage unavailable" }));
        }
    }

    private (int, string) GetMetrics()
    {
        var metrics = new
        {
            timestamp = DateTimeOffset.UtcNow,
            queue = new
            {
                pending = _store.PendingCount,
                poison = _store.PoisonCount
            },
            circuitBreaker = new
            {
                state = _circuitBreaker.State,
                consecutiveFailures = _circuitBreaker.ConsecutiveFailures
            }
        };
        return (200, JsonSerializer.Serialize(metrics));
    }

    private static readonly DateTimeOffset _startTime = DateTimeOffset.UtcNow;
}
