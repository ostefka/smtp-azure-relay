using System.Diagnostics;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SignatureService.Configuration;
using SignatureService.Domain;
using SignatureService.Engine;
using SignatureService.Storage;

namespace SignatureService.Services;

/// <summary>
/// Background worker that dequeues messages from the durable store,
/// processes them through the signature pipeline, and forwards to EXO.
///
/// Guarantees:
/// - At-least-once processing (retry on transient failure)
/// - Fail-open: if signature processing fails, forward original message unchanged
/// - Fail-open: if forwarding permanently rejects (5xx), forward raw original
/// - Circuit breaker: after N consecutive failures, bypass signature pipeline entirely
/// - Poison isolation: only truly unforwardable messages go to poison (both modified + raw failed)
/// - Messages are never deleted until successfully forwarded
/// </summary>
public class SignatureProcessingWorker : BackgroundService
{
    private readonly DurableMessageStore _store;
    private readonly SignatureInjector _injector;
    private readonly MessageForwarder _forwarder;
    private readonly CircuitBreaker _circuitBreaker;
    private readonly ProcessingSettings _settings;
    private readonly ILogger<SignatureProcessingWorker> _logger;

    public SignatureProcessingWorker(
        DurableMessageStore store,
        SignatureInjector injector,
        MessageForwarder forwarder,
        CircuitBreaker circuitBreaker,
        IOptions<ProcessingSettings> settings,
        ILogger<SignatureProcessingWorker> logger)
    {
        _store = store;
        _injector = injector;
        _forwarder = forwarder;
        _circuitBreaker = circuitBreaker;
        _settings = settings.Value;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation(
            "Signature processing worker starting (batch={BatchSize}, maxRetry={MaxRetries})",
            _settings.BatchSize, _settings.MaxRetries);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var items = await _store.DequeueAsync(_settings.BatchSize, stoppingToken);

                if (items.Count == 0)
                {
                    await Task.Delay(
                        TimeSpan.FromSeconds(_settings.IdlePollIntervalSeconds), stoppingToken);
                    continue;
                }

                _logger.LogDebug("Processing batch of {Count} messages (circuit={CircuitState})",
                    items.Count, _circuitBreaker.State);

                foreach (var item in items)
                {
                    if (stoppingToken.IsCancellationRequested) break;

                    // Skip if this item needs a retry delay
                    if (item.Meta.LastAttemptUtc.HasValue)
                    {
                        var delay = _forwarder.GetRetryDelay(item.Meta.RetryCount);
                        var elapsed = DateTimeOffset.UtcNow - item.Meta.LastAttemptUtc.Value;
                        if (elapsed < delay)
                        {
                            _logger.LogDebug("Skipping {Id} — retry delay not elapsed ({Elapsed}/{Delay})",
                                item.Meta.Id, elapsed, delay);
                            continue;
                        }
                    }

                    await ProcessItemAsync(item, stoppingToken);
                }

                // Brief pause between batches to avoid tight-looping
                await Task.Delay(_settings.ActivePollIntervalMs, stoppingToken);
            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
            {
                break;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled error in processing loop, continuing after delay");
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }

        _logger.LogInformation("Signature processing worker stopped");
    }

