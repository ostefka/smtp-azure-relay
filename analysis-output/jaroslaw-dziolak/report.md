# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:05:38 UTC  
**Mailbox:** jaroslaw.dziolak@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:02:48  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 262 |
| Duplicates skipped | 738 |
| Encrypted (skipped) | 0 |
| Injection PASS | 262 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 993 | 99.3% |
| Unknown | 7 | 0.7% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 652 | 65.2% |
| Reply | 268 | 26.8% |
| Forward | 80 | 8.0% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 225 | 22.5% |
| Outlook-BorderTop | 55 | 5.5% |
| Outlook-divRplyFwdMsg | 28 | 2.8% |
| Outlook-OriginalMessage | 2 | 0.2% |
| OriginalMessage-Text | 1 | 0.1% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 27 | 352 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 9 | 182 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 22 | 76 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 10 | 71 |
| `multipart/alternative(text/plain+text/calendar)` | 2 | 39 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 16 | 37 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 11 | 23 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 4 | 14 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 7 | 12 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 6 | 11 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 5 | 10 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 4 | 10 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png)` | 8 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 5 | 8 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png)` | 2 | 5 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 3 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png)` | 4 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png)` | 5 | 5 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 3 | 4 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf)` | 4 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 3 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+application/pdf)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png)` | 2 | 3 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/pdf)` | 3 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf)` | 3 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/plain+application/octet-stream+application/pdf)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png)` | 1 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png)+application/pdf)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/pdf)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif)` | 2 | 2 |
| `text/plain` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png)+message/rfc822)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+text/plain)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+text/plain)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/msword)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/plain+text/plain)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/x-png+image/x-png+image/x-png+image/x-png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/x-png+image/x-png+image/x-png+image/x-png+image/x-png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(text/plain+application/x-microsoft-rpmsg-message)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif)+application/msword)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg)+application/msword+application/msword)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif)` | 1 | 1 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+image/svg+xml+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/octet-stream)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/gif+image/gif)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 1 | 1 |
| `multipart/mixed(text/plain+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png)+application/octet-stream)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/png+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822+message/rfc822)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #70** — Exchange-Server / Reply (4 msgs, 0.4%) — `specimen-0070.eml`
- **Pattern #27** — Exchange-Server / Reply (3 msgs, 0.3%) — `specimen-0027.eml`
- **Pattern #39** — Exchange-Server / Reply (3 msgs, 0.3%) — `specimen-0039.eml`
- **Pattern #40** — Exchange-Server / Forward (2 msgs, 0.2%) — `specimen-0040.eml`
- **Pattern #57** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0057.eml`
- **Pattern #216** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0216.eml`
- **Pattern #4** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0004.eml`
- **Pattern #15** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0015.eml`
- **Pattern #18** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0018.eml`
- **Pattern #20** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0020.eml`
- **Pattern #28** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0028.eml`
- **Pattern #34** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0034.eml`
- **Pattern #36** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0036.eml`
- **Pattern #41** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0041.eml`
- **Pattern #52** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0052.eml`
- **Pattern #60** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0060.eml`
- **Pattern #62** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0062.eml`
- **Pattern #63** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0063.eml`
- **Pattern #65** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0065.eml`
- **Pattern #67** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0067.eml`
- **Pattern #68** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0068.eml`
- **Pattern #110** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0110.eml`
- **Pattern #121** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0121.eml`
- **Pattern #161** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0161.eml`
- **Pattern #167** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0167.eml`
- **Pattern #212** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0212.eml`
- **Pattern #214** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0214.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 2 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 143 | 14.3% | PASS | `specimen-0002.eml` |
| 10 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 52 | 5.2% | PASS | `specimen-0010.eml` |
| 5 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 46 | 4.6% | PASS | `specimen-0005.eml` |
| 8 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 46 | 4.6% | PASS | `specimen-0008.eml` |
| 16 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 43 | 4.3% | PASS | `specimen-0016.eml` |
| 112 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 39 | 3.9% | PASS | `specimen-0112.eml` |
| 227 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 38 | 3.8% | PASS | `specimen-0227.eml` |
| 1 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 27 | 2.7% | PASS | `specimen-0001.eml` |
| 7 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 23 | 2.3% | PASS | `specimen-0007.eml` |
| 14 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 18 | 1.8% | PASS | `specimen-0014.eml` |
| 26 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 18 | 1.8% | PASS | `specimen-0026.eml` |
| 11 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 16 | 1.6% | PASS | `specimen-0011.eml` |
| 46 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 12 | 1.2% | PASS | `specimen-0046.eml` |
| 56 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 12 | 1.2% | PASS | `specimen-0056.eml` |
| 180 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 12 | 1.2% | PASS | `specimen-0180.eml` |
| 229 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 12 | 1.2% | PASS | `specimen-0229.eml` |
| 51 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 11 | 1.1% | PASS | `specimen-0051.eml` |
| 163 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 11 | 1.1% | PASS | `specimen-0163.eml` |
| 23 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 10 | 1.0% | PASS | `specimen-0023.eml` |
| 24 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 10 | 1.0% | PASS | `specimen-0024.eml` |
| 73 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 10 | 1.0% | PASS | `specimen-0073.eml` |
| 37 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 7 | 0.7% | PASS | `specimen-0037.eml` |
| 6 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 6 | 0.6% | PASS | `specimen-0006.eml` |
| 17 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 6 | 0.6% | PASS | `specimen-0017.eml` |
| 43 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 6 | 0.6% | PASS | `specimen-0043.eml` |
| 49 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0049.eml` |
| 54 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0054.eml` |
| 182 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 6 | 0.6% | PASS | `specimen-0182.eml` |
| 31 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0031.eml` |
| 55 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 5 | 0.5% | PASS | `specimen-0055.eml` |
| 93 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 5 | 0.5% | PASS | `specimen-0093.eml` |
| 174 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 5 | 0.5% | PASS | `specimen-0174.eml` |
| 219 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 5 | 0.5% | PASS | `specimen-0219.eml` |
| 22 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 4 | 0.4% | PASS | `specimen-0022.eml` |
| 42 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 4 | 0.4% | PASS | `specimen-0042.eml` |
| 70 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 4 | 0.4% | PASS | `specimen-0070.eml` |
| 78 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 4 | 0.4% | PASS | `specimen-0078.eml` |
| 82 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 4 | 0.4% | PASS | `specimen-0082.eml` |
| 116 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0116.eml` |
| 188 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0188.eml` |
| 189 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0189.eml` |
| 194 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0194.eml` |
| 196 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0196.eml` |
| 223 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0223.eml` |
| 12 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0012.eml` |
| 27 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0027.eml` |
| 33 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0033.eml` |
| 39 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0039.eml` |
| 64 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0064.eml` |
| 91 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0091.eml` |
| 108 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0108.eml` |
| 131 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0131.eml` |
| 164 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0164.eml` |
| 166 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0166.eml` |
| 183 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 3 | 0.3% | PASS | `specimen-0183.eml` |
| 185 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0185.eml` |
| 186 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0186.eml` |
| 192 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0192.eml` |
| 225 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0225.eml` |
| 9 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0009.eml` |
| 29 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0029.eml` |
| 38 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0038.eml` |
| 40 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0040.eml` |
| 44 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0044.eml` |
| 45 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0045.eml` |
| 57 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0057.eml` |
| 69 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0069.eml` |
| 72 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0072.eml` |
| 86 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0086.eml` |
| 114 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0114.eml` |
| 123 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0123.eml` |
| 140 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0140.eml` |
| 143 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0143.eml` |
| 150 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0150.eml` |
| 152 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0152.eml` |
| 158 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0158.eml` |
| 170 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0170.eml` |
| 173 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0173.eml` |
| 216 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0216.eml` |
| 226 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0226.eml` |
| 228 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0228.eml` |
| 230 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0230.eml` |
| 231 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0231.eml` |
| 232 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0232.eml` |
| 233 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0233.eml` |
| 236 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 2 | 0.2% | PASS | `specimen-0236.eml` |
| 238 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0238.eml` |
| 240 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0240.eml` |
| 246 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0246.eml` |
| 250 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0250.eml` |
| 3 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0003.eml` |
| 4 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0004.eml` |
| 13 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0013.eml` |
| 15 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0015.eml` |
| 18 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0018.eml` |
| 19 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0019.eml` |
| 20 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0020.eml` |
| 21 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0021.eml` |
| 25 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0025.eml` |
| 28 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0028.eml` |
| 30 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0030.eml` |
| 32 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0032.eml` |
| 34 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0034.eml` |
| 35 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 41 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0041.eml` |
| 47 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0047.eml` |
| 48 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0048.eml` |
| 50 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0050.eml` |
| 52 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 53 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0053.eml` |
| 58 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0058.eml` |
| 59 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 61 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 63 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 65 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 66 | Exchange-Server | New | `text/plain` | none | - | 1 | 0.1% | PASS | `specimen-0066.eml` |
| 67 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0067.eml` |
| 68 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 71 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OriginalMessage-Text | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0071.eml` |
| 74 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0074.eml` |
| 75 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0075.eml` |
| 76 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0076.eml` |
| 77 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0077.eml` |
| 79 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0079.eml` |
| 80 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0080.eml` |
| 81 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 83 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0083.eml` |
| 84 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0084.eml` |
| 85 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0085.eml` |
| 87 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0087.eml` |
| 88 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0088.eml` |
| 89 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 90 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0090.eml` |
| 92 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 94 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 95 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0095.eml` |
| 96 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0096.eml` |
| 97 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0097.eml` |
| 98 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0098.eml` |
| 99 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 100 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 101 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0101.eml` |
| 102 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 103 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0103.eml` |
| 104 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 105 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 106 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0106.eml` |
| 107 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 109 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0109.eml` |
| 110 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 111 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0111.eml` |
| 113 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 115 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0115.eml` |
| 117 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 118 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0118.eml` |
| 119 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0119.eml` |
| 120 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0120.eml` |
| 121 | Exchange-Server | Forward | `multipart/mixed(text/plain+application/x-microsoft-rpmsg-...` | none | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 122 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0122.eml` |
| 124 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0124.eml` |
| 125 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0125.eml` |
| 126 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 127 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 128 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0128.eml` |
| 129 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0129.eml` |
| 130 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0130.eml` |
| 132 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 133 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 134 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 135 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0135.eml` |
| 136 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0136.eml` |
| 137 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 139 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0139.eml` |
| 141 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 144 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0144.eml` |
| 145 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0145.eml` |
| 146 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0146.eml` |
| 147 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0147.eml` |
| 148 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0148.eml` |
| 149 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0149.eml` |
| 151 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0151.eml` |
| 153 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0153.eml` |
| 154 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0154.eml` |
| 155 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0155.eml` |
| 156 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0156.eml` |
| 157 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0157.eml` |
| 159 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0159.eml` |
| 160 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0160.eml` |
| 161 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0161.eml` |
| 162 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0162.eml` |
| 165 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0165.eml` |
| 167 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0167.eml` |
| 168 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0168.eml` |
| 169 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0169.eml` |
| 171 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0171.eml` |
| 172 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0172.eml` |
| 175 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0175.eml` |
| 176 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0176.eml` |
| 177 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0177.eml` |
| 178 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0178.eml` |
| 179 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0179.eml` |
| 181 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0181.eml` |
| 184 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0184.eml` |
| 187 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0187.eml` |
| 190 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0190.eml` |
| 191 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0191.eml` |
| 193 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0193.eml` |
| 195 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0195.eml` |
| 197 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0197.eml` |
| 198 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0198.eml` |
| 199 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0199.eml` |
| 200 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0200.eml` |
| 201 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0201.eml` |
| 202 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0202.eml` |
| 203 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0203.eml` |
| 204 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0204.eml` |
| 205 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0205.eml` |
| 206 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0206.eml` |
| 207 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0207.eml` |
| 208 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0208.eml` |
| 209 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0209.eml` |
| 210 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0210.eml` |
| 211 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0211.eml` |
| 212 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0212.eml` |
| 213 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0213.eml` |
| 214 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0214.eml` |
| 215 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0215.eml` |
| 217 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0217.eml` |
| 218 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0218.eml` |
| 220 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0220.eml` |
| 221 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0221.eml` |
| 222 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0222.eml` |
| 224 | Exchange-Server | Reply | `multipart/mixed(text/plain+application/pdf)` | Outlook-OriginalMessage | - | 1 | 0.1% | PASS | `specimen-0224.eml` |
| 234 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0234.eml` |
| 235 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0235.eml` |
| 237 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0237.eml` |
| 239 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0239.eml` |
| 241 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0241.eml` |
| 242 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0242.eml` |
| 243 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0243.eml` |
| 244 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0244.eml` |
| 245 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0245.eml` |
| 247 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0247.eml` |
| 248 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0248.eml` |
| 249 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0249.eml` |
| 251 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0251.eml` |
| 252 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0252.eml` |
| 253 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0253.eml` |
| 254 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0254.eml` |
| 255 | Exchange-Server | Reply | `text/plain` | Outlook-OriginalMessage | - | 1 | 0.1% | PASS | `specimen-0255.eml` |
| 256 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0256.eml` |
| 257 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0257.eml` |
| 258 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0258.eml` |
| 259 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0259.eml` |
| 260 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0260.eml` |
| 261 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0261.eml` |
| 262 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0262.eml` |
