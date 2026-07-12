# Signature Injection Analysis Report

**Generated:** 2026-05-10 16:51:19 UTC  
**Mailbox:** ondrej.stefka@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:01:35  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 146 |
| Duplicates skipped | 854 |
| Encrypted (skipped) | 0 |
| Injection PASS | 146 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 968 | 96.8% |
| Unknown | 32 | 3.2% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 787 | 78.7% |
| Reply | 183 | 18.3% |
| Forward | 30 | 3.0% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 133 | 13.3% |
| Outlook-BorderTop | 39 | 3.9% |
| Outlook-divRplyFwdMsg | 25 | 2.5% |
| Outlook-FromHeader | 2 | 0.2% |
| Outlook-OriginalMessage | 1 | 0.1% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 32 | 561 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 15 | 198 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 9 | 45 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 4 | 36 |
| `text/plain` | 2 | 19 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 6 | 17 |
| `multipart/mixed(text/plain+application/x-microsoft-rpmsg-message)` | 3 | 15 |
| `text/html` | 4 | 10 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 6 | 9 |
| `multipart/alternative(text/plain+text/calendar)` | 4 | 8 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 6 | 6 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 2 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 4 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/zip)` | 2 | 4 |
| `multipart/mixed(text/plain+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream)` | 1 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 3 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-sharing-metadata-xml)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/plain)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.presentationml.presentation)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-zip-compressed)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 2 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+text/plain)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/plain+text/plain)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)+application/vnd.ms-excel)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(text/plain+application/x-zip-compressed+application/x-gzip)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/x-zip-compressed)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/alternative(text/plain+multipart/related(text/html+image/png+image/png+image/png))` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #31** — Exchange-Server / Forward (3 msgs, 0.3%) — `specimen-0031.eml`
- **Pattern #132** — Exchange-Server / Forward (3 msgs, 0.3%) — `specimen-0132.eml`
- **Pattern #95** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0095.eml`
- **Pattern #102** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0102.eml`
- **Pattern #127** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0127.eml`
- **Pattern #130** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0130.eml`
- **Pattern #133** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0133.eml`
- **Pattern #134** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0134.eml`
- **Pattern #141** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0141.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 227 | 22.7% | PASS | `specimen-0001.eml` |
| 5 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 73 | 7.3% | PASS | `specimen-0005.eml` |
| 4 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 71 | 7.1% | PASS | `specimen-0004.eml` |
| 79 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 64 | 6.4% | PASS | `specimen-0079.eml` |
| 45 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 59 | 5.9% | PASS | `specimen-0045.eml` |
| 37 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 53 | 5.3% | PASS | `specimen-0037.eml` |
| 23 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 31 | 3.1% | PASS | `specimen-0023.eml` |
| 33 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 30 | 3.0% | PASS | `specimen-0033.eml` |
| 10 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 28 | 2.8% | PASS | `specimen-0010.eml` |
| 9 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 19 | 1.9% | PASS | `specimen-0009.eml` |
| 39 | Exchange-Server | New | `text/plain` | none | - | 18 | 1.8% | PASS | `specimen-0039.eml` |
| 29 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 13 | 1.3% | PASS | `specimen-0029.eml` |
| 27 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 11 | 1.1% | PASS | `specimen-0027.eml` |
| 28 | Exchange-Server | New | `multipart/mixed(text/plain+application/x-microsoft-rpmsg-...` | none | - | 11 | 1.1% | PASS | `specimen-0028.eml` |
| 67 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 11 | 1.1% | PASS | `specimen-0067.eml` |
| 60 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 10 | 1.0% | PASS | `specimen-0060.eml` |
| 38 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 9 | 0.9% | PASS | `specimen-0038.eml` |
| 139 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 9 | 0.9% | PASS | `specimen-0139.eml` |
| 59 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 8 | 0.8% | PASS | `specimen-0059.eml` |
| 2 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 7 | 0.7% | PASS | `specimen-0002.eml` |
| 106 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 7 | 0.7% | PASS | `specimen-0106.eml` |
| 131 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 7 | 0.7% | PASS | `specimen-0131.eml` |
| 6 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 6 | 0.6% | PASS | `specimen-0006.eml` |
| 15 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0015.eml` |
| 19 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0019.eml` |
| 65 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 6 | 0.6% | PASS | `specimen-0065.eml` |
| 78 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 6 | 0.6% | PASS | `specimen-0078.eml` |
| 87 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0087.eml` |
| 8 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 5 | 0.5% | PASS | `specimen-0008.eml` |
| 14 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0014.eml` |
| 20 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 5 | 0.5% | PASS | `specimen-0020.eml` |
| 129 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 5 | 0.5% | PASS | `specimen-0129.eml` |
| 63 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0063.eml` |
| 85 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0085.eml` |
| 96 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0096.eml` |
| 110 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0110.eml` |
| 144 | Unknown | New | `text/html` | none | - | 4 | 0.4% | PASS | `specimen-0144.eml` |
| 3 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 3 | 0.3% | PASS | `specimen-0003.eml` |
| 17 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 3 | 0.3% | PASS | `specimen-0017.eml` |
| 31 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0031.eml` |
| 49 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0049.eml` |
| 58 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0058.eml` |
| 77 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0077.eml` |
| 91 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0091.eml` |
| 103 | Exchange-Server | New | `multipart/mixed(text/plain+application/x-microsoft-rpmsg-...` | none | - | 3 | 0.3% | PASS | `specimen-0103.eml` |
| 126 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0126.eml` |
| 128 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 3 | 0.3% | PASS | `specimen-0128.eml` |
| 132 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0132.eml` |
| 140 | Exchange-Server | New | `multipart/mixed(text/plain+application/octet-stream+appli...` | none | - | 3 | 0.3% | PASS | `specimen-0140.eml` |
| 143 | Unknown | New | `text/html` | none | - | 3 | 0.3% | PASS | `specimen-0143.eml` |
| 12 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0012.eml` |
| 16 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0016.eml` |
| 25 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0025.eml` |
| 30 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0030.eml` |
| 48 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0048.eml` |
| 74 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0074.eml` |
| 81 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0081.eml` |
| 100 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0100.eml` |
| 101 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0101.eml` |
| 104 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0104.eml` |
| 119 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0119.eml` |
| 120 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0120.eml` |
| 145 | Unknown | New | `text/html` | none | - | 2 | 0.2% | PASS | `specimen-0145.eml` |
| 7 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 1 | 0.1% | PASS | `specimen-0007.eml` |
| 11 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0011.eml` |
| 13 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0013.eml` |
| 18 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0018.eml` |
| 21 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0021.eml` |
| 22 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0022.eml` |
| 24 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0024.eml` |
| 26 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0026.eml` |
| 32 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0032.eml` |
| 34 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0034.eml` |
| 35 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 40 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0040.eml` |
| 41 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0041.eml` |
| 42 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0042.eml` |
| 43 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0043.eml` |
| 44 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0044.eml` |
| 46 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0046.eml` |
| 47 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/calendar)` | Outlook-FromHeader | - | 1 | 0.1% | PASS | `specimen-0047.eml` |
| 50 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/calendar)` | Outlook-FromHeader | - | 1 | 0.1% | PASS | `specimen-0050.eml` |
| 51 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0051.eml` |
| 52 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 53 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0053.eml` |
| 54 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 56 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0056.eml` |
| 57 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 61 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 64 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0064.eml` |
| 66 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0066.eml` |
| 68 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 69 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0069.eml` |
| 70 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0070.eml` |
| 71 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0071.eml` |
| 72 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0072.eml` |
| 73 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0073.eml` |
| 75 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0075.eml` |
| 76 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0076.eml` |
| 80 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0080.eml` |
| 82 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0082.eml` |
| 83 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0083.eml` |
| 84 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0084.eml` |
| 86 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0086.eml` |
| 88 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0088.eml` |
| 89 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 90 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0090.eml` |
| 92 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 94 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 95 | Exchange-Server | Reply | `multipart/mixed(text/plain+application/x-zip-compressed+a...` | none | - | 1 | 0.1% | PASS | `specimen-0095.eml` |
| 97 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0097.eml` |
| 98 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0098.eml` |
| 99 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 102 | Exchange-Server | Reply | `multipart/mixed(text/plain+application/x-microsoft-rpmsg-...` | none | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 105 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 107 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 108 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 109 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0109.eml` |
| 111 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0111.eml` |
| 112 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0112.eml` |
| 113 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 114 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0114.eml` |
| 115 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0115.eml` |
| 116 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0116.eml` |
| 117 | Exchange-Server | Reply | `text/plain` | Outlook-OriginalMessage | - | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 118 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0118.eml` |
| 121 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 122 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0122.eml` |
| 123 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0123.eml` |
| 124 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0124.eml` |
| 125 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0125.eml` |
| 127 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 130 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0130.eml` |
| 133 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 134 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 135 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0135.eml` |
| 136 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0136.eml` |
| 137 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 141 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Unknown | New | `multipart/alternative(text/plain+multipart/related(text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 146 | Unknown | New | `text/html` | none | - | 1 | 0.1% | PASS | `specimen-0146.eml` |
