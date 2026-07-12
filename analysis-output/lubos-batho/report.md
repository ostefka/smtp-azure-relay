# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:02:36 UTC  
**Mailbox:** lubos.batho@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:02:28  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 172 |
| Duplicates skipped | 828 |
| Encrypted (skipped) | 0 |
| Injection PASS | 172 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 990 | 99.0% |
| Unknown | 10 | 1.0% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| Reply | 474 | 47.4% |
| New | 460 | 46.0% |
| Forward | 66 | 6.6% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 466 | 46.6% |
| Outlook-divRplyFwdMsg | 14 | 1.4% |
| OriginalMessage-Text | 2 | 0.2% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 24 | 351 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 9 | 262 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 9 | 56 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 4 | 36 |
| `multipart/alternative(text/plain+text/calendar)` | 1 | 28 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 6 | 28 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 4 | 24 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 5 | 18 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+pdf/signosign.2)` | 4 | 18 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 10 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png)` | 1 | 10 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg)` | 1 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html+text/calendar)+image/png)` | 2 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg+image/jpeg)` | 1 | 8 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 2 | 7 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 4 | 7 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-zip-compressed)` | 3 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 4 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 3 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 4 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 2 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 4 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/jpeg)` | 2 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 3 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+pdf/signosign.2+pdf/signosign.2)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 1 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/html)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/gif+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/jpeg)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png+image/gif+image/gif+image/gif+image/gif+image/gif+image/png+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/png+image/png+image/gif+image/gif+image/gif)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/gif+image/png+image/gif)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/gif)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+pdf/signosign.2)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html+text/calendar)+application/octet-stream+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/jpeg)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+audio/wav)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html+text/calendar)+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/gif+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/gif+image/gif+image/gif)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/gif+image/png+image/jpeg+image/gif+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)+message/rfc822+application/octet-stream)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+pdf/signosign.2+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png)+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/plain+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(text/plain+application/x-microsoft-rpmsg-message)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+text/plain)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/plain)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/gif+image/png+image/jpeg+image/gif+image/png+image/png+image/png+image/png+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/gif+image/png+image/jpeg+image/png+image/png+image/gif+image/png)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #33** — Exchange-Server / Forward (8 msgs, 0.8%) — `specimen-0033.eml`
- **Pattern #58** — Exchange-Server / Forward (8 msgs, 0.8%) — `specimen-0058.eml`
- **Pattern #10** — Exchange-Server / Reply (5 msgs, 0.5%) — `specimen-0010.eml`
- **Pattern #7** — Exchange-Server / Forward (4 msgs, 0.4%) — `specimen-0007.eml`
- **Pattern #139** — Exchange-Server / Reply (3 msgs, 0.3%) — `specimen-0139.eml`
- **Pattern #3** — Exchange-Server / Forward (2 msgs, 0.2%) — `specimen-0003.eml`
- **Pattern #41** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0041.eml`
- **Pattern #70** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0070.eml`
- **Pattern #133** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0133.eml`
- **Pattern #4** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0004.eml`
- **Pattern #16** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0016.eml`
- **Pattern #18** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0018.eml`
- **Pattern #26** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0026.eml`
- **Pattern #35** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0035.eml`
- **Pattern #48** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0048.eml`
- **Pattern #54** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0054.eml`
- **Pattern #57** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0057.eml`
- **Pattern #62** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0062.eml`
- **Pattern #68** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0068.eml`
- **Pattern #75** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0075.eml`
- **Pattern #91** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0091.eml`
- **Pattern #95** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0095.eml`
- **Pattern #99** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0099.eml`
- **Pattern #100** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0100.eml`
- **Pattern #101** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0101.eml`
- **Pattern #113** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0113.eml`
- **Pattern #140** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0140.eml`
- **Pattern #141** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0141.eml`
- **Pattern #143** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0143.eml`
- **Pattern #155** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0155.eml`
- **Pattern #157** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0157.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 2 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 136 | 13.6% | PASS | `specimen-0002.eml` |
| 8 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 108 | 10.8% | PASS | `specimen-0008.eml` |
| 9 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 79 | 7.9% | PASS | `specimen-0009.eml` |
| 78 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 63 | 6.3% | PASS | `specimen-0078.eml` |
| 17 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 60 | 6.0% | PASS | `specimen-0017.eml` |
| 6 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 59 | 5.9% | PASS | `specimen-0006.eml` |
| 12 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 34 | 3.4% | PASS | `specimen-0012.eml` |
| 107 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 29 | 2.9% | PASS | `specimen-0107.eml` |
| 20 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 28 | 2.8% | PASS | `specimen-0020.eml` |
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 25 | 2.5% | PASS | `specimen-0001.eml` |
| 11 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 22 | 2.2% | PASS | `specimen-0011.eml` |
| 31 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 13 | 1.3% | PASS | `specimen-0031.eml` |
| 64 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 13 | 1.3% | PASS | `specimen-0064.eml` |
| 13 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 11 | 1.1% | PASS | `specimen-0013.eml` |
| 22 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 11 | 1.1% | PASS | `specimen-0022.eml` |
| 56 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 11 | 1.1% | PASS | `specimen-0056.eml` |
| 28 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 10 | 1.0% | PASS | `specimen-0028.eml` |
| 85 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 10 | 1.0% | PASS | `specimen-0085.eml` |
| 156 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 10 | 1.0% | PASS | `specimen-0156.eml` |
| 47 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 9 | 0.9% | PASS | `specimen-0047.eml` |
| 109 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 9 | 0.9% | PASS | `specimen-0109.eml` |
| 128 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 9 | 0.9% | PASS | `specimen-0128.eml` |
| 33 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | outlook-underscore-separator | 8 | 0.8% | PASS | `specimen-0033.eml` |
| 58 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 8 | 0.8% | PASS | `specimen-0058.eml` |
| 96 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 8 | 0.8% | PASS | `specimen-0096.eml` |
| 44 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 6 | 0.6% | PASS | `specimen-0044.eml` |
| 84 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 6 | 0.6% | PASS | `specimen-0084.eml` |
| 10 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 5 | 0.5% | PASS | `specimen-0010.eml` |
| 53 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 5 | 0.5% | PASS | `specimen-0053.eml` |
| 130 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 5 | 0.5% | PASS | `specimen-0130.eml` |
| 5 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0005.eml` |
| 7 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 4 | 0.4% | PASS | `specimen-0007.eml` |
| 43 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 4 | 0.4% | PASS | `specimen-0043.eml` |
| 90 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 4 | 0.4% | PASS | `specimen-0090.eml` |
| 59 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0059.eml` |
| 74 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0074.eml` |
| 76 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0076.eml` |
| 83 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0083.eml` |
| 87 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0087.eml` |
| 97 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0097.eml` |
| 139 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0139.eml` |
| 3 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0003.eml` |
| 25 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0025.eml` |
| 29 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0029.eml` |
| 41 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0041.eml` |
| 45 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0045.eml` |
| 50 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0050.eml` |
| 60 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0060.eml` |
| 67 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0067.eml` |
| 69 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0069.eml` |
| 70 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0070.eml` |
| 77 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0077.eml` |
| 82 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0082.eml` |
| 86 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0086.eml` |
| 102 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0102.eml` |
| 103 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0103.eml` |
| 112 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0112.eml` |
| 115 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0115.eml` |
| 129 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0129.eml` |
| 133 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0133.eml` |
| 136 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0136.eml` |
| 144 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0144.eml` |
| 160 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0160.eml` |
| 4 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0004.eml` |
| 14 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0014.eml` |
| 15 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0015.eml` |
| 16 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0016.eml` |
| 18 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0018.eml` |
| 19 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0019.eml` |
| 21 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0021.eml` |
| 23 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0023.eml` |
| 24 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0024.eml` |
| 26 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0026.eml` |
| 27 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0027.eml` |
| 30 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0030.eml` |
| 32 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0032.eml` |
| 34 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0034.eml` |
| 35 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 37 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0037.eml` |
| 38 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0038.eml` |
| 39 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0039.eml` |
| 40 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0040.eml` |
| 42 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0042.eml` |
| 46 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0046.eml` |
| 48 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0048.eml` |
| 49 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 51 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0051.eml` |
| 52 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 54 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 57 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 61 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 63 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 65 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 66 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0066.eml` |
| 68 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 71 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0071.eml` |
| 72 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0072.eml` |
| 73 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0073.eml` |
| 75 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0075.eml` |
| 79 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0079.eml` |
| 80 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0080.eml` |
| 81 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 88 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OriginalMessage-Text | - | 1 | 0.1% | PASS | `specimen-0088.eml` |
| 89 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 91 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 92 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OriginalMessage-Text | OWA-Signature | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 94 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 95 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0095.eml` |
| 98 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0098.eml` |
| 99 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 100 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 101 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0101.eml` |
| 104 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 105 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 106 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0106.eml` |
| 108 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 110 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 111 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0111.eml` |
| 113 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 114 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0114.eml` |
| 116 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0116.eml` |
| 117 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 118 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0118.eml` |
| 119 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0119.eml` |
| 120 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0120.eml` |
| 121 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 122 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0122.eml` |
| 123 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0123.eml` |
| 124 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0124.eml` |
| 125 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0125.eml` |
| 126 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 127 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 131 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0131.eml` |
| 132 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 134 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 135 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0135.eml` |
| 137 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 140 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0140.eml` |
| 141 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 143 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0143.eml` |
| 145 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0145.eml` |
| 146 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0146.eml` |
| 147 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0147.eml` |
| 148 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0148.eml` |
| 149 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0149.eml` |
| 150 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0150.eml` |
| 151 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0151.eml` |
| 152 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0152.eml` |
| 153 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0153.eml` |
| 154 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0154.eml` |
| 155 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0155.eml` |
| 157 | Exchange-Server | Forward | `multipart/mixed(text/plain+application/x-microsoft-rpmsg-...` | none | - | 1 | 0.1% | PASS | `specimen-0157.eml` |
| 158 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0158.eml` |
| 159 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0159.eml` |
| 161 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0161.eml` |
| 162 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0162.eml` |
| 163 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0163.eml` |
| 164 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0164.eml` |
| 165 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0165.eml` |
| 166 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0166.eml` |
| 167 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0167.eml` |
| 168 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0168.eml` |
| 169 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0169.eml` |
| 170 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0170.eml` |
| 171 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0171.eml` |
| 172 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0172.eml` |
