# Signature Injection Analysis Report

**Generated:** 2026-05-10 16:52:55 UTC  
**Mailbox:** miroslav.adamec@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:01:27  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 160 |
| Duplicates skipped | 840 |
| Encrypted (skipped) | 0 |
| Injection PASS | 160 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 996 | 99.6% |
| Unknown | 4 | 0.4% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 535 | 53.5% |
| Reply | 384 | 38.4% |
| Forward | 81 | 8.1% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| Outlook-BorderTop | 291 | 29.1% |
| Outlook-divRplyFwdMsg | 128 | 12.8% |
| OWA-AppendOnSend | 28 | 2.8% |
| Outlook-OriginalMessage | 6 | 0.6% |
| OriginalMessage-Text | 1 | 0.1% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html+text/calendar)` | 14 | 313 |
| `multipart/alternative(text/plain+text/html)` | 32 | 301 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 15 | 85 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 11 | 70 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 8 | 58 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 6 | 30 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 8 | 24 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 8 | 24 |
| `multipart/alternative(text/plain+text/calendar)` | 2 | 18 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 4 | 8 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf)` | 5 | 8 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 6 | 8 |
| `text/plain` | 3 | 6 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/png+image/jpeg)` | 2 | 4 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/octet-stream)` | 1 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/csv)` | 2 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/xml)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/gif+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+application/ics)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/plain)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/json)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg)+video/mp4)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)+video/mp4)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822+message/rfc822)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #2** — Exchange-Server / Forward (3 msgs, 0.3%) — `specimen-0002.eml`
- **Pattern #135** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0135.eml`
- **Pattern #5** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0005.eml`
- **Pattern #18** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0018.eml`
- **Pattern #20** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0020.eml`
- **Pattern #53** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0053.eml`
- **Pattern #60** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0060.eml`
- **Pattern #62** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0062.eml`
- **Pattern #72** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0072.eml`
- **Pattern #134** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0134.eml`
- **Pattern #154** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0154.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 3 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 116 | 11.6% | PASS | `specimen-0003.eml` |
| 42 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 93 | 9.3% | PASS | `specimen-0042.eml` |
| 43 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 59 | 5.9% | PASS | `specimen-0043.eml` |
| 33 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 57 | 5.7% | PASS | `specimen-0033.eml` |
| 4 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 55 | 5.5% | PASS | `specimen-0004.eml` |
| 41 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 43 | 4.3% | PASS | `specimen-0041.eml` |
| 27 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 39 | 3.9% | PASS | `specimen-0027.eml` |
| 29 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 32 | 3.2% | PASS | `specimen-0029.eml` |
| 13 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 28 | 2.8% | PASS | `specimen-0013.eml` |
| 73 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 22 | 2.2% | PASS | `specimen-0073.eml` |
| 7 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 20 | 2.0% | PASS | `specimen-0007.eml` |
| 37 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 20 | 2.0% | PASS | `specimen-0037.eml` |
| 57 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 20 | 2.0% | PASS | `specimen-0057.eml` |
| 26 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 17 | 1.7% | PASS | `specimen-0026.eml` |
| 10 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 15 | 1.5% | PASS | `specimen-0010.eml` |
| 34 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 15 | 1.5% | PASS | `specimen-0034.eml` |
| 47 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 15 | 1.5% | PASS | `specimen-0047.eml` |
| 69 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 15 | 1.5% | PASS | `specimen-0069.eml` |
| 11 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 12 | 1.2% | PASS | `specimen-0011.eml` |
| 51 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 10 | 1.0% | PASS | `specimen-0051.eml` |
| 96 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 10 | 1.0% | PASS | `specimen-0096.eml` |
| 130 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 10 | 1.0% | PASS | `specimen-0130.eml` |
| 80 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 9 | 0.9% | PASS | `specimen-0080.eml` |
| 31 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 8 | 0.8% | PASS | `specimen-0031.eml` |
| 74 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 8 | 0.8% | PASS | `specimen-0074.eml` |
| 75 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 8 | 0.8% | PASS | `specimen-0075.eml` |
| 79 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 8 | 0.8% | PASS | `specimen-0079.eml` |
| 12 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 6 | 0.6% | PASS | `specimen-0012.eml` |
| 19 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 6 | 0.6% | PASS | `specimen-0019.eml` |
| 119 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 6 | 0.6% | PASS | `specimen-0119.eml` |
| 17 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0017.eml` |
| 66 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 5 | 0.5% | PASS | `specimen-0066.eml` |
| 109 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 5 | 0.5% | PASS | `specimen-0109.eml` |
| 125 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 5 | 0.5% | PASS | `specimen-0125.eml` |
| 9 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 4 | 0.4% | PASS | `specimen-0009.eml` |
| 21 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 4 | 0.4% | PASS | `specimen-0021.eml` |
| 123 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0123.eml` |
| 124 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0124.eml` |
| 152 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0152.eml` |
| 2 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0002.eml` |
| 14 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0014.eml` |
| 67 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0067.eml` |
| 68 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0068.eml` |
| 71 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0071.eml` |
| 82 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0082.eml` |
| 83 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0083.eml` |
| 88 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0088.eml` |
| 91 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0091.eml` |
| 95 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0095.eml` |
| 97 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0097.eml` |
| 118 | Exchange-Server | Reply | `text/plain` | Outlook-OriginalMessage | - | 3 | 0.3% | PASS | `specimen-0118.eml` |
| 126 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0126.eml` |
| 132 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0132.eml` |
| 15 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0015.eml` |
| 22 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0022.eml` |
| 25 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0025.eml` |
| 36 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0036.eml` |
| 39 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0039.eml` |
| 40 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0040.eml` |
| 44 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0044.eml` |
| 49 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0049.eml` |
| 50 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0050.eml` |
| 56 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0056.eml` |
| 70 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0070.eml` |
| 76 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0076.eml` |
| 77 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0077.eml` |
| 81 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0081.eml` |
| 86 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0086.eml` |
| 90 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0090.eml` |
| 104 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0104.eml` |
| 106 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0106.eml` |
| 111 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0111.eml` |
| 115 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0115.eml` |
| 116 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0116.eml` |
| 122 | Exchange-Server | Reply | `text/plain` | Outlook-OriginalMessage | - | 2 | 0.2% | PASS | `specimen-0122.eml` |
| 129 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0129.eml` |
| 131 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0131.eml` |
| 135 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0135.eml` |
| 136 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0136.eml` |
| 143 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 2 | 0.2% | PASS | `specimen-0143.eml` |
| 148 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0148.eml` |
| 157 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0157.eml` |
| 1 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0001.eml` |
| 5 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0005.eml` |
| 6 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0006.eml` |
| 8 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 1 | 0.1% | PASS | `specimen-0008.eml` |
| 16 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0016.eml` |
| 18 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0018.eml` |
| 20 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0020.eml` |
| 23 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0023.eml` |
| 24 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0024.eml` |
| 28 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0028.eml` |
| 30 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0030.eml` |
| 32 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0032.eml` |
| 35 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0035.eml` |
| 38 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0038.eml` |
| 45 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0045.eml` |
| 46 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0046.eml` |
| 48 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0048.eml` |
| 52 | Exchange-Server | Forward | `text/plain` | Outlook-OriginalMessage | - | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 53 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0053.eml` |
| 54 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 58 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0058.eml` |
| 59 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 61 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 63 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 64 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0064.eml` |
| 65 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 72 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0072.eml` |
| 78 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0078.eml` |
| 84 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0084.eml` |
| 85 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0085.eml` |
| 87 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0087.eml` |
| 89 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 92 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 94 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 98 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0098.eml` |
| 99 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 100 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 101 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0101.eml` |
| 102 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 103 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0103.eml` |
| 105 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 107 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 108 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 110 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 112 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0112.eml` |
| 113 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 114 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0114.eml` |
| 117 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 120 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0120.eml` |
| 121 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 127 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 128 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0128.eml` |
| 133 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 134 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 137 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 139 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0139.eml` |
| 140 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0140.eml` |
| 141 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 144 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0144.eml` |
| 145 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0145.eml` |
| 146 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0146.eml` |
| 147 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OriginalMessage-Text | - | 1 | 0.1% | PASS | `specimen-0147.eml` |
| 149 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0149.eml` |
| 150 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0150.eml` |
| 151 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0151.eml` |
| 153 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0153.eml` |
| 154 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0154.eml` |
| 155 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0155.eml` |
| 156 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0156.eml` |
| 158 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0158.eml` |
| 159 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0159.eml` |
| 160 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0160.eml` |
