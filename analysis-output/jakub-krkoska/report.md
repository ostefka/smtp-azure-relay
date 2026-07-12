# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:36:13 UTC  
**Mailbox:** jakub.krkoska@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:01:31  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 69 |
| Duplicates skipped | 931 |
| Encrypted (skipped) | 0 |
| Injection PASS | 69 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Unknown | 831 | 83.1% |
| Exchange-Server | 167 | 16.7% |
| Outlook-Mac | 2 | 0.2% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| Reply | 642 | 64.2% |
| New | 354 | 35.4% |
| Forward | 4 | 0.4% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 5 | 0.5% |
| Outlook-BorderTop | 3 | 0.3% |
| Outlook-divRplyFwdMsg | 2 | 0.2% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `text/html` | 3 | 522 |
| `multipart/alternative(text/plain+text/html)` | 26 | 281 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 9 | 57 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 43 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream+application/octet-stream)` | 1 | 19 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 6 | 17 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 3 | 12 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 11 |
| `multipart/alternative(text/plain+text/calendar)` | 2 | 10 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 9 |
| `multipart/mixed(text/plain+application/octet-stream)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(text/plain+application/octet-stream+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 1 | 1 |
| `text/plain` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html+text/calendar)+application/pdf+application/pdf)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #21** — Unknown / Reply (436 msgs, 43.6%) — `specimen-0021.eml`
- **Pattern #23** — Unknown / Reply (93 msgs, 9.3%) — `specimen-0023.eml`
- **Pattern #22** — Unknown / Reply (62 msgs, 6.2%) — `specimen-0022.eml`
- **Pattern #19** — Unknown / Reply (12 msgs, 1.2%) — `specimen-0019.eml`
- **Pattern #25** — Unknown / Reply (12 msgs, 1.2%) — `specimen-0025.eml`
- **Pattern #27** — Exchange-Server / Reply (3 msgs, 0.3%) — `specimen-0027.eml`
- **Pattern #44** — Exchange-Server / Reply (3 msgs, 0.3%) — `specimen-0044.eml`
- **Pattern #31** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0031.eml`
- **Pattern #46** — Unknown / Reply (2 msgs, 0.2%) — `specimen-0046.eml`
- **Pattern #47** — Outlook-Mac / Reply (2 msgs, 0.2%) — `specimen-0047.eml`
- **Pattern #30** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0030.eml`
- **Pattern #34** — Unknown / Reply (1 msgs, 0.1%) — `specimen-0034.eml`
- **Pattern #40** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0040.eml`
- **Pattern #50** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0050.eml`
- **Pattern #54** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0054.eml`
- **Pattern #56** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0056.eml`
- **Pattern #57** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0057.eml`
- **Pattern #58** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0058.eml`
- **Pattern #69** — Unknown / Reply (1 msgs, 0.1%) — `specimen-0069.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 21 | Unknown | Reply | `text/html` | none | - | 436 | 43.6% | PASS | `specimen-0021.eml` |
| 23 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 93 | 9.3% | PASS | `specimen-0023.eml` |
| 18 | Unknown | New | `text/html` | none | - | 84 | 8.4% | PASS | `specimen-0018.eml` |
| 22 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 62 | 6.2% | PASS | `specimen-0022.eml` |
| 24 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 51 | 5.1% | PASS | `specimen-0024.eml` |
| 17 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 43 | 4.3% | PASS | `specimen-0017.eml` |
| 5 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 20 | 2.0% | PASS | `specimen-0005.eml` |
| 7 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 19 | 1.9% | PASS | `specimen-0007.eml` |
| 10 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 19 | 1.9% | PASS | `specimen-0010.eml` |
| 19 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 12 | 1.2% | PASS | `specimen-0019.eml` |
| 25 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 12 | 1.2% | PASS | `specimen-0025.eml` |
| 32 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 12 | 1.2% | PASS | `specimen-0032.eml` |
| 29 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 11 | 1.1% | PASS | `specimen-0029.eml` |
| 33 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 11 | 1.1% | PASS | `specimen-0033.eml` |
| 1 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 9 | 0.9% | PASS | `specimen-0001.eml` |
| 3 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 9 | 0.9% | PASS | `specimen-0003.eml` |
| 20 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 9 | 0.9% | PASS | `specimen-0020.eml` |
| 2 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 8 | 0.8% | PASS | `specimen-0002.eml` |
| 41 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 7 | 0.7% | PASS | `specimen-0041.eml` |
| 35 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0035.eml` |
| 6 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 3 | 0.3% | PASS | `specimen-0006.eml` |
| 27 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0027.eml` |
| 42 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0042.eml` |
| 44 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0044.eml` |
| 45 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0045.eml` |
| 8 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0008.eml` |
| 9 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0009.eml` |
| 15 | Exchange-Server | New | `multipart/mixed(text/plain+application/octet-stream)` | none | - | 2 | 0.2% | PASS | `specimen-0015.eml` |
| 26 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 2 | 0.2% | PASS | `specimen-0026.eml` |
| 28 | Unknown | New | `text/html` | none | - | 2 | 0.2% | PASS | `specimen-0028.eml` |
| 31 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0031.eml` |
| 43 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0043.eml` |
| 46 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0046.eml` |
| 47 | Outlook-Mac | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0047.eml` |
| 63 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0063.eml` |
| 4 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0004.eml` |
| 11 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0011.eml` |
| 12 | Exchange-Server | New | `multipart/mixed(text/plain+application/octet-stream+appli...` | none | - | 1 | 0.1% | PASS | `specimen-0012.eml` |
| 13 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0013.eml` |
| 14 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0014.eml` |
| 16 | Exchange-Server | New | `text/plain` | none | - | 1 | 0.1% | PASS | `specimen-0016.eml` |
| 30 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0030.eml` |
| 34 | Unknown | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0034.eml` |
| 36 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 37 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0037.eml` |
| 38 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0038.eml` |
| 39 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0039.eml` |
| 40 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0040.eml` |
| 48 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0048.eml` |
| 49 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 50 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0050.eml` |
| 51 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0051.eml` |
| 52 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 53 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0053.eml` |
| 54 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 56 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0056.eml` |
| 57 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 58 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0058.eml` |
| 59 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 61 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 64 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0064.eml` |
| 65 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 66 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0066.eml` |
| 67 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0067.eml` |
| 68 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 69 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0069.eml` |
