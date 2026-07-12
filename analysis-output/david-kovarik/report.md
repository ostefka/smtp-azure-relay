# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:22:24 UTC  
**Mailbox:** david.kovarik@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:02:07  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 134 |
| Duplicates skipped | 866 |
| Encrypted (skipped) | 0 |
| Injection PASS | 134 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 552 | 55.2% |
| Unknown | 448 | 44.8% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 757 | 75.7% |
| Reply | 218 | 21.8% |
| Forward | 25 | 2.5% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| Outlook-BorderTop | 164 | 16.4% |
| Outlook-divRplyFwdMsg | 53 | 5.3% |
| OWA-AppendOnSend | 17 | 1.7% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 15 | 420 |
| `multipart/alternative(text/plain+text/html)` | 32 | 246 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 7 | 127 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 8 | 28 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 2 | 27 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 7 | 18 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 17 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 4 | 17 |
| `text/html` | 1 | 8 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 2 | 8 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 6 | 8 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 7 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/gif)` | 4 | 7 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-zip-compressed)` | 2 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 2 | 4 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 2 | 4 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf)` | 2 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg)` | 1 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg)` | 2 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/msword)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 1 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+audio/mpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)+image/jpeg+video/mp4)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)+video/mp4)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-sharing-metadata-xml)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+video/mp4+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream)` | 1 | 1 |
| `multipart/alternative(text/plain+text/calendar)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+audio/wav+audio/wav)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/alternative(text/plain+multipart/related(text/html+image/png))` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #118** — Unknown / Reply (3 msgs, 0.3%) — `specimen-0118.eml`
- **Pattern #43** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0043.eml`
- **Pattern #123** — Unknown / Reply (2 msgs, 0.2%) — `specimen-0123.eml`
- **Pattern #127** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0127.eml`
- **Pattern #134** — Unknown / Reply (1 msgs, 0.1%) — `specimen-0134.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 117 | Unknown | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 383 | 38.3% | PASS | `specimen-0117.eml` |
| 8 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 62 | 6.2% | PASS | `specimen-0008.eml` |
| 9 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 60 | 6.0% | PASS | `specimen-0009.eml` |
| 11 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 51 | 5.1% | PASS | `specimen-0011.eml` |
| 19 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 36 | 3.6% | PASS | `specimen-0019.eml` |
| 14 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 24 | 2.4% | PASS | `specimen-0014.eml` |
| 6 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 22 | 2.2% | PASS | `specimen-0006.eml` |
| 119 | Unknown | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 20 | 2.0% | PASS | `specimen-0119.eml` |
| 116 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 17 | 1.7% | PASS | `specimen-0116.eml` |
| 77 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 15 | 1.5% | PASS | `specimen-0077.eml` |
| 17 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 14 | 1.4% | PASS | `specimen-0017.eml` |
| 32 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 14 | 1.4% | PASS | `specimen-0032.eml` |
| 73 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 12 | 1.2% | PASS | `specimen-0073.eml` |
| 4 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 11 | 1.1% | PASS | `specimen-0004.eml` |
| 28 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 11 | 1.1% | PASS | `specimen-0028.eml` |
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 10 | 1.0% | PASS | `specimen-0001.eml` |
| 115 | Unknown | New | `text/html` | none | - | 8 | 0.8% | PASS | `specimen-0115.eml` |
| 2 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 7 | 0.7% | PASS | `specimen-0002.eml` |
| 24 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 7 | 0.7% | PASS | `specimen-0024.eml` |
| 27 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 7 | 0.7% | PASS | `specimen-0027.eml` |
| 39 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 7 | 0.7% | PASS | `specimen-0039.eml` |
| 96 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 7 | 0.7% | PASS | `specimen-0096.eml` |
| 12 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 6 | 0.6% | PASS | `specimen-0012.eml` |
| 16 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 6 | 0.6% | PASS | `specimen-0016.eml` |
| 18 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 6 | 0.6% | PASS | `specimen-0018.eml` |
| 45 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 6 | 0.6% | PASS | `specimen-0045.eml` |
| 53 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 6 | 0.6% | PASS | `specimen-0053.eml` |
| 57 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 6 | 0.6% | PASS | `specimen-0057.eml` |
| 42 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 5 | 0.5% | PASS | `specimen-0042.eml` |
| 51 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 4 | 0.4% | PASS | `specimen-0051.eml` |
| 79 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 4 | 0.4% | PASS | `specimen-0079.eml` |
| 122 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0122.eml` |
| 20 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0020.eml` |
| 40 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0040.eml` |
| 44 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0044.eml` |
| 63 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0063.eml` |
| 76 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0076.eml` |
| 87 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0087.eml` |
| 90 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0090.eml` |
| 114 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0114.eml` |
| 118 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0118.eml` |
| 13 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0013.eml` |
| 22 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 2 | 0.2% | PASS | `specimen-0022.eml` |
| 26 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 2 | 0.2% | PASS | `specimen-0026.eml` |
| 30 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0030.eml` |
| 31 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0031.eml` |
| 34 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 2 | 0.2% | PASS | `specimen-0034.eml` |
| 38 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 2 | 0.2% | PASS | `specimen-0038.eml` |
| 43 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0043.eml` |
| 48 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 2 | 0.2% | PASS | `specimen-0048.eml` |
| 49 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 2 | 0.2% | PASS | `specimen-0049.eml` |
| 50 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0050.eml` |
| 66 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0066.eml` |
| 70 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 2 | 0.2% | PASS | `specimen-0070.eml` |
| 72 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0072.eml` |
| 78 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0078.eml` |
| 95 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0095.eml` |
| 97 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0097.eml` |
| 98 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0098.eml` |
| 101 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0101.eml` |
| 120 | Unknown | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0120.eml` |
| 123 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0123.eml` |
| 124 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 2 | 0.2% | PASS | `specimen-0124.eml` |
| 3 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0003.eml` |
| 5 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0005.eml` |
| 7 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0007.eml` |
| 10 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0010.eml` |
| 15 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0015.eml` |
| 21 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0021.eml` |
| 23 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0023.eml` |
| 25 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0025.eml` |
| 29 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0029.eml` |
| 33 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0033.eml` |
| 35 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 37 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0037.eml` |
| 41 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0041.eml` |
| 46 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0046.eml` |
| 47 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0047.eml` |
| 52 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 54 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 56 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0056.eml` |
| 58 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0058.eml` |
| 59 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 61 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 64 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0064.eml` |
| 65 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 67 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0067.eml` |
| 68 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 69 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0069.eml` |
| 71 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0071.eml` |
| 74 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0074.eml` |
| 75 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0075.eml` |
| 80 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0080.eml` |
| 81 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 82 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0082.eml` |
| 83 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0083.eml` |
| 84 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0084.eml` |
| 85 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0085.eml` |
| 86 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0086.eml` |
| 88 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0088.eml` |
| 89 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 91 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 92 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 94 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 99 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 100 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 102 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 103 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0103.eml` |
| 104 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 105 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 106 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0106.eml` |
| 107 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 108 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 109 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0109.eml` |
| 110 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 111 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0111.eml` |
| 112 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0112.eml` |
| 113 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 121 | Unknown | New | `multipart/alternative(text/plain+multipart/related(text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 125 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0125.eml` |
| 126 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 127 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 128 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0128.eml` |
| 129 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0129.eml` |
| 130 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0130.eml` |
| 131 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0131.eml` |
| 132 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 133 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 134 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0134.eml` |
