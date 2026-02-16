#!/usr/bin/env pwsh
<#
.SYNOPSIS
    Quick smoke test — sends a single email and verifies it was accepted.
.PARAMETER SmtpServer
    Target SMTP server IP or hostname.
.PARAMETER Port
    SMTP port (default: 25).
#>
param(
    [Parameter(Mandatory)]
    [string]$SmtpServer,
    [int]$Port = 25
)

Write-Host "Sending test email to ${SmtpServer}:${Port}..." -ForegroundColor Cyan

try {
    $client = New-Object System.Net.Mail.SmtpClient($SmtpServer, $Port)
    $client.EnableSsl = $false
    $client.Timeout = 15000

    $msg = New-Object System.Net.Mail.MailMessage(
        "test@example.com",
        "crm@example.com",
        "Smoke test - $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')",
        "This is a smoke test message to verify the SMTP relay is accepting emails.")

    $client.Send($msg)
    $msg.Dispose()
    $client.Dispose()

    Write-Host "SUCCESS - Message accepted by server." -ForegroundColor Green
}
catch {
    Write-Host "FAILED - $($_.Exception.Message)" -ForegroundColor Red
    exit 1
}
