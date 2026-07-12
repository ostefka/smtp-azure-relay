# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:28:51 UTC  
**Mailbox:** jiri.urbanek@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:03:03  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 236 |
| Duplicates skipped | 764 |
| Encrypted (skipped) | 0 |
| Injection PASS | 236 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 584 | 58.4% |
| Unknown | 413 | 41.3% |
| Outlook-Mac | 2 | 0.2% |
| Other | 1 | 0.1% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 752 | 75.2% |
| Reply | 201 | 20.1% |
| Forward | 47 | 4.7% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| Outlook-BorderTop | 97 | 9.7% |
| Outlook-divRplyFwdMsg | 32 | 3.2% |
| OWA-AppendOnSend | 27 | 2.7% |
| OriginalMessage-Text | 6 | 0.6% |
| Gmail-Quote | 6 | 0.6% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 57 | 296 |
| `text/html` | 8 | 222 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 14 | 153 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 62 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 18 | 28 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 6 | 21 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 11 | 18 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg))` | 1 | 16 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 5 | 15 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 10 | 12 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 11 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/csv)` | 2 | 11 |
| `multipart/alternative(text/plain+text/calendar)` | 2 | 10 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 5 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 5 | 6 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 4 | 5 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 3 | 5 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 4 |
| `multipart/report(multipart/alternative(text/plain+text/html)+message/delivery-status+message/rfc822)` | 2 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png+image/png+image/png)` | 1 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png)` | 1 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png)` | 1 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 3 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/zip)` | 1 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/alternative(multipart/related(text/html+image/png+image/png))` | 1 | 2 |
| `multipart/mixed(text/plain+application/octet-stream)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/alternative(text/plain+multipart/related(text/html+image/jpeg))` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/pdf)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream+application/octet-stream)` | 2 | 2 |
| `multipart/alternative(multipart/related(text/html+image/png))` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+image/png)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/rtf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `text/plain` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(text/html+image/png+image/Png+image/png)` | 1 | 1 |
| `multipart/related(text/html+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(text/html+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg)+application/x-mspublisher)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+text/plain)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/alternative(multipart/related(text/html+image/png+image/png+image/png))` | 1 | 1 |
| `multipart/alternative(text/plain+multipart/related(text/html+image/png))` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html+text/calendar)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/msword+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/msword+application/msword+application/msword)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/gif)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+application/ics)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #93** — Exchange-Server / Reply (12 msgs, 1.2%) — `specimen-0093.eml`
- **Pattern #16** — Exchange-Server / Reply (11 msgs, 1.1%) — `specimen-0016.eml`
- **Pattern #97** — Exchange-Server / Reply (4 msgs, 0.4%) — `specimen-0097.eml`
- **Pattern #62** — Exchange-Server / Forward (3 msgs, 0.3%) — `specimen-0062.eml`
- **Pattern #184** — Exchange-Server / Reply (3 msgs, 0.3%) — `specimen-0184.eml`
- **Pattern #96** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0096.eml`
- **Pattern #122** — Outlook-Mac / Reply (2 msgs, 0.2%) — `specimen-0122.eml`
- **Pattern #128** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0128.eml`
- **Pattern #172** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0172.eml`
- **Pattern #211** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0211.eml`
- **Pattern #212** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0212.eml`
- **Pattern #25** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0025.eml`
- **Pattern #74** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0074.eml`
- **Pattern #110** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0110.eml`
- **Pattern #113** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0113.eml`
- **Pattern #126** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0126.eml`
- **Pattern #132** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0132.eml`
- **Pattern #133** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0133.eml`
- **Pattern #134** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0134.eml`
- **Pattern #139** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0139.eml`
- **Pattern #142** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0142.eml`
- **Pattern #143** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0143.eml`
- **Pattern #146** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0146.eml`
- **Pattern #150** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0150.eml`
- **Pattern #157** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0157.eml`
- **Pattern #159** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0159.eml`
- **Pattern #168** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0168.eml`
- **Pattern #170** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0170.eml`
- **Pattern #174** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0174.eml`
- **Pattern #177** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0177.eml`
- **Pattern #193** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0193.eml`
- **Pattern #196** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0196.eml`
- **Pattern #197** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0197.eml`
- **Pattern #199** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0199.eml`
- **Pattern #201** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0201.eml`
- **Pattern #202** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0202.eml`
- **Pattern #204** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0204.eml`
- **Pattern #207** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0207.eml`
- **Pattern #209** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0209.eml`
- **Pattern #217** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0217.eml`
- **Pattern #220** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0220.eml`
- **Pattern #225** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0225.eml`
- **Pattern #226** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0226.eml`
- **Pattern #229** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0229.eml`
- **Pattern #233** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0233.eml`
- **Pattern #236** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0236.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 81 | Unknown | New | `text/html` | none | - | 191 | 19.1% | PASS | `specimen-0081.eml` |
| 3 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 78 | 7.8% | PASS | `specimen-0003.eml` |
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 72 | 7.2% | PASS | `specimen-0001.eml` |
| 83 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 62 | 6.2% | PASS | `specimen-0083.eml` |
| 2 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 50 | 5.0% | PASS | `specimen-0002.eml` |
| 89 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 35 | 3.5% | PASS | `specimen-0089.eml` |
| 84 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 21 | 2.1% | PASS | `specimen-0084.eml` |
| 140 | Unknown | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 16 | 1.6% | PASS | `specimen-0140.eml` |
| 27 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 13 | 1.3% | PASS | `specimen-0027.eml` |
| 93 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 12 | 1.2% | PASS | `specimen-0093.eml` |
| 16 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 11 | 1.1% | PASS | `specimen-0016.eml` |
| 44 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 11 | 1.1% | PASS | `specimen-0044.eml` |
| 114 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 11 | 1.1% | PASS | `specimen-0114.eml` |
| 187 | Unknown | New | `text/html` | none | - | 11 | 1.1% | PASS | `specimen-0187.eml` |
| 90 | Unknown | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 10 | 1.0% | PASS | `specimen-0090.eml` |
| 76 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 9 | 0.9% | PASS | `specimen-0076.eml` |
| 87 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 9 | 0.9% | PASS | `specimen-0087.eml` |
| 15 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 8 | 0.8% | PASS | `specimen-0015.eml` |
| 86 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 8 | 0.8% | PASS | `specimen-0086.eml` |
| 116 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 8 | 0.8% | PASS | `specimen-0116.eml` |
| 119 | Unknown | New | `text/html` | none | - | 8 | 0.8% | PASS | `specimen-0119.eml` |
| 4 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 7 | 0.7% | PASS | `specimen-0004.eml` |
| 85 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 7 | 0.7% | PASS | `specimen-0085.eml` |
| 5 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 6 | 0.6% | PASS | `specimen-0005.eml` |
| 17 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 6 | 0.6% | PASS | `specimen-0017.eml` |
| 20 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 6 | 0.6% | PASS | `specimen-0020.eml` |
| 31 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 6 | 0.6% | PASS | `specimen-0031.eml` |
| 158 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 6 | 0.6% | PASS | `specimen-0158.eml` |
| 37 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 5 | 0.5% | PASS | `specimen-0037.eml` |
| 80 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0080.eml` |
| 92 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 5 | 0.5% | PASS | `specimen-0092.eml` |
| 21 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 4 | 0.4% | PASS | `specimen-0021.eml` |
| 24 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 4 | 0.4% | PASS | `specimen-0024.eml` |
| 40 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0040.eml` |
| 88 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 4 | 0.4% | PASS | `specimen-0088.eml` |
| 97 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 4 | 0.4% | PASS | `specimen-0097.eml` |
| 100 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 4 | 0.4% | PASS | `specimen-0100.eml` |
| 182 | Unknown | Reply | `text/html` | OriginalMessage-Text | OWA-Signature | 4 | 0.4% | PASS | `specimen-0182.eml` |
| 7 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 3 | 0.3% | PASS | `specimen-0007.eml` |
| 19 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0019.eml` |
| 28 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0028.eml` |
| 46 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0046.eml` |
| 53 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0053.eml` |
| 62 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0062.eml` |
| 71 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0071.eml` |
| 105 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0105.eml` |
| 109 | Unknown | New | `text/html` | none | - | 3 | 0.3% | PASS | `specimen-0109.eml` |
| 123 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0123.eml` |
| 127 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0127.eml` |
| 165 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0165.eml` |
| 181 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0181.eml` |
| 184 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0184.eml` |
| 185 | Unknown | New | `text/html` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0185.eml` |
| 218 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | Gmail-Quote | - | 3 | 0.3% | PASS | `specimen-0218.eml` |
| 8 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0008.eml` |
| 9 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0009.eml` |
| 10 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0010.eml` |
| 13 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0013.eml` |
| 14 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0014.eml` |
| 30 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0030.eml` |
| 45 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0045.eml` |
| 47 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 2 | 0.2% | PASS | `specimen-0047.eml` |
| 56 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0056.eml` |
| 69 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0069.eml` |
| 77 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0077.eml` |
| 82 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0082.eml` |
| 96 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0096.eml` |
| 98 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0098.eml` |
| 103 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 2 | 0.2% | PASS | `specimen-0103.eml` |
| 115 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | Gmail-Quote | - | 2 | 0.2% | PASS | `specimen-0115.eml` |
| 118 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0118.eml` |
| 122 | Outlook-Mac | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0122.eml` |
| 128 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0128.eml` |
| 136 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0136.eml` |
| 145 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0145.eml` |
| 172 | Exchange-Server | Reply | `multipart/report(multipart/alternative(text/plain+text/ht...` | none | - | 2 | 0.2% | PASS | `specimen-0172.eml` |
| 180 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0180.eml` |
| 189 | Unknown | New | `multipart/alternative(multipart/related(text/html+image/p...` | none | - | 2 | 0.2% | PASS | `specimen-0189.eml` |
| 205 | Unknown | New | `multipart/mixed(text/plain+application/octet-stream)` | none | - | 2 | 0.2% | PASS | `specimen-0205.eml` |
| 211 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0211.eml` |
| 212 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0212.eml` |
| 223 | Exchange-Server | New | `multipart/report(multipart/alternative(text/plain+text/ht...` | none | - | 2 | 0.2% | PASS | `specimen-0223.eml` |
| 228 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0228.eml` |
| 6 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0006.eml` |
| 11 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0011.eml` |
| 12 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0012.eml` |
| 18 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0018.eml` |
| 22 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0022.eml` |
| 23 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0023.eml` |
| 25 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0025.eml` |
| 26 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0026.eml` |
| 29 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0029.eml` |
| 32 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0032.eml` |
| 33 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0033.eml` |
| 34 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0034.eml` |
| 35 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 38 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0038.eml` |
| 39 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0039.eml` |
| 41 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0041.eml` |
| 42 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0042.eml` |
| 43 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0043.eml` |
| 48 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0048.eml` |
| 49 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 50 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0050.eml` |
| 51 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0051.eml` |
| 52 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 54 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 57 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 58 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0058.eml` |
| 59 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 61 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 63 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 64 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0064.eml` |
| 65 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 66 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0066.eml` |
| 67 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0067.eml` |
| 68 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 70 | Exchange-Server | New | `text/plain` | none | - | 1 | 0.1% | PASS | `specimen-0070.eml` |
| 72 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0072.eml` |
| 73 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0073.eml` |
| 74 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0074.eml` |
| 75 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0075.eml` |
| 78 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0078.eml` |
| 79 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0079.eml` |
| 91 | Unknown | New | `multipart/related(text/html+image/png+image/Png+image/png)` | none | - | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 94 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 95 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0095.eml` |
| 99 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png)` | none | - | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 101 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0101.eml` |
| 102 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 104 | Unknown | New | `multipart/related(text/html+image/png+image/png)` | none | - | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 106 | Exchange-Server | New | `multipart/alternative(text/plain+multipart/related(text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0106.eml` |
| 107 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 108 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 110 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 111 | Unknown | New | `text/html` | none | - | 1 | 0.1% | PASS | `specimen-0111.eml` |
| 112 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0112.eml` |
| 113 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 117 | Exchange-Server | New | `multipart/alternative(text/plain+multipart/related(text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 120 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | Gmail-signature | 1 | 0.1% | PASS | `specimen-0120.eml` |
| 121 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 124 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0124.eml` |
| 125 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0125.eml` |
| 126 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 129 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0129.eml` |
| 130 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0130.eml` |
| 131 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0131.eml` |
| 132 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 133 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 134 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 135 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0135.eml` |
| 137 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 139 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0139.eml` |
| 141 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 143 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0143.eml` |
| 144 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0144.eml` |
| 146 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0146.eml` |
| 147 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0147.eml` |
| 148 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0148.eml` |
| 149 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0149.eml` |
| 150 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0150.eml` |
| 151 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0151.eml` |
| 152 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0152.eml` |
| 153 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0153.eml` |
| 154 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0154.eml` |
| 155 | Other | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0155.eml` |
| 156 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0156.eml` |
| 157 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0157.eml` |
| 159 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0159.eml` |
| 160 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0160.eml` |
| 161 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0161.eml` |
| 162 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Gmail-Quote | - | 1 | 0.1% | PASS | `specimen-0162.eml` |
| 163 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0163.eml` |
| 164 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0164.eml` |
| 166 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0166.eml` |
| 167 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0167.eml` |
| 168 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0168.eml` |
| 169 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0169.eml` |
| 170 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0170.eml` |
| 171 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0171.eml` |
| 173 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0173.eml` |
| 174 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0174.eml` |
| 175 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0175.eml` |
| 176 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0176.eml` |
| 177 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0177.eml` |
| 178 | Unknown | New | `multipart/alternative(multipart/related(text/html+image/p...` | none | - | 1 | 0.1% | PASS | `specimen-0178.eml` |
| 179 | Unknown | Reply | `text/html` | OriginalMessage-Text | OWA-Signature | 1 | 0.1% | PASS | `specimen-0179.eml` |
| 183 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0183.eml` |
| 186 | Unknown | Reply | `multipart/alternative(multipart/related(text/html+image/p...` | OriginalMessage-Text | OWA-Signature | 1 | 0.1% | PASS | `specimen-0186.eml` |
| 188 | Unknown | New | `multipart/alternative(multipart/related(text/html+image/p...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0188.eml` |
| 190 | Exchange-Server | Reply | `multipart/alternative(text/plain+multipart/related(text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0190.eml` |
| 191 | Unknown | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0191.eml` |
| 192 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0192.eml` |
| 193 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0193.eml` |
| 194 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0194.eml` |
| 195 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0195.eml` |
| 196 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0196.eml` |
| 197 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0197.eml` |
| 198 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0198.eml` |
| 199 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0199.eml` |
| 200 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0200.eml` |
| 201 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0201.eml` |
| 202 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0202.eml` |
| 203 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0203.eml` |
| 204 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0204.eml` |
| 206 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0206.eml` |
| 207 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0207.eml` |
| 208 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0208.eml` |
| 209 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0209.eml` |
| 210 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0210.eml` |
| 213 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0213.eml` |
| 214 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0214.eml` |
| 215 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0215.eml` |
| 216 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0216.eml` |
| 217 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0217.eml` |
| 219 | Unknown | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0219.eml` |
| 220 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0220.eml` |
| 221 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0221.eml` |
| 222 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0222.eml` |
| 224 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0224.eml` |
| 225 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0225.eml` |
| 226 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0226.eml` |
| 227 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0227.eml` |
| 229 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0229.eml` |
| 230 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0230.eml` |
| 231 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0231.eml` |
| 232 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | sigdash-lf | 1 | 0.1% | PASS | `specimen-0232.eml` |
| 233 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0233.eml` |
| 234 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0234.eml` |
| 235 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0235.eml` |
| 236 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0236.eml` |
