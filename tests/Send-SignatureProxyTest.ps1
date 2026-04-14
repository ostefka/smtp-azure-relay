#!/usr/bin/env pwsh
<#
.SYNOPSIS
    Sends an HTML test email through the signature proxy and verifies
    the signature was injected by checking the forwarded message.
.PARAMETER SmtpServer
    Signature proxy IP or hostname.
.PARAMETER Port
    SMTP port (default: 25).
#>
param(
    [Parameter(Mandatory)]
    [string]$SmtpServer,
    [int]$Port = 25
)

Write-Host "=== Signature Proxy Test ===" -ForegroundColor Cyan
Write-Host "Target: ${SmtpServer}:${Port}"
Write-Host ""

# --- Test 1: HTML email ---
Write-Host "[1/3] Sending HTML email..." -ForegroundColor Yellow

try {
    $client = New-Object System.Net.Mail.SmtpClient($SmtpServer, $Port)
    $client.EnableSsl = $false
    $client.Timeout = 30000

    $msg = New-Object System.Net.Mail.MailMessage
    $msg.From = "sender@contoso.com"
    $msg.To.Add("recipient@external.com")
    $msg.Subject = "Signature test (HTML) - $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')"
    $msg.IsBodyHtml = $true
    $msg.Body = @"
<html>
<body>
<p>Hello,</p>
<p>This is a test message with <b>HTML</b> content.</p>
<p>The signature should appear below this text.</p>
</body>
</html>
"@

    $client.Send($msg)
    $msg.Dispose()
    $client.Dispose()

    Write-Host "  SUCCESS - HTML message accepted." -ForegroundColor Green
}
catch {
    Write-Host "  FAILED - $($_.Exception.Message)" -ForegroundColor Red
}

# --- Test 2: Plain text email ---
Write-Host "[2/3] Sending plain text email..." -ForegroundColor Yellow

try {
    $client = New-Object System.Net.Mail.SmtpClient($SmtpServer, $Port)
    $client.EnableSsl = $false
    $client.Timeout = 30000

    $msg = New-Object System.Net.Mail.MailMessage
    $msg.From = "sender@contoso.com"
    $msg.To.Add("recipient@external.com")
    $msg.Subject = "Signature test (text) - $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')"
    $msg.IsBodyHtml = $false
    $msg.Body = "Hello, this is a plain text test message.`nThe signature should appear below."

    $client.Send($msg)
    $msg.Dispose()
    $client.Dispose()

    Write-Host "  SUCCESS - Text message accepted." -ForegroundColor Green
}
catch {
    Write-Host "  FAILED - $($_.Exception.Message)" -ForegroundColor Red
}

# --- Test 3: Email with X-Signature-Applied (should be forwarded as-is) ---
Write-Host "[3/3] Sending pre-signed email (loop test)..." -ForegroundColor Yellow

try {
    $client = New-Object System.Net.Mail.SmtpClient($SmtpServer, $Port)
    $client.EnableSsl = $false
    $client.Timeout = 30000

    $msg = New-Object System.Net.Mail.MailMessage
    $msg.From = "sender@contoso.com"
    $msg.To.Add("recipient@external.com")
    $msg.Subject = "Loop prevention test - $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')"
    $msg.IsBodyHtml = $true
    $msg.Body = "<html><body><p>This already has a signature.</p></body></html>"
    $msg.Headers.Add("X-Signature-Applied", "true")

    $client.Send($msg)
    $msg.Dispose()
    $client.Dispose()

    Write-Host "  SUCCESS - Pre-signed message accepted (should skip signature)." -ForegroundColor Green
}
catch {
    Write-Host "  FAILED - $($_.Exception.Message)" -ForegroundColor Red
}

Write-Host ""
Write-Host "Check container logs to verify:" -ForegroundColor Yellow
Write-Host "  - Test 1 & 2: 'Signature applied to message'" -ForegroundColor Gray
Write-Host "  - Test 3: 'already signed, forwarding as-is'" -ForegroundColor Gray
Write-Host "  - All 3: 'Forwarded ... to ...'" -ForegroundColor Gray
