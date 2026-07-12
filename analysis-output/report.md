# Signature Injection Analysis Report

**Generated:** 2026-05-10 16:28:41 UTC  
**Mailbox:** ondrej.stefka@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:00:56  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 500 |
| Unique patterns | 41 |
| Duplicates skipped | 459 |
| Encrypted (skipped) | 0 |
| Injection PASS | 41 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 491 | 98.2% |
| Unknown | 9 | 1.8% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 439 | 87.8% |
| Reply | 50 | 10.0% |
| Forward | 11 | 2.2% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 58 | 11.6% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html)` | 9 | 322 |
| `multipart/alternative(text/plain+text/html+text/calendar)` | 7 | 74 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 1 | 30 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 5 | 21 |
| `text/plain` | 1 | 18 |
| `multipart/mixed(text/plain+application/x-microsoft-rpmsg-message)` | 1 | 6 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 5 |
| `multipart/alternative(text/plain+text/calendar)` | 2 | 5 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/x-sharing-metadata-xml)` | 1 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+text/plain)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+text/plain)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.presentationml.presentation)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #31** — Exchange-Server / Forward (3 msgs, 0.6%) — `specimen-0031.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 224 | 44.8% | PASS | `specimen-0001.eml` |
| 4 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 54 | 10.8% | PASS | `specimen-0004.eml` |
| 5 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 32 | 6.4% | PASS | `specimen-0005.eml` |
| 33 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 30 | 6.0% | PASS | `specimen-0033.eml` |
| 23 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 28 | 5.6% | PASS | `specimen-0023.eml` |
| 10 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 25 | 5.0% | PASS | `specimen-0010.eml` |
| 39 | Exchange-Server | New | `text/plain` | none | - | 18 | 3.6% | PASS | `specimen-0039.eml` |
| 9 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 11 | 2.2% | PASS | `specimen-0009.eml` |
| 38 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 8 | 1.6% | PASS | `specimen-0038.eml` |
| 19 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 6 | 1.2% | PASS | `specimen-0019.eml` |
| 28 | Exchange-Server | New | `multipart/mixed(text/plain+application/x-microsoft-rpmsg-...` | none | - | 6 | 1.2% | PASS | `specimen-0028.eml` |
| 8 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 5 | 1.0% | PASS | `specimen-0008.eml` |
| 20 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 5 | 1.0% | PASS | `specimen-0020.eml` |
| 14 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 4 | 0.8% | PASS | `specimen-0014.eml` |
| 2 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 3 | 0.6% | PASS | `specimen-0002.eml` |
| 6 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 3 | 0.6% | PASS | `specimen-0006.eml` |
| 17 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 3 | 0.6% | PASS | `specimen-0017.eml` |
| 29 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.6% | PASS | `specimen-0029.eml` |
| 31 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 3 | 0.6% | PASS | `specimen-0031.eml` |
| 3 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 2 | 0.4% | PASS | `specimen-0003.eml` |
| 12 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.4% | PASS | `specimen-0012.eml` |
| 15 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 2 | 0.4% | PASS | `specimen-0015.eml` |
| 16 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.4% | PASS | `specimen-0016.eml` |
| 25 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.4% | PASS | `specimen-0025.eml` |
| 27 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 2 | 0.4% | PASS | `specimen-0027.eml` |
| 37 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 2 | 0.4% | PASS | `specimen-0037.eml` |
| 7 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 1 | 0.2% | PASS | `specimen-0007.eml` |
| 11 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.2% | PASS | `specimen-0011.eml` |
| 13 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.2% | PASS | `specimen-0013.eml` |
| 18 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.2% | PASS | `specimen-0018.eml` |
| 21 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.2% | PASS | `specimen-0021.eml` |
| 22 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.2% | PASS | `specimen-0022.eml` |
| 24 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.2% | PASS | `specimen-0024.eml` |
| 26 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.2% | PASS | `specimen-0026.eml` |
| 30 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.2% | PASS | `specimen-0030.eml` |
| 32 | Exchange-Server | Forward | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 1 | 0.2% | PASS | `specimen-0032.eml` |
| 34 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.2% | PASS | `specimen-0034.eml` |
| 35 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.2% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.2% | PASS | `specimen-0036.eml` |
| 40 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.2% | PASS | `specimen-0040.eml` |
| 41 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 1 | 0.2% | PASS | `specimen-0041.eml` |
