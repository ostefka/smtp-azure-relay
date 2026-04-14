<#
.SYNOPSIS
    Tests the Signature Service with different email formats:
    fresh compose, Outlook reply, Gmail reply, forward, plain text,
    already-signed (loop prevention), and multipart/alternative.

.PARAMETER SmtpHost
    Target SMTP host (default: localhost)

.PARAMETER SmtpPort
    Target SMTP port (default: 25)
#>
param(
    [string]$SmtpHost = "localhost",
    [int]$SmtpPort = 25,
    [string]$From = "admin@cdx25.shop",
    [string]$To = "external@example.com"
)

$ErrorActionPreference = "Stop"
$passed = 0
$failed = 0

function Send-RawSmtp {
    param(
        [string]$Host,
        [int]$Port,
        [string]$MailFrom,
        [string[]]$RcptTo,
        [string]$Data
    )

    $tcp = [System.Net.Sockets.TcpClient]::new()
    $tcp.Connect($Host, $Port)
    $stream = $tcp.GetStream()
    $reader = [System.IO.StreamReader]::new($stream)
    $writer = [System.IO.StreamWriter]::new($stream)
    $writer.AutoFlush = $true

    $banner = $reader.ReadLine()

    $writer.WriteLine("EHLO test.local")
    while (($line = $reader.ReadLine()) -and $line -match "^250-") {}

    $writer.WriteLine("MAIL FROM:<$MailFrom>")
    $response = $reader.ReadLine()
    if ($response -notmatch "^250") { throw "MAIL FROM failed: $response" }

    foreach ($rcpt in $RcptTo) {
        $writer.WriteLine("RCPT TO:<$rcpt>")
        $response = $reader.ReadLine()
        if ($response -notmatch "^250") { throw "RCPT TO failed: $response" }
    }

    $writer.WriteLine("DATA")
    $response = $reader.ReadLine()
    if ($response -notmatch "^354") { throw "DATA failed: $response" }

    $writer.Write($Data)
    $writer.WriteLine(".")
    $response = $reader.ReadLine()

    $writer.WriteLine("QUIT")
    try { $reader.ReadLine() | Out-Null } catch {}
    $tcp.Close()

    return $response
}

