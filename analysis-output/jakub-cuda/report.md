# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:08:50 UTC  
**Mailbox:** jakub.cuda@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:03:03  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 136 |
| Duplicates skipped | 864 |
| Encrypted (skipped) | 0 |
| Injection PASS | 136 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 912 | 91.2% |
| Unknown | 88 | 8.8% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 673 | 67.3% |
| Reply | 317 | 31.7% |
| Forward | 10 | 1.0% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| Outlook-BorderTop | 171 | 17.1% |
| Outlook-divRplyFwdMsg | 150 | 15.0% |
| Outlook-OriginalMessage | 4 | 0.4% |
| OWA-AppendOnSend | 1 | 0.1% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 27 | 599 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 16 | 86 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 6 | 85 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 79 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 5 | 24 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 10 | 18 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 5 | 10 |
| `multipart/alternative(text/plain+text/calendar)` | 1 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 5 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 6 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 7 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 3 | 4 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif)` | 1 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 2 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/mixed(text/plain+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/gif)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)+application/pdf)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png+image/jpeg+image/jpeg+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/gif)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/gif+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/png+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(text/plain+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.ms-excel+application/vnd.ms-excel)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/vnd.ms-powerpoint.presentation.macroenabled.12)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `text/html` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.presentationml.presentation)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html+text/calendar)+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+image/jpeg+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+message/rfc822)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `text/plain` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #58** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0058.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 2 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 366 | 36.6% | PASS | `specimen-0002.eml` |
| 14 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 79 | 7.9% | PASS | `specimen-0014.eml` |
| 7 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 70 | 7.0% | PASS | `specimen-0007.eml` |
| 11 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 68 | 6.8% | PASS | `specimen-0011.eml` |
| 12 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 34 | 3.4% | PASS | `specimen-0012.eml` |
| 18 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 34 | 3.4% | PASS | `specimen-0018.eml` |
| 1 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 31 | 3.1% | PASS | `specimen-0001.eml` |
| 15 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 20 | 2.0% | PASS | `specimen-0015.eml` |
| 36 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 18 | 1.8% | PASS | `specimen-0036.eml` |
| 19 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 15 | 1.5% | PASS | `specimen-0019.eml` |
| 38 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 14 | 1.4% | PASS | `specimen-0038.eml` |
| 9 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 13 | 1.3% | PASS | `specimen-0009.eml` |
| 44 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 12 | 1.2% | PASS | `specimen-0044.eml` |
| 85 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 10 | 1.0% | PASS | `specimen-0085.eml` |
| 20 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 9 | 0.9% | PASS | `specimen-0020.eml` |
| 64 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 6 | 0.6% | PASS | `specimen-0064.eml` |
| 70 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 6 | 0.6% | PASS | `specimen-0070.eml` |
| 17 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 5 | 0.5% | PASS | `specimen-0017.eml` |
| 42 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 5 | 0.5% | PASS | `specimen-0042.eml` |
| 103 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 5 | 0.5% | PASS | `specimen-0103.eml` |
| 26 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0026.eml` |
| 27 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 4 | 0.4% | PASS | `specimen-0027.eml` |
| 30 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 4 | 0.4% | PASS | `specimen-0030.eml` |
| 31 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 4 | 0.4% | PASS | `specimen-0031.eml` |
| 50 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0050.eml` |
| 53 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0053.eml` |
| 56 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 4 | 0.4% | PASS | `specimen-0056.eml` |
| 75 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0075.eml` |
| 24 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0024.eml` |
| 32 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0032.eml` |
| 33 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0033.eml` |
| 35 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0035.eml` |
| 45 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0045.eml` |
| 63 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0063.eml` |
| 66 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0066.eml` |
| 84 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0084.eml` |
| 87 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0087.eml` |
| 94 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0094.eml` |
| 105 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 3 | 0.3% | PASS | `specimen-0105.eml` |
| 114 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0114.eml` |
| 117 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0117.eml` |
| 120 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 3 | 0.3% | PASS | `specimen-0120.eml` |
| 4 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0004.eml` |
| 6 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 2 | 0.2% | PASS | `specimen-0006.eml` |
| 21 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 2 | 0.2% | PASS | `specimen-0021.eml` |
| 28 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 2 | 0.2% | PASS | `specimen-0028.eml` |
| 29 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 2 | 0.2% | PASS | `specimen-0029.eml` |
| 34 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0034.eml` |
| 46 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0046.eml` |
| 47 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0047.eml` |
| 54 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0054.eml` |
| 72 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0072.eml` |
| 78 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 2 | 0.2% | PASS | `specimen-0078.eml` |
| 109 | Exchange-Server | Reply | `multipart/mixed(text/plain+application/vnd.openxmlformats...` | Outlook-OriginalMessage | - | 2 | 0.2% | PASS | `specimen-0109.eml` |
| 3 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0003.eml` |
| 5 | Exchange-Server | Reply | `multipart/mixed(text/plain+application/pdf+application/pdf)` | Outlook-OriginalMessage | - | 1 | 0.1% | PASS | `specimen-0005.eml` |
| 8 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0008.eml` |
| 10 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0010.eml` |
| 13 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0013.eml` |
| 16 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0016.eml` |
| 22 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0022.eml` |
| 23 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0023.eml` |
| 25 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0025.eml` |
| 37 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0037.eml` |
| 39 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0039.eml` |
| 40 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0040.eml` |
| 41 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0041.eml` |
| 43 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0043.eml` |
| 48 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0048.eml` |
| 49 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 51 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0051.eml` |
| 52 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 55 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 57 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 58 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0058.eml` |
| 59 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 61 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 62 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 65 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 67 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0067.eml` |
| 68 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 69 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0069.eml` |
| 71 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0071.eml` |
| 73 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0073.eml` |
| 74 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0074.eml` |
| 76 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0076.eml` |
| 77 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0077.eml` |
| 79 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0079.eml` |
| 80 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0080.eml` |
| 81 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 82 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0082.eml` |
| 83 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0083.eml` |
| 86 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0086.eml` |
| 88 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0088.eml` |
| 89 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 90 | Unknown | New | `text/html` | none | - | 1 | 0.1% | PASS | `specimen-0090.eml` |
| 91 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 92 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 95 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0095.eml` |
| 96 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0096.eml` |
| 97 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0097.eml` |
| 98 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0098.eml` |
| 99 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0099.eml` |
| 100 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 101 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0101.eml` |
| 102 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 104 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 106 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0106.eml` |
| 107 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 108 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 110 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0110.eml` |
| 111 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0111.eml` |
| 112 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0112.eml` |
| 113 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 115 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0115.eml` |
| 116 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0116.eml` |
| 118 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0118.eml` |
| 119 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0119.eml` |
| 121 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 122 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0122.eml` |
| 123 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0123.eml` |
| 124 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0124.eml` |
| 125 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0125.eml` |
| 126 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 127 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 128 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0128.eml` |
| 129 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0129.eml` |
| 130 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0130.eml` |
| 131 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0131.eml` |
| 132 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 133 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 134 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 135 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0135.eml` |
| 136 | Exchange-Server | Reply | `text/plain` | Outlook-OriginalMessage | - | 1 | 0.1% | PASS | `specimen-0136.eml` |
