# Signature Injection Analysis Report

**Generated:** 2026-05-10 16:59:55 UTC  
**Mailbox:** filip.hudak@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:03:31  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 157 |
| Duplicates skipped | 843 |
| Encrypted (skipped) | 0 |
| Injection PASS | 157 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 999 | 99.9% |
| Unknown | 1 | 0.1% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 702 | 70.2% |
| Reply | 253 | 25.3% |
| Forward | 45 | 4.5% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 201 | 20.1% |
| Outlook-BorderTop | 45 | 4.5% |
| Outlook-divRplyFwdMsg | 38 | 3.8% |
| Outlook-OriginalMessage | 2 | 0.2% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 38 | 654 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 6 | 133 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 14 | 33 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 13 | 23 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 11 | 20 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pdf)` | 1 | 15 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 6 | 12 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 3 | 11 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 7 | 11 |
| `multipart/alternative(text/plain+text/calendar)` | 2 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 5 | 9 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 4 | 8 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 4 | 8 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/jpeg)` | 3 | 6 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf)` | 6 | 6 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 5 | 5 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)+application/pdf)` | 1 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 4 | 4 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg+image/jpeg)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/gif)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 1 | 2 |
| `text/plain` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)+application/pdf)` | 1 | 1 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-zip-compressed)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream+application/octet-stream+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/xml)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+pdf/signosign.2)` | 1 | 1 |
| `multipart/mixed(text/plain+application/x-microsoft-rpmsg-message)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #35** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0035.eml`
- **Pattern #39** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0039.eml`
- **Pattern #41** — Exchange-Server / Forward (2 msgs, 0.2%) — `specimen-0041.eml`
- **Pattern #147** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0147.eml`
- **Pattern #7** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0007.eml`
- **Pattern #20** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0020.eml`
- **Pattern #47** — Exchange-Server / Forward (1 msgs, 0.1%) — `specimen-0047.eml`
- **Pattern #146** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0146.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 334 | 33.4% | PASS | `specimen-0001.eml` |
| 10 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 70 | 7.0% | PASS | `specimen-0010.eml` |
| 6 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 52 | 5.2% | PASS | `specimen-0006.eml` |
| 76 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 47 | 4.7% | PASS | `specimen-0076.eml` |
| 3 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 43 | 4.3% | PASS | `specimen-0003.eml` |
| 75 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 41 | 4.1% | PASS | `specimen-0075.eml` |
| 5 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 39 | 3.9% | PASS | `specimen-0005.eml` |
| 15 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 27 | 2.7% | PASS | `specimen-0015.eml` |
| 50 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 21 | 2.1% | PASS | `specimen-0050.eml` |
| 130 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 16 | 1.6% | PASS | `specimen-0130.eml` |
| 12 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 15 | 1.5% | PASS | `specimen-0012.eml` |
| 79 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 14 | 1.4% | PASS | `specimen-0079.eml` |
| 13 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 8 | 0.8% | PASS | `specimen-0013.eml` |
| 46 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 8 | 0.8% | PASS | `specimen-0046.eml` |
| 78 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 8 | 0.8% | PASS | `specimen-0078.eml` |
| 114 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 8 | 0.8% | PASS | `specimen-0114.eml` |
| 4 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 7 | 0.7% | PASS | `specimen-0004.eml` |
| 116 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 7 | 0.7% | PASS | `specimen-0116.eml` |
| 8 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0008.eml` |
| 53 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 6 | 0.6% | PASS | `specimen-0053.eml` |
| 110 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 6 | 0.6% | PASS | `specimen-0110.eml` |
| 113 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 6 | 0.6% | PASS | `specimen-0113.eml` |
| 17 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0017.eml` |
| 26 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 5 | 0.5% | PASS | `specimen-0026.eml` |
| 88 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 5 | 0.5% | PASS | `specimen-0088.eml` |
| 120 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 5 | 0.5% | PASS | `specimen-0120.eml` |
| 121 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 5 | 0.5% | PASS | `specimen-0121.eml` |
| 51 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0051.eml` |
| 52 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 4 | 0.4% | PASS | `specimen-0052.eml` |
| 62 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 4 | 0.4% | PASS | `specimen-0062.eml` |
| 111 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 4 | 0.4% | PASS | `specimen-0111.eml` |
| 122 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 4 | 0.4% | PASS | `specimen-0122.eml` |
| 14 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0014.eml` |
| 18 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0018.eml` |
| 40 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0040.eml` |
| 60 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0060.eml` |
| 84 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0084.eml` |
| 101 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0101.eml` |
| 125 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 3 | 0.3% | PASS | `specimen-0125.eml` |
| 140 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0140.eml` |
| 150 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0150.eml` |
| 2 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0002.eml` |
| 9 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0009.eml` |
| 35 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0035.eml` |
| 38 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0038.eml` |
| 39 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0039.eml` |
| 41 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0041.eml` |
| 48 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0048.eml` |
| 56 | Exchange-Server | Reply | `text/plain` | Outlook-OriginalMessage | - | 2 | 0.2% | PASS | `specimen-0056.eml` |
| 74 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0074.eml` |
| 77 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0077.eml` |
| 85 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0085.eml` |
| 87 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0087.eml` |
| 90 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0090.eml` |
| 95 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0095.eml` |
| 99 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 2 | 0.2% | PASS | `specimen-0099.eml` |
| 107 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0107.eml` |
| 112 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0112.eml` |
| 118 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0118.eml` |
| 123 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0123.eml` |
| 124 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0124.eml` |
| 131 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0131.eml` |
| 147 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0147.eml` |
| 154 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0154.eml` |
| 7 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0007.eml` |
| 11 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0011.eml` |
| 16 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0016.eml` |
| 19 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0019.eml` |
| 20 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0020.eml` |
| 21 | Exchange-Server | Forward | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0021.eml` |
| 22 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0022.eml` |
| 23 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0023.eml` |
| 24 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0024.eml` |
| 25 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0025.eml` |
| 27 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0027.eml` |
| 28 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0028.eml` |
| 29 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 1 | 0.1% | PASS | `specimen-0029.eml` |
| 30 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0030.eml` |
| 31 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0031.eml` |
| 32 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0032.eml` |
| 33 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0033.eml` |
| 34 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0034.eml` |
| 36 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 37 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0037.eml` |
| 42 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0042.eml` |
| 43 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0043.eml` |
| 44 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0044.eml` |
| 45 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0045.eml` |
| 47 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0047.eml` |
| 49 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 54 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 57 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 58 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0058.eml` |
| 59 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 61 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0061.eml` |
| 63 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 64 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0064.eml` |
| 65 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 66 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0066.eml` |
| 67 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0067.eml` |
| 68 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 69 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0069.eml` |
| 70 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0070.eml` |
| 71 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0071.eml` |
| 72 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0072.eml` |
| 73 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0073.eml` |
| 80 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0080.eml` |
| 81 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 82 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0082.eml` |
| 83 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0083.eml` |
| 86 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0086.eml` |
| 89 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 91 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 92 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0092.eml` |
| 93 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0093.eml` |
| 94 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 96 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0096.eml` |
| 97 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0097.eml` |
| 98 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0098.eml` |
| 100 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0100.eml` |
| 102 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 103 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0103.eml` |
| 104 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 105 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 106 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0106.eml` |
| 108 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 109 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0109.eml` |
| 115 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0115.eml` |
| 117 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 119 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0119.eml` |
| 126 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 127 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 128 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0128.eml` |
| 129 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0129.eml` |
| 132 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 133 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 134 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0134.eml` |
| 135 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0135.eml` |
| 136 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0136.eml` |
| 137 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 139 | Exchange-Server | Forward | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0139.eml` |
| 141 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 143 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0143.eml` |
| 144 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0144.eml` |
| 145 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0145.eml` |
| 146 | Exchange-Server | Reply | `multipart/mixed(text/plain+application/x-microsoft-rpmsg-...` | none | - | 1 | 0.1% | PASS | `specimen-0146.eml` |
| 148 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0148.eml` |
| 149 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0149.eml` |
| 151 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0151.eml` |
| 152 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0152.eml` |
| 153 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0153.eml` |
| 155 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0155.eml` |
| 156 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0156.eml` |
| 157 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0157.eml` |