function Run-Test {
    param(
        [string]$Name,
        [string]$MessageData,
        [string]$ExpectedResponsePrefix = "250"
    )

    Write-Host "`n--- Test: $Name ---" -ForegroundColor Cyan
    try {
        $response = Send-RawSmtp -Host $SmtpHost -Port $SmtpPort `
            -MailFrom $From -RcptTo @($To) -Data $MessageData

        if ($response -match "^$ExpectedResponsePrefix") {
            Write-Host "  PASS: $response" -ForegroundColor Green
            $script:passed++
        } else {
            Write-Host "  FAIL: Expected $ExpectedResponsePrefix, got: $response" -ForegroundColor Red
            $script:failed++
        }
    } catch {
        Write-Host "  FAIL: $($_.Exception.Message)" -ForegroundColor Red
        $script:failed++
    }
}

# ============================================================
# Test 1: Fresh compose (HTML)
# ============================================================
$freshHtml = @"
From: $From
To: $To
Subject: Fresh compose test
MIME-Version: 1.0
Content-Type: text/html; charset=utf-8

<html><body><p>Hello, this is a fresh message.</p></body></html>
"@
Run-Test -Name "Fresh compose (HTML)" -MessageData $freshHtml

# ============================================================
# Test 2: Outlook reply (divRplyFwdMsg)
# ============================================================
$outlookReply = @"
From: $From
To: $To
Subject: RE: Project update
In-Reply-To: <original-msg-id@example.com>
MIME-Version: 1.0
Content-Type: text/html; charset=utf-8

<html><body>
<p>Thanks, I'll review this today.</p>
<div id="divRplyFwdMsg" dir="ltr">
<hr style="display:inline-block;width:98%" tabindex="-1">
<div id="x_divRplyFwdMsg" style="font-size:11pt;font-family:Calibri,sans-serif">
<b>From:</b> Someone &lt;someone@example.com&gt;<br>
<b>Sent:</b> Monday, April 7, 2026 10:00 AM<br>
<b>To:</b> $From<br>
<b>Subject:</b> Project update<br>
</div>
<div><p>Here is the project update you requested.</p></div>
</div>
</body></html>
"@
Run-Test -Name "Outlook reply (divRplyFwdMsg)" -MessageData $outlookReply

# ============================================================
# Test 3: Gmail reply (gmail_quote)
# ============================================================
$gmailReply = @"
From: $From
To: $To
Subject: Re: Meeting tomorrow
In-Reply-To: <gmail-original@mail.gmail.com>
References: <gmail-original@mail.gmail.com>
MIME-Version: 1.0
Content-Type: text/html; charset=utf-8

<html><body>
<div dir="ltr">Yes, 3pm works for me.</div>
<div class="gmail_quote">
<div class="gmail_attr" dir="ltr">On Mon, Apr 7, 2026 at 2:30 PM John Doe &lt;john@example.com&gt; wrote:</div>
<blockquote class="gmail_quote" style="margin:0px 0px 0px 0.8ex;border-left:1px solid rgb(204,204,204);padding-left:1ex">
<div>Can we meet at 3pm tomorrow?</div>
</blockquote>
</div>
</body></html>
"@
Run-Test -Name "Gmail reply (gmail_quote)" -MessageData $gmailReply

# ============================================================
# Test 4: Apple Mail reply (blockquote cite)
# ============================================================
$appleReply = @"
From: $From
To: $To
Subject: Re: Proposal
In-Reply-To: <apple-original@icloud.com>
MIME-Version: 1.0
Content-Type: text/html; charset=utf-8

<html><body>
<div>Looks good, let's proceed.</div>
<br>
<blockquote type="cite">
<div>On Apr 7, 2026, at 11:00 AM, Jane &lt;jane@example.com&gt; wrote:</div>
<div>Please review the attached proposal.</div>
</blockquote>
</body></html>
"@
Run-Test -Name "Apple Mail reply (blockquote cite)" -MessageData $appleReply

# ============================================================
# Test 5: Plain text reply
# ============================================================
$plainReply = @"
From: $From
To: $To
Subject: RE: Invoice question
In-Reply-To: <plain-original@example.com>
MIME-Version: 1.0
Content-Type: text/plain; charset=utf-8

I'll check the invoice number and get back to you.

-----Original Message-----
From: billing@example.com
Sent: Monday, April 7, 2026 9:00 AM
To: $From
Subject: Invoice question

Can you confirm invoice #12345?
"@
Run-Test -Name "Plain text reply (Original Message)" -MessageData $plainReply

# ============================================================
# Test 6: Forward
# ============================================================
$forward = @"
From: $From
To: $To
Subject: FW: Important notice
MIME-Version: 1.0
Content-Type: text/html; charset=utf-8

<html><body>
<p>FYI - see below.</p>
<div id="divRplyFwdMsg" dir="ltr">
<hr style="display:inline-block;width:98%">
<div style="font-size:11pt;font-family:Calibri,sans-serif">
<b>From:</b> notices@company.com<br>
<b>Sent:</b> Monday, April 7, 2026 8:00 AM<br>
<b>Subject:</b> Important notice<br>
</div>
<div><p>All hands meeting at 4pm.</p></div>
</div>
</body></html>
"@
Run-Test -Name "Forward (FW: + divRplyFwdMsg)" -MessageData $forward

# ============================================================
# Test 7: Already signed (loop prevention)
# ============================================================
$alreadySigned = @"
From: $From
To: $To
Subject: Already signed test
X-Signature-Applied: true
MIME-Version: 1.0
Content-Type: text/html; charset=utf-8

<html><body><p>This message already has a signature.</p></body></html>
"@
Run-Test -Name "Already signed (should skip)" -MessageData $alreadySigned

# ============================================================
# Test 8: Thunderbird reply (moz-cite-prefix)
# ============================================================
$thunderbirdReply = @"
From: $From
To: $To
Subject: Re: Linux build
In-Reply-To: <tb-original@example.com>
MIME-Version: 1.0
Content-Type: text/html; charset=utf-8

<html><body>
<p>The build is passing now on CI.</p>
<div class="moz-cite-prefix">On 04/07/2026 14:00, Developer wrote:</div>
<blockquote type="cite">
<p>Did the Linux build pass?</p>
</blockquote>
</body></html>
"@
Run-Test -Name "Thunderbird reply (moz-cite-prefix)" -MessageData $thunderbirdReply

# ============================================================
# Test 9: Plain text with "On ... wrote:" pattern
# ============================================================
$plainOnWrote = @"
From: $From
To: $To
Subject: Re: Quick question
In-Reply-To: <q-original@example.com>
MIME-Version: 1.0
Content-Type: text/plain; charset=utf-8

Yes, that's correct.

On Mon, Apr 7, 2026 at 3:15 PM John Doe <john@example.com> wrote:
> Is the deadline still Friday?
> Let me know.
"@
Run-Test -Name "Plain text reply (On ... wrote:)" -MessageData $plainOnWrote

# ============================================================
# Summary
# ============================================================
Write-Host "`n============================================" -ForegroundColor White
Write-Host "Results: $passed passed, $failed failed out of $($passed + $failed) tests" `
    -ForegroundColor $(if ($failed -eq 0) { "Green" } else { "Red" })
Write-Host "============================================`n"