    private async Task ProcessItemAsync(QueueItem item, CancellationToken ct)
    {
        var sw = Stopwatch.StartNew();

        // === Decide: process normally or bypass? ===
        if (_circuitBreaker.IsOpen)
        {
            // Circuit is open — bypass signature processing entirely
            await ForwardRawAndComplete(item, "circuit-open", ct);
            return;
        }

        // === Normal processing path ===
        MimeMessage? message = null;
        ProcessingResult? result = null;
        bool signatureApplied = false;

        try
        {
            // 1. Parse the raw message
            using var stream = new MemoryStream(item.RawMessage);
            message = await MimeMessage.LoadAsync(stream, ct);

            // 2. Run through signature pipeline (this NEVER throws — returns result with Outcome)
            result = _injector.Process(message, item.Meta.EnvelopeTo);
            result.QueueItemId = item.Meta.Id;
            result.RetryCount = item.Meta.RetryCount;
            signatureApplied = result.Outcome == ProcessingOutcome.SignatureApplied;
        }
        catch (Exception parseEx)
        {
            // Failed to parse the message — forward raw
            _logger.LogWarning(parseEx,
                "Failed to parse message {Id}, forwarding raw", item.Meta.Id);
            await ForwardRawAndComplete(item, "parse-failed", ct);
            _circuitBreaker.RecordFailure();
            return;
        }

        // 3. Forward the message (modified or not — we always forward)
        try
        {
            await _forwarder.ForwardAsync(
                message,
                item.Meta.EnvelopeFrom,
                item.Meta.EnvelopeTo,
                ct);

            // Success — remove from queue
            _store.Complete(item);
            _circuitBreaker.RecordSuccess();

            sw.Stop();
            _logger.LogInformation(
                "Processed {Id}: {Outcome} in {Ms:F1}ms (rule={Rule}, type={Type}, boundary={Boundary})",
                item.Meta.Id,
                result?.Outcome ?? ProcessingOutcome.Skipped,
                sw.Elapsed.TotalMilliseconds,
                result?.MatchedRuleId ?? "none",
                result?.DetectedMessageType,
                result?.DetectedReplyBoundary ?? "none");
        }
        catch (SmtpForwardingException fwdEx) when (!fwdEx.IsTransient)
        {
            // Permanent rejection (5xx) of the modified message.
            // Try forwarding the original unmodified message.
            _logger.LogWarning(
                "Permanent rejection for modified {Id}: {Error}. Trying raw forward.",
                item.Meta.Id, fwdEx.Message);

            await ForwardRawAndComplete(item, "5xx-fallback", ct);
            _circuitBreaker.RecordFailure();
        }
        catch (SmtpForwardingException fwdEx) when (fwdEx.IsTransient)
        {
            // Transient error (4xx, network) — retry later
            sw.Stop();
            _logger.LogWarning(
                "Transient forwarding error for {Id} (attempt {Retry}): {Error}",
                item.Meta.Id, item.Meta.RetryCount + 1, fwdEx.Message);

            await _store.FailAsync(item, fwdEx.Message, _settings.MaxRetries, ct);
            _circuitBreaker.RecordFailure();
        }
        catch (Exception ex)
        {
            sw.Stop();
            _logger.LogWarning(ex,
                "Unexpected forwarding error for {Id} (attempt {Retry})",
                item.Meta.Id, item.Meta.RetryCount + 1);

            await _store.FailAsync(item, ex.Message, _settings.MaxRetries, ct);
            _circuitBreaker.RecordFailure();
        }
    }

    /// <summary>
    /// Forwards the original unmodified message bytes and completes the queue item.
    /// If even this fails, moves to retry/poison (absolute last resort).
    /// </summary>
    private async Task ForwardRawAndComplete(QueueItem item, string reason, CancellationToken ct)
    {
        try
        {
            await _forwarder.ForwardRawAsync(
                item.RawMessage,
                item.Meta.EnvelopeFrom,
                item.Meta.EnvelopeTo,
                ct);

            _store.Complete(item);

            _logger.LogWarning(
                "BYPASS [{Reason}]: Message {Id} forwarded WITHOUT signature",
                reason, item.Meta.Id);
        }
        catch (Exception rawEx)
        {
            // Even raw forwarding failed — truly cannot deliver right now.
            // Retry. Poison only as absolute last resort (EXO itself is down).
            _logger.LogError(rawEx,
                "CRITICAL: Cannot forward {Id} even as raw ({Reason}). " +
                "Will retry (attempt {Retry}/{Max}).",
                item.Meta.Id, reason, item.Meta.RetryCount + 1, _settings.MaxRetries);

            await _store.FailAsync(item, $"raw-forward-failed: {rawEx.Message}", _settings.MaxRetries, ct);
        }
    }
}
