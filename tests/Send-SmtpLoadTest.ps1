#!/usr/bin/env pwsh
<#
.SYNOPSIS
    SMTP performance/load test for SmtpRelay.
.DESCRIPTION
    Sends configurable number of test emails via SMTP to the target server.
    Measures throughput, latency percentiles, and error rate.
.PARAMETER SmtpServer
    Target SMTP server IP or hostname.
.PARAMETER Port
    SMTP port (default: 25).
.PARAMETER MessageCount
    Total number of messages to send (default: 1000).
.PARAMETER Concurrency
    Number of parallel senders (default: 10).
.PARAMETER MessageSizeKb
    Approximate size of each message body in KB (default: 5).
.PARAMETER From
    Sender email address.
.PARAMETER To
    Recipient email address.
#>
param(
    [Parameter(Mandatory)]
    [string]$SmtpServer,

    [int]$Port = 25,
    [int]$MessageCount = 1000,
    [int]$Concurrency = 10,
    [int]$MessageSizeKb = 5,
    [string]$From = "loadtest@example.com",
    [string]$To = "crm@example.com"
)

$ErrorActionPreference = "Stop"

# Generate a reusable body of the requested size
$bodyChunk = "X" * 1024
$body = ($bodyChunk * $MessageSizeKb)

Write-Host "=== SMTP Load Test ===" -ForegroundColor Cyan
Write-Host "Target      : ${SmtpServer}:${Port}"
Write-Host "Messages    : $MessageCount"
Write-Host "Concurrency : $Concurrency"
Write-Host "Message Size: ~${MessageSizeKb} KB"
Write-Host ""

$results = [System.Collections.Concurrent.ConcurrentBag[PSCustomObject]]::new()
$errors = [System.Collections.Concurrent.ConcurrentBag[string]]::new()
$sent = [ref]0

$startTime = [System.Diagnostics.Stopwatch]::StartNew()

# Split work across parallel runspaces
$scriptBlock = {
    param($SmtpServer, $Port, $From, $To, $body, $index, $results, $errors, $sent)

    $sw = [System.Diagnostics.Stopwatch]::StartNew()
    $subject = "Load test message #$index - $(Get-Date -Format 'HH:mm:ss.fff')"

    try {
        $client = New-Object System.Net.Mail.SmtpClient($SmtpServer, $Port)
        $client.EnableSsl = $false
        $client.Timeout = 30000

        $msg = New-Object System.Net.Mail.MailMessage($From, $To, $subject, $body)
        $client.Send($msg)

        $sw.Stop()
        $results.Add([PSCustomObject]@{
            Index     = $index
            LatencyMs = $sw.ElapsedMilliseconds
            Status    = "OK"
        })

        $msg.Dispose()
        $client.Dispose()
    }
    catch {
        $sw.Stop()
        $results.Add([PSCustomObject]@{
            Index     = $index
            LatencyMs = $sw.ElapsedMilliseconds
            Status    = "ERROR"
        })
        $errors.Add("Message #${index}: $($_.Exception.Message)")
    }

    [System.Threading.Interlocked]::Increment($sent)
}

Write-Host "Sending..." -ForegroundColor Yellow

# Use thread jobs for parallelism
$jobs = @()
for ($i = 1; $i -le $MessageCount; $i++) {
    # Throttle: wait if we have too many active jobs
    while (($jobs | Where-Object { $_.State -eq 'Running' }).Count -ge $Concurrency) {
        Start-Sleep -Milliseconds 50
        # Show progress
        $completedCount = ($jobs | Where-Object { $_.State -eq 'Completed' }).Count
        Write-Host "`r  Progress: $completedCount / $MessageCount" -NoNewline
    }

    $jobs += Start-ThreadJob -ScriptBlock $scriptBlock `
        -ArgumentList $SmtpServer, $Port, $From, $To, $body, $i, $results, $errors, $sent
}

# Wait for all remaining jobs
Write-Host ""
Write-Host "Waiting for remaining jobs to finish..." -ForegroundColor Yellow
$jobs | Wait-Job | Out-Null
$jobs | Remove-Job -Force

$startTime.Stop()

# Analyze results
$allResults = $results.ToArray()
$okResults = $allResults | Where-Object { $_.Status -eq "OK" }
$errResults = $allResults | Where-Object { $_.Status -eq "ERROR" }

$latencies = ($okResults | Sort-Object LatencyMs).LatencyMs

Write-Host ""
Write-Host "=== Results ===" -ForegroundColor Green
Write-Host "Total messages : $MessageCount"
Write-Host "Successful     : $($okResults.Count)"
Write-Host "Failed         : $($errResults.Count)"
Write-Host "Error rate     : $([Math]::Round(($errResults.Count / $MessageCount) * 100, 2))%"
Write-Host "Total time     : $([Math]::Round($startTime.Elapsed.TotalSeconds, 1))s"
Write-Host "Throughput     : $([Math]::Round($okResults.Count / $startTime.Elapsed.TotalSeconds, 1)) msg/s"
Write-Host ""

if ($latencies.Count -gt 0) {
    $p50Index = [Math]::Floor($latencies.Count * 0.50)
    $p90Index = [Math]::Floor($latencies.Count * 0.90)
    $p95Index = [Math]::Floor($latencies.Count * 0.95)
    $p99Index = [Math]::Min([Math]::Floor($latencies.Count * 0.99), $latencies.Count - 1)

    Write-Host "Latency (ms):" -ForegroundColor Cyan
    Write-Host "  Min  : $($latencies[0])"
    Write-Host "  P50  : $($latencies[$p50Index])"
    Write-Host "  P90  : $($latencies[$p90Index])"
    Write-Host "  P95  : $($latencies[$p95Index])"
    Write-Host "  P99  : $($latencies[$p99Index])"
    Write-Host "  Max  : $($latencies[-1])"
    Write-Host "  Avg  : $([Math]::Round(($latencies | Measure-Object -Average).Average, 1))"
}

if ($errors.Count -gt 0) {
    Write-Host ""
    Write-Host "=== Errors (first 10) ===" -ForegroundColor Red
    $errors.ToArray() | Select-Object -First 10 | ForEach-Object { Write-Host "  $_" }
}

Write-Host ""
Write-Host "=== Storage Verification ===" -ForegroundColor Yellow
Write-Host "Check blobs and table entries to verify all messages were stored and processed."
Write-Host "Use Azure Storage Explorer or:" -ForegroundColor Gray
Write-Host "  az storage blob list --account-name <name> --container-name raw-emails --output table | Measure-Object" -ForegroundColor Gray
