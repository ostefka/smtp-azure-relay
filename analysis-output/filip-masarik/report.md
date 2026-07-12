# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:34:38 UTC  
**Mailbox:** filip.masarik@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:03:16  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 171 |
| Duplicates skipped | 829 |
| Encrypted (skipped) | 0 |
| Injection PASS | 171 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Unknown | 537 | 53.7% |
| Exchange-Server | 453 | 45.3% |
| Other | 9 | 0.9% |
| Outlook-Mac | 1 | 0.1% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 488 | 48.8% |
| Reply | 470 | 47.0% |
| Forward | 42 | 4.2% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 48 | 4.8% |
| Outlook-BorderTop | 14 | 1.4% |
| Outlook-divRplyFwdMsg | 6 | 0.6% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 48 | 444 |
| `text/html` | 2 | 205 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 14 | 77 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 14 | 38 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 10 | 35 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 34 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 6 | 27 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf)` | 2 | 16 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png)` | 3 | 16 |
| `multipart/related(text/html+image/png+image/png+image/png)` | 1 | 9 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf)` | 3 | 9 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 8 |
| `multipart/alternative(text/plain+text/calendar)` | 2 | 7 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 2 | 5 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822+image/jpeg)` | 2 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 5 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 4 | 4 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream)` | 3 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 3 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-pkcs12)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+image/png)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf)` | 2 | 2 |
| `multipart/alternative(text/html)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html+text/calendar)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream+application/octet-stream)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/xml)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #108** — Unknown / Reply (196 msgs, 19.6%) — `specimen-0108.eml`
- **Pattern #48** — Unknown / Reply (87 msgs, 8.7%) — `specimen-0048.eml`
- **Pattern #59** — Unknown / Reply (62 msgs, 6.2%) — `specimen-0059.eml`
- **Pattern #77** — Unknown / Reply (26 msgs, 2.6%) — `specimen-0077.eml`
- **Pattern #57** — Unknown / Reply (9 msgs, 0.9%) — `specimen-0057.eml`
- **Pattern #115** — Exchange-Server / Reply (8 msgs, 0.8%) — `specimen-0115.eml`
- **Pattern #51** — Unknown / Reply (5 msgs, 0.5%) — `specimen-0051.eml`
- **Pattern #127** — Exchange-Server / Reply (5 msgs, 0.5%) — `specimen-0127.eml`
- **Pattern #32** — Exchange-Server / Forward (4 msgs, 0.4%) — `specimen-0032.eml`
- **Pattern #47** — Unknown / Reply (4 msgs, 0.4%) — `specimen-0047.eml`
- **Pattern #54** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0054.eml`
- **Pattern #55** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0055.eml`
- **Pattern #156** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0156.eml`
- **Pattern #36** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0036.eml`
- **Pattern #37** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0037.eml`
- **Pattern #39** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0039.eml`
- **Pattern #49** — Unknown / Reply (1 msgs, 0.1%) — `specimen-0049.eml`
- **Pattern #50** — Unknown / Reply (1 msgs, 0.1%) — `specimen-0050.eml`
- **Pattern #53** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0053.eml`
- **Pattern #63** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0063.eml`
- **Pattern #67** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0067.eml`
- **Pattern #71** — Unknown / Reply (1 msgs, 0.1%) — `specimen-0071.eml`
- **Pattern #75** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0075.eml`
- **Pattern #78** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0078.eml`
- **Pattern #79** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0079.eml`
- **Pattern #81** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0081.eml`
- **Pattern #82** — Outlook-Mac / Reply (1 msgs, 0.1%) — `specimen-0082.eml`
- **Pattern #99** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0099.eml`
- **Pattern #114** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0114.eml`
- **Pattern #117** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0117.eml`
- **Pattern #118** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0118.eml`
- **Pattern #119** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0119.eml`
- **Pattern #123** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0123.eml`
- **Pattern #124** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0124.eml`
- **Pattern #130** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0130.eml`
- **Pattern #137** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0137.eml`
- **Pattern #140** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0140.eml`
- **Pattern #143** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0143.eml`
- **Pattern #151** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0151.eml`
- **Pattern #154** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0154.eml`
- **Pattern #158** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0158.eml`
- **Pattern #161** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0161.eml`
- **Pattern #163** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0163.eml`
- **Pattern #167** — Unknown / Reply (1 msgs, 0.1%) — `specimen-0167.eml`
- **Pattern #171** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0171.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 108 | Unknown | Reply | `text/html` | none | - | 196 | 19.6% | PASS | `specimen-0108.eml` |
| 48 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 87 | 8.7% | PASS | `specimen-0048.eml` |
| 8 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 86 | 8.6% | PASS | `specimen-0008.eml` |
| 59 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 62 | 6.2% | PASS | `specimen-0059.eml` |
| 60 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 35 | 3.5% | PASS | `specimen-0060.eml` |
| 46 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 34 | 3.4% | PASS | `specimen-0046.eml` |
| 96 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 29 | 2.9% | PASS | `specimen-0096.eml` |
| 56 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 26 | 2.6% | PASS | `specimen-0056.eml` |
| 77 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 26 | 2.6% | PASS | `specimen-0077.eml` |
| 28 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 21 | 2.1% | PASS | `specimen-0028.eml` |
| 20 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 17 | 1.7% | PASS | `specimen-0020.eml` |
| 12 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 13 | 1.3% | PASS | `specimen-0012.eml` |
| 65 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 13 | 1.3% | PASS | `specimen-0065.eml` |
| 25 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 12 | 1.2% | PASS | `specimen-0025.eml` |
| 58 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 11 | 1.1% | PASS | `specimen-0058.eml` |
| 10 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 9 | 0.9% | PASS | `specimen-0010.eml` |
| 52 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 9 | 0.9% | PASS | `specimen-0052.eml` |
| 57 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 9 | 0.9% | PASS | `specimen-0057.eml` |
| 95 | Unknown | New | `text/html` | none | - | 9 | 0.9% | PASS | `specimen-0095.eml` |
| 98 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png)` | none | - | 9 | 0.9% | PASS | `specimen-0098.eml` |
| 3 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 8 | 0.8% | PASS | `specimen-0003.eml` |
| 72 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 8 | 0.8% | PASS | `specimen-0072.eml` |
| 115 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 8 | 0.8% | PASS | `specimen-0115.eml` |
| 2 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 7 | 0.7% | PASS | `specimen-0002.eml` |
| 31 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 7 | 0.7% | PASS | `specimen-0031.eml` |
| 4 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 6 | 0.6% | PASS | `specimen-0004.eml` |
| 19 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0019.eml` |
| 16 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 5 | 0.5% | PASS | `specimen-0016.eml` |
| 51 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 5 | 0.5% | PASS | `specimen-0051.eml` |
| 69 | Other | New | `multipart/alternative(text/plain+text/html)` | none | - | 5 | 0.5% | PASS | `specimen-0069.eml` |
| 80 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 5 | 0.5% | PASS | `specimen-0080.eml` |
| 102 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 5 | 0.5% | PASS | `specimen-0102.eml` |
| 106 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 5 | 0.5% | PASS | `specimen-0106.eml` |
| 127 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 5 | 0.5% | PASS | `specimen-0127.eml` |
| 7 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 4 | 0.4% | PASS | `specimen-0007.eml` |
| 21 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 4 | 0.4% | PASS | `specimen-0021.eml` |
| 30 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 4 | 0.4% | PASS | `specimen-0030.eml` |
| 32 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0032.eml` |
| 47 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 4 | 0.4% | PASS | `specimen-0047.eml` |
| 68 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0068.eml` |
| 85 | Other | New | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0085.eml` |
| 87 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 4 | 0.4% | PASS | `specimen-0087.eml` |
| 88 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 4 | 0.4% | PASS | `specimen-0088.eml` |
| 5 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 3 | 0.3% | PASS | `specimen-0005.eml` |
| 14 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0014.eml` |
| 17 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 3 | 0.3% | PASS | `specimen-0017.eml` |
| 18 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0018.eml` |
| 22 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0022.eml` |
| 27 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0027.eml` |
| 33 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0033.eml` |
| 64 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0064.eml` |
| 70 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 3 | 0.3% | PASS | `specimen-0070.eml` |
| 121 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0121.eml` |
| 11 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0011.eml` |
| 13 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0013.eml` |
| 23 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0023.eml` |
| 26 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0026.eml` |
| 29 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0029.eml` |
| 42 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 2 | 0.2% | PASS | `specimen-0042.eml` |
| 54 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0055.eml` |
| 74 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0074.eml` |
| 86 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0086.eml` |
| 111 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0111.eml` |
| 128 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0128.eml` |
| 129 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0129.eml` |
| 133 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0133.eml` |
| 155 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 2 | 0.2% | PASS | `specimen-0155.eml` |
| 156 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0156.eml` |
| 157 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0157.eml` |
| 170 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0170.eml` |
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0001.eml` |
| 6 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0006.eml` |
| 9 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0009.eml` |
| 15 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0015.eml` |
| 24 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0024.eml` |
| 34 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0034.eml` |
| 35 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 37 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0037.eml` |
| 38 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0038.eml` |
| 39 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0039.eml` |
| 40 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0040.eml` |
| 41 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0041.eml` |
| 43 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0043.eml` |
| 44 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0044.eml` |
| 45 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0045.eml` |
| 49 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 50 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0050.eml` |
| 53 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0053.eml` |
| 61 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 63 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 66 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0066.eml` |
| 67 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0067.eml` |
| 71 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0071.eml` |
| 73 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0073.eml` |
| 75 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0075.eml` |
| 76 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0076.eml` |
| 78 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0078.eml` |
| 79 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0079.eml` |
| 81 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 82 | Outlook-Mac | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0082.eml` |
| 83 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0083.eml` |
| 84 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0084.eml` |
| 89 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 90 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0090.eml` |
| 91 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 92 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 94 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 97 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0097.eml` |
| 99 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 100 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 101 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0101.eml` |
| 103 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0103.eml` |
| 104 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 105 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 107 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 109 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0109.eml` |
| 110 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 112 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0112.eml` |
| 113 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 114 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0114.eml` |
| 116 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0116.eml` |
| 117 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 118 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0118.eml` |
| 119 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0119.eml` |
| 120 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0120.eml` |
| 122 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0122.eml` |
| 123 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0123.eml` |
| 124 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0124.eml` |
| 125 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0125.eml` |
| 126 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 130 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0130.eml` |
| 131 | Unknown | New | `multipart/alternative(text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0131.eml` |
| 132 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 134 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 135 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0135.eml` |
| 136 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0136.eml` |
| 137 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 139 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0139.eml` |
| 140 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0140.eml` |
| 141 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 143 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0143.eml` |
| 144 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0144.eml` |
| 145 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0145.eml` |
| 146 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0146.eml` |
| 147 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0147.eml` |
| 148 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0148.eml` |
| 149 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0149.eml` |
| 150 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0150.eml` |
| 151 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0151.eml` |
| 152 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0152.eml` |
| 153 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0153.eml` |
| 154 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0154.eml` |
| 158 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0158.eml` |
| 159 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0159.eml` |
| 160 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0160.eml` |
| 161 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0161.eml` |
| 162 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0162.eml` |
| 163 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0163.eml` |
| 164 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0164.eml` |
| 165 | Unknown | New | `multipart/alternative(text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0165.eml` |
| 166 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0166.eml` |
| 167 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0167.eml` |
| 168 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0168.eml` |
| 169 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0169.eml` |
| 171 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0171.eml` |
