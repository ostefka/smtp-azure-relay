using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace SignatureService.Engine;

/// <summary>
/// Circuit breaker that tracks consecutive failures and switches the service
/// to bypass mode when a threshold is reached. In bypass mode, messages are
/// forwarded directly without signature processing to prevent mail flow disruption.
///
/// States:
///   Closed  → normal operation, signatures applied
///   Open    → bypass mode, forward without signature (too many failures)
///   HalfOpen → testing recovery, allow one message through the pipeline
///
/// Thread-safe via Interlocked operations.
/// </summary>
public class CircuitBreaker
{
    private readonly int _failureThreshold;
    private readonly TimeSpan _recoveryTimeout;
    private readonly ILogger<CircuitBreaker> _logger;

    private int _consecutiveFailures;
    private long _openedAtTicks; // DateTimeOffset.UtcNow.Ticks when circuit opened
    private int _state; // 0=Closed, 1=Open, 2=HalfOpen

    private const int StateClosed = 0;
    private const int StateOpen = 1;
    private const int StateHalfOpen = 2;

    public CircuitBreaker(int failureThreshold, TimeSpan recoveryTimeout, ILogger<CircuitBreaker> logger)
    {
        _failureThreshold = failureThreshold;
        _recoveryTimeout = recoveryTimeout;
        _logger = logger;
    }

    /// <summary>True when circuit is open or half-open (should bypass signature processing).</summary>
    public bool IsOpen
    {
        get
        {
            var state = Volatile.Read(ref _state);
            if (state == StateClosed) return false;

            if (state == StateOpen)
            {
                // Check if recovery timeout has elapsed
                var openedAt = new DateTimeOffset(Volatile.Read(ref _openedAtTicks), TimeSpan.Zero);
                if (DateTimeOffset.UtcNow - openedAt >= _recoveryTimeout)
                {
                    // Transition to half-open — allow one attempt
                    if (Interlocked.CompareExchange(ref _state, StateHalfOpen, StateOpen) == StateOpen)
                    {
                        _logger.LogWarning("Circuit breaker → HALF-OPEN (testing recovery)");
                    }
                    return false; // allow this message through as a test
                }
            }

            return state == StateOpen;
        }
    }

    public string State => Volatile.Read(ref _state) switch
    {
        StateClosed => "Closed",
        StateOpen => "Open",
        StateHalfOpen => "HalfOpen",
        _ => "Unknown"
    };

    public int ConsecutiveFailures => Volatile.Read(ref _consecutiveFailures);

    /// <summary>Record a successful processing. Resets failure count and closes circuit.</summary>
    public void RecordSuccess()
    {
        var prev = Interlocked.Exchange(ref _consecutiveFailures, 0);
        var prevState = Interlocked.Exchange(ref _state, StateClosed);

        if (prevState != StateClosed)
        {
            _logger.LogWarning("Circuit breaker → CLOSED (recovered after {Failures} failures)", prev);
        }
    }

    /// <summary>Record a processing failure. Opens circuit if threshold reached.</summary>
    public void RecordFailure()
    {
        var count = Interlocked.Increment(ref _consecutiveFailures);

        if (count >= _failureThreshold)
        {
            var prevState = Interlocked.CompareExchange(ref _state, StateOpen, StateClosed);
            if (prevState == StateClosed)
            {
                Volatile.Write(ref _openedAtTicks, DateTimeOffset.UtcNow.Ticks);
                _logger.LogError(
                    "Circuit breaker → OPEN after {Failures} consecutive failures. " +
                    "Messages will bypass signature processing for {Timeout}s",
                    count, _recoveryTimeout.TotalSeconds);
            }

            // Also open from half-open on failure
            prevState = Interlocked.CompareExchange(ref _state, StateOpen, StateHalfOpen);
            if (prevState == StateHalfOpen)
            {
                Volatile.Write(ref _openedAtTicks, DateTimeOffset.UtcNow.Ticks);
                _logger.LogError("Circuit breaker → OPEN (recovery test failed)");
            }
        }
    }
}
