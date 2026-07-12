# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:31:13 UTC  
**Mailbox:** petr.vysokomensky@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:02:11  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 164 |
| Duplicates skipped | 836 |
| Encrypted (skipped) | 0 |
| Injection PASS | 164 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Unknown | 602 | 60.2% |
| Exchange-Server | 393 | 39.3% |
| Other | 3 | 0.3% |
| Outlook-Mac | 2 | 0.2% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 692 | 69.2% |
| Reply | 275 | 27.5% |
| Forward | 33 | 3.3% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| Outlook-BorderTop | 68 | 6.8% |
| Outlook-divRplyFwdMsg | 37 | 3.7% |
| OWA-AppendOnSend | 7 | 0.7% |
| Gmail-Quote | 2 | 0.2% |
| Outlook-OriginalMessage | 1 | 0.1% |
| Generic-BlockquoteCite | 1 | 0.1% |
| OriginalMessage-Text | 1 | 0.1% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 45 | 281 |
| `text/html` | 11 | 269 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 11 | 133 |
| `multipart/mixed(text/html)` | 1 | 89 |
| `multipart/related(text/html+image/jpeg)` | 1 | 59 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 14 | 30 |
| `multipart/alternative(text/plain+text/calendar)` | 2 | 23 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 5 | 10 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg))` | 1 | 9 |
| `text/plain` | 2 | 9 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 4 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 4 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 5 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png)` | 1 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 3 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 3 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png)` | 1 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/mixed(text/plain+application/octet-stream)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/alternative(text/plain+multipart/related(text/html+image/jpeg))` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-zip-compressed)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg)+application/x-mspublisher)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(text/html+image/jpeg)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/msword)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+application/pdf)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #68** — Unknown / Reply (59 msgs, 5.9%) — `specimen-0068.eml`
- **Pattern #69** — Unknown / Reply (49 msgs, 4.9%) — `specimen-0069.eml`
- **Pattern #136** — Unknown / Reply (24 msgs, 2.4%) — `specimen-0136.eml`
- **Pattern #3** — Exchange-Server / Reply (9 msgs, 0.9%) — `specimen-0003.eml`
- **Pattern #78** — Exchange-Server / Reply (8 msgs, 0.8%) — `specimen-0078.eml`
- **Pattern #7** — Exchange-Server / Reply (7 msgs, 0.7%) — `specimen-0007.eml`
- **Pattern #75** — Unknown / Reply (7 msgs, 0.7%) — `specimen-0075.eml`
- **Pattern #82** — Exchange-Server / Reply (3 msgs, 0.3%) — `specimen-0082.eml`
- **Pattern #4** — Exchange-Server / Forward (2 msgs, 0.2%) — `specimen-0004.eml`
- **Pattern #11** — Exchange-Server / Forward (2 msgs, 0.2%) — `specimen-0011.eml`
- **Pattern #111** — Outlook-Mac / Reply (2 msgs, 0.2%) — `specimen-0111.eml`
- **Pattern #53** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0053.eml`
- **Pattern #57** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0057.eml`
- **Pattern #60** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0060.eml`
- **Pattern #100** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0100.eml`
- **Pattern #103** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0103.eml`
- **Pattern #115** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0115.eml`
- **Pattern #120** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0120.eml`
- **Pattern #126** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0126.eml`
- **Pattern #130** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0130.eml`
- **Pattern #131** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0131.eml`
- **Pattern #132** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0132.eml`
- **Pattern #135** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0135.eml`
- **Pattern #140** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0140.eml`
- **Pattern #141** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0141.eml`
- **Pattern #143** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0143.eml`
- **Pattern #148** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0148.eml`
- **Pattern #155** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0155.eml`
- **Pattern #159** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0159.eml`
- **Pattern #162** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0162.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 67 | Unknown | New | `text/html` | none | - | 129 | 12.9% | PASS | `specimen-0067.eml` |
| 64 | Unknown | New | `text/html` | none | - | 101 | 10.1% | PASS | `specimen-0064.eml` |
| 65 | Unknown | New | `multipart/mixed(text/html)` | none | - | 89 | 8.9% | PASS | `specimen-0065.eml` |
| 10 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 76 | 7.6% | PASS | `specimen-0010.eml` |
| 68 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 59 | 5.9% | PASS | `specimen-0068.eml` |
| 70 | Unknown | New | `multipart/related(text/html+image/jpeg)` | none | - | 59 | 5.9% | PASS | `specimen-0070.eml` |
| 69 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 49 | 4.9% | PASS | `specimen-0069.eml` |
| 9 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 29 | 2.9% | PASS | `specimen-0009.eml` |
| 136 | Unknown | Reply | `text/html` | none | - | 24 | 2.4% | PASS | `specimen-0136.eml` |
| 5 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 22 | 2.2% | PASS | `specimen-0005.eml` |
| 74 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 18 | 1.8% | PASS | `specimen-0074.eml` |
| 34 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 15 | 1.5% | PASS | `specimen-0034.eml` |
| 16 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 14 | 1.4% | PASS | `specimen-0016.eml` |
| 66 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 13 | 1.3% | PASS | `specimen-0066.eml` |
| 3 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 9 | 0.9% | PASS | `specimen-0003.eml` |
| 84 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 9 | 0.9% | PASS | `specimen-0084.eml` |
| 107 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 9 | 0.9% | PASS | `specimen-0107.eml` |
| 109 | Unknown | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 9 | 0.9% | PASS | `specimen-0109.eml` |
| 2 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 8 | 0.8% | PASS | `specimen-0002.eml` |
| 78 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 8 | 0.8% | PASS | `specimen-0078.eml` |
| 133 | Unknown | New | `text/plain` | none | - | 8 | 0.8% | PASS | `specimen-0133.eml` |
| 7 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 7 | 0.7% | PASS | `specimen-0007.eml` |
| 75 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 7 | 0.7% | PASS | `specimen-0075.eml` |
| 18 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 6 | 0.6% | PASS | `specimen-0018.eml` |
| 73 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 6 | 0.6% | PASS | `specimen-0073.eml` |
| 37 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 5 | 0.5% | PASS | `specimen-0037.eml` |
| 44 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 5 | 0.5% | PASS | `specimen-0044.eml` |
| 50 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 5 | 0.5% | PASS | `specimen-0050.eml` |
| 95 | Unknown | New | `text/html` | none | - | 5 | 0.5% | PASS | `specimen-0095.eml` |
| 104 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 5 | 0.5% | PASS | `specimen-0104.eml` |
| 6 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0006.eml` |
| 32 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0032.eml` |
| 41 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 4 | 0.4% | PASS | `specimen-0041.eml` |
| 72 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 4 | 0.4% | PASS | `specimen-0072.eml` |
| 90 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0090.eml` |
| 99 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 4 | 0.4% | PASS | `specimen-0099.eml` |
| 23 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0023.eml` |
| 43 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0043.eml` |
| 58 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0058.eml` |
| 61 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0061.eml` |
| 71 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 3 | 0.3% | PASS | `specimen-0071.eml` |
| 77 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0077.eml` |
| 82 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0082.eml` |
| 86 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 3 | 0.3% | PASS | `specimen-0086.eml` |
| 97 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0097.eml` |
| 147 | Unknown | New | `text/html` | none | - | 3 | 0.3% | PASS | `specimen-0147.eml` |
| 4 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0004.eml` |
| 11 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0011.eml` |
| 12 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0012.eml` |
| 14 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0014.eml` |
| 15 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0015.eml` |
| 17 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0017.eml` |
| 19 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 2 | 0.2% | PASS | `specimen-0019.eml` |
| 26 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0026.eml` |
| 35 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 2 | 0.2% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 2 | 0.2% | PASS | `specimen-0036.eml` |
| 42 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0042.eml` |
| 83 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0083.eml` |
| 88 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0088.eml` |
| 106 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0106.eml` |
| 111 | Outlook-Mac | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0111.eml` |
| 112 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0112.eml` |
| 114 | Unknown | New | `multipart/mixed(text/plain+application/octet-stream)` | none | - | 2 | 0.2% | PASS | `specimen-0114.eml` |
| 117 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0117.eml` |
| 118 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0118.eml` |
| 125 | Unknown | New | `text/html` | none | - | 2 | 0.2% | PASS | `specimen-0125.eml` |
| 1 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0001.eml` |
| 8 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0008.eml` |
| 13 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0013.eml` |
| 20 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0020.eml` |
| 21 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0021.eml` |
| 22 | Exchange-Server | Reply | `text/plain` | Outlook-OriginalMessage | - | 1 | 0.1% | PASS | `specimen-0022.eml` |
| 24 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0024.eml` |
| 25 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0025.eml` |
| 27 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0027.eml` |
| 28 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0028.eml` |
| 29 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0029.eml` |
| 30 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0030.eml` |
| 31 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0031.eml` |
| 33 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0033.eml` |
| 38 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0038.eml` |
| 39 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0039.eml` |
| 40 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0040.eml` |
| 45 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0045.eml` |
| 46 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0046.eml` |
| 47 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0047.eml` |
| 48 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0048.eml` |
| 49 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 51 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0051.eml` |
| 52 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 53 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0053.eml` |
| 54 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 56 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0056.eml` |
| 57 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 59 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 62 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 63 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 76 | Other | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0076.eml` |
| 79 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Gmail-Quote | - | 1 | 0.1% | PASS | `specimen-0079.eml` |
| 80 | Other | New | `text/html` | none | - | 1 | 0.1% | PASS | `specimen-0080.eml` |
| 81 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 85 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | Gmail-Quote | - | 1 | 0.1% | PASS | `specimen-0085.eml` |
| 87 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0087.eml` |
| 89 | Other | New | `text/html` | none | - | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 91 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 92 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | New | `multipart/alternative(text/plain+multipart/related(text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 94 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 96 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0096.eml` |
| 98 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0098.eml` |
| 100 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 101 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0101.eml` |
| 102 | Unknown | New | `text/html` | none | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 103 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0103.eml` |
| 105 | Exchange-Server | New | `multipart/alternative(text/plain+multipart/related(text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 108 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 110 | Unknown | New | `text/html` | none | - | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 113 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 115 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0115.eml` |
| 116 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0116.eml` |
| 119 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0119.eml` |
| 120 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0120.eml` |
| 121 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 122 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0122.eml` |
| 123 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0123.eml` |
| 124 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0124.eml` |
| 126 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 127 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 128 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0128.eml` |
| 129 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0129.eml` |
| 130 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0130.eml` |
| 131 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0131.eml` |
| 132 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 134 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 135 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0135.eml` |
| 137 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 139 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0139.eml` |
| 140 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0140.eml` |
| 141 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Unknown | New | `multipart/mixed(multipart/related(text/html+image/jpeg)+a...` | none | - | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 143 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0143.eml` |
| 144 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0144.eml` |
| 145 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0145.eml` |
| 146 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0146.eml` |
| 148 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0148.eml` |
| 149 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0149.eml` |
| 150 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0150.eml` |
| 151 | Unknown | New | `text/html` | none | - | 1 | 0.1% | PASS | `specimen-0151.eml` |
| 152 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0152.eml` |
| 153 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0153.eml` |
| 154 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0154.eml` |
| 155 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0155.eml` |
| 156 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Generic-BlockquoteCite | - | 1 | 0.1% | PASS | `specimen-0156.eml` |
| 157 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0157.eml` |
| 158 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0158.eml` |
| 159 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0159.eml` |
| 160 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0160.eml` |
| 161 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0161.eml` |
| 162 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0162.eml` |
| 163 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OriginalMessage-Text | OWA-Signature | 1 | 0.1% | PASS | `specimen-0163.eml` |
| 164 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0164.eml` |
