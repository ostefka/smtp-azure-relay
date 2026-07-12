# Signature Injection Analysis Report

**Generated:** 2026-05-10 16:56:15 UTC  
**Mailbox:** vilem.svoboda@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:03:08  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 198 |
| Duplicates skipped | 802 |
| Encrypted (skipped) | 0 |
| Injection PASS | 198 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 938 | 93.8% |
| Unknown | 62 | 6.2% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 413 | 41.3% |
| Reply | 354 | 35.4% |
| Forward | 233 | 23.3% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 529 | 52.9% |
| Outlook-divRplyFwdMsg | 47 | 4.7% |
| Outlook-BorderTop | 5 | 0.5% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 24 | 283 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 11 | 157 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 14 | 95 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 12 | 82 |
| `multipart/alternative(text/plain+text/calendar)` | 1 | 72 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 47 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 5 | 31 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 8 | 22 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 7 | 18 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 3 | 15 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 3 | 12 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf)` | 5 | 9 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+pdf/signosign.2)` | 1 | 8 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf)` | 5 | 7 |
| `multipart/mixed(text/html+image/jpeg)` | 1 | 6 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/pdf)` | 2 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 2 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 3 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 4 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 5 | 6 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 5 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 3 | 5 |
| `text/html` | 1 | 4 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 2 | 4 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/gif)+application/pdf)` | 1 | 3 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/gif)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png)` | 2 | 3 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)+application/pdf)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif)` | 2 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+application/ics)` | 2 | 3 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 3 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 3 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 3 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.ms-excel)` | 1 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif+image/png+image/png)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/gif+image/gif+image/jpeg+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif+image/gif)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/zip)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/msword)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html+text/calendar)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/gif+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/csv)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/gif)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #87** — Exchange-Server / Forward (2 msgs, 0.2%) — `specimen-0087.eml`
- **Pattern #81** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0081.eml`
- **Pattern #122** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0122.eml`
- **Pattern #180** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0180.eml`
- **Pattern #183** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0183.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 33 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 101 | 10.1% | PASS | `specimen-0033.eml` |
| 13 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 78 | 7.8% | PASS | `specimen-0013.eml` |
| 46 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 72 | 7.2% | PASS | `specimen-0046.eml` |
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 50 | 5.0% | PASS | `specimen-0001.eml` |
| 2 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 47 | 4.7% | PASS | `specimen-0002.eml` |
| 16 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 36 | 3.6% | PASS | `specimen-0016.eml` |
| 43 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 34 | 3.4% | PASS | `specimen-0043.eml` |
| 58 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 34 | 3.4% | PASS | `specimen-0058.eml` |
| 5 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 30 | 3.0% | PASS | `specimen-0005.eml` |
| 4 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 25 | 2.5% | PASS | `specimen-0004.eml` |
| 6 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 20 | 2.0% | PASS | `specimen-0006.eml` |
| 18 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 15 | 1.5% | PASS | `specimen-0018.eml` |
| 22 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 15 | 1.5% | PASS | `specimen-0022.eml` |
| 42 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 15 | 1.5% | PASS | `specimen-0042.eml` |
| 53 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 15 | 1.5% | PASS | `specimen-0053.eml` |
| 25 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 14 | 1.4% | PASS | `specimen-0025.eml` |
| 17 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 13 | 1.3% | PASS | `specimen-0017.eml` |
| 34 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 12 | 1.2% | PASS | `specimen-0034.eml` |
| 40 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 11 | 1.1% | PASS | `specimen-0040.eml` |
| 72 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 11 | 1.1% | PASS | `specimen-0072.eml` |
| 37 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 10 | 1.0% | PASS | `specimen-0037.eml` |
| 27 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 9 | 0.9% | PASS | `specimen-0027.eml` |
| 84 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 9 | 0.9% | PASS | `specimen-0084.eml` |
| 29 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 8 | 0.8% | PASS | `specimen-0029.eml` |
| 7 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 7 | 0.7% | PASS | `specimen-0007.eml` |
| 26 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 7 | 0.7% | PASS | `specimen-0026.eml` |
| 51 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 7 | 0.7% | PASS | `specimen-0051.eml` |
| 101 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 7 | 0.7% | PASS | `specimen-0101.eml` |
| 89 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0089.eml` |
| 128 | Unknown | New | `multipart/mixed(text/html+image/jpeg)` | none | - | 6 | 0.6% | PASS | `specimen-0128.eml` |
| 3 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 5 | 0.5% | PASS | `specimen-0003.eml` |
| 12 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 5 | 0.5% | PASS | `specimen-0012.eml` |
| 19 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0019.eml` |
| 23 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0023.eml` |
| 65 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 5 | 0.5% | PASS | `specimen-0065.eml` |
| 83 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0083.eml` |
| 94 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0094.eml` |
| 152 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 5 | 0.5% | PASS | `specimen-0152.eml` |
| 31 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 4 | 0.4% | PASS | `specimen-0031.eml` |
| 35 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0035.eml` |
| 55 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 4 | 0.4% | PASS | `specimen-0055.eml` |
| 67 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0067.eml` |
| 68 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0068.eml` |
| 82 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0082.eml` |
| 125 | Unknown | New | `text/html` | none | - | 4 | 0.4% | PASS | `specimen-0125.eml` |
| 137 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0137.eml` |
| 28 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0028.eml` |
| 41 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0041.eml` |
| 52 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0052.eml` |
| 54 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | OWA-AppendOnSend | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0054.eml` |
| 73 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0073.eml` |
| 74 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0074.eml` |
| 80 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0080.eml` |
| 120 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0120.eml` |
| 142 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 3 | 0.3% | PASS | `specimen-0142.eml` |
| 146 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0146.eml` |
| 166 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0166.eml` |
| 10 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0010.eml` |
| 20 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0020.eml` |
| 21 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0021.eml` |
| 30 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0030.eml` |
| 32 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0032.eml` |
| 64 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0064.eml` |
| 69 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0069.eml` |
| 75 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0075.eml` |
| 76 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0076.eml` |
| 85 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0085.eml` |
| 87 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0087.eml` |
| 95 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0095.eml` |
| 105 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0105.eml` |
| 111 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0111.eml` |
| 116 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0116.eml` |
| 124 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0124.eml` |
| 126 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0126.eml` |
| 127 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0127.eml` |
| 130 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0130.eml` |
| 135 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0135.eml` |
| 141 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0141.eml` |
| 144 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0144.eml` |
| 147 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0147.eml` |
| 151 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 2 | 0.2% | PASS | `specimen-0151.eml` |
| 153 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0153.eml` |
| 164 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0164.eml` |
| 182 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0182.eml` |
| 184 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0184.eml` |
| 188 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0188.eml` |
| 195 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0195.eml` |
| 8 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0008.eml` |
| 9 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0009.eml` |
| 11 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0011.eml` |
| 14 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0014.eml` |
| 15 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0015.eml` |
| 24 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0024.eml` |
| 36 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 38 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0038.eml` |
| 39 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0039.eml` |
| 44 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0044.eml` |
| 45 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0045.eml` |
| 47 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0047.eml` |
| 48 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0048.eml` |
| 49 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 50 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0050.eml` |
| 56 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0056.eml` |
| 57 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 59 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 61 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 63 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 66 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0066.eml` |
| 70 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0070.eml` |
| 71 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0071.eml` |
| 77 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0077.eml` |
| 78 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0078.eml` |
| 79 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0079.eml` |
| 81 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 86 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0086.eml` |
| 88 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0088.eml` |
| 90 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0090.eml` |
| 91 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 92 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 96 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0096.eml` |
| 97 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0097.eml` |
| 98 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0098.eml` |
| 99 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 100 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 102 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 103 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0103.eml` |
| 104 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 106 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0106.eml` |
| 107 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 108 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 109 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0109.eml` |
| 110 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 112 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0112.eml` |
| 113 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 114 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0114.eml` |
| 115 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0115.eml` |
| 117 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 118 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0118.eml` |
| 119 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0119.eml` |
| 121 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 122 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0122.eml` |
| 123 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0123.eml` |
| 129 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0129.eml` |
| 131 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0131.eml` |
| 132 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 133 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 134 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 136 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0136.eml` |
| 138 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 139 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0139.eml` |
| 140 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0140.eml` |
| 143 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0143.eml` |
| 145 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0145.eml` |
| 148 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0148.eml` |
| 149 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0149.eml` |
| 150 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0150.eml` |
| 154 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0154.eml` |
| 155 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0155.eml` |
| 156 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0156.eml` |
| 157 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0157.eml` |
| 158 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0158.eml` |
| 159 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0159.eml` |
| 160 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0160.eml` |
| 161 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0161.eml` |
| 162 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0162.eml` |
| 163 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0163.eml` |
| 165 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0165.eml` |
| 167 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0167.eml` |
| 168 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0168.eml` |
| 169 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0169.eml` |
| 170 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0170.eml` |
| 171 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0171.eml` |
| 172 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0172.eml` |
| 173 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0173.eml` |
| 174 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0174.eml` |
| 175 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0175.eml` |
| 176 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0176.eml` |
| 177 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0177.eml` |
| 178 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0178.eml` |
| 179 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0179.eml` |
| 180 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0180.eml` |
| 181 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0181.eml` |
| 183 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0183.eml` |
| 185 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0185.eml` |
| 186 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0186.eml` |
| 187 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0187.eml` |
| 189 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0189.eml` |
| 190 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0190.eml` |
| 191 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0191.eml` |
| 192 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0192.eml` |
| 193 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0193.eml` |
| 194 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0194.eml` |
| 196 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0196.eml` |
| 197 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0197.eml` |
| 198 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0198.eml` |
