# Signature Injection Analysis Report

**Generated:** 2026-05-10 17:25:33 UTC  
**Mailbox:** dawid.jerzykowski@invia.com  
**Folders:** SentItems, Inbox  
**Duration:** 00:02:57  

## Summary

| Metric | Value |
|--------|-------|
| Messages scanned | 1,000 |
| Unique patterns | 182 |
| Duplicates skipped | 818 |
| Encrypted (skipped) | 0 |
| Injection PASS | 182 |
| Injection FAIL | 0 |
| **Pass rate** | **100.0%** |

## Email Client Distribution

| Client | Messages | % |
|--------|----------|---|
| Exchange-Server | 827 | 82.7% |
| Unknown | 163 | 16.3% |
| Other | 10 | 1.0% |

## Message Type Distribution

| Type | Messages | % |
|------|----------|---|
| New | 760 | 76.0% |
| Reply | 231 | 23.1% |
| Forward | 9 | 0.9% |

## Reply Boundary Patterns Detected

| Pattern | Messages | % |
|---------|----------|---|
| OWA-AppendOnSend | 122 | 12.2% |
| Outlook-BorderTop | 64 | 6.4% |
| Outlook-divRplyFwdMsg | 32 | 3.2% |
| OriginalMessage-Text | 1 | 0.1% |

## MIME Structure Distribution

| Structure | Patterns | Messages |
|-----------|----------|----------|
| `multipart/alternative(text/plain+text/html+text/calendar)` | 12 | 200 |
| `multipart/alternative(text/plain+text/html)` | 21 | 185 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+image/png)` | 1 | 176 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png)` | 22 | 128 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)` | 16 | 52 |
| `text/html` | 3 | 51 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf+application/pdf)` | 3 | 26 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf+application/pdf)` | 2 | 18 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 17 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png)` | 9 | 16 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/pdf)` | 8 | 12 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png)` | 4 | 9 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)` | 5 | 8 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg)` | 4 | 6 |
| `multipart/related(text/html+image/png+image/png)` | 1 | 5 |
| `multipart/related(text/html+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 5 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf)` | 3 | 5 |
| `multipart/related(text/html+image/jpeg)` | 1 | 4 |
| `multipart/mixed(text/plain+application/pdf)` | 1 | 4 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/jpeg)` | 2 | 3 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg)` | 2 | 3 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg)` | 3 | 3 |
| `multipart/alternative(text/plain+text/calendar)` | 3 | 3 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg)` | 1 | 2 |
| `text/plain` | 1 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 2 | 2 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/gif)` | 2 | 2 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/vnd.openxmlformats-officedocument.wordprocessingml.document+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 2 | 2 |
| `multipart/alternative(text/plain+multipart/related(text/html+image/png))` | 2 | 2 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+message/rfc822)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg+image/png+image/png+image/jpeg+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/jpeg+image/png+image/png+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/jpeg+image/png+image/jpeg)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png)+message/rfc822)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg)+image/jpeg)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/jpeg+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/jpeg+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/octet-stream)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png)+application/pdf+application/pdf+application/pdf)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+text/html)+application/octet-stream)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/jpeg+image/png+image/png+image/png+image/png+image/png)` | 1 | 1 |
| `multipart/mixed(multipart/alternative(text/plain+multipart/related(text/html+image/png))+application/vnd.openxmlformats-officedocument.wordprocessingml.document)` | 1 | 1 |
| `multipart/mixed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/jpeg)+application/pdf)` | 1 | 1 |
| `multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png+image/png+image/png+image/png+image/png+image/png+image/jpeg+image/png+image/png)` | 1 | 1 |
| `multipart/signed(multipart/related(multipart/alternative(text/plain+text/html)+image/png+image/png)+application/pkcs7-signature)` | 1 | 1 |

## ⚠️ Reply/Forward WITHOUT Detected Boundary

These are replies/forwards where no boundary was found — signature will be injected at end of body instead of before quoted content:

- **Pattern #148** — Unknown / Reply (5 msgs, 0.5%) — `specimen-0148.eml`
- **Pattern #155** — Unknown / Reply (4 msgs, 0.4%) — `specimen-0155.eml`
- **Pattern #16** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0016.eml`
- **Pattern #161** — Exchange-Server / Reply (2 msgs, 0.2%) — `specimen-0161.eml`
- **Pattern #118** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0118.eml`
- **Pattern #142** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0142.eml`
- **Pattern #147** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0147.eml`
- **Pattern #163** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0163.eml`
- **Pattern #165** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0165.eml`
- **Pattern #167** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0167.eml`
- **Pattern #174** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0174.eml`
- **Pattern #176** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0176.eml`
- **Pattern #182** — Exchange-Server / Reply (1 msgs, 0.1%) — `specimen-0182.eml`

## All Patterns

| # | Client | Type | MIME | Boundary | Sig | Msgs | % | Inject | Specimen |
|---|--------|------|------|----------|-----|------|---|--------|----------|
| 38 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 176 | 17.6% | PASS | `specimen-0038.eml` |
| 4 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 71 | 7.1% | PASS | `specimen-0004.eml` |
| 1 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 53 | 5.3% | PASS | `specimen-0001.eml` |
| 5 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 53 | 5.3% | PASS | `specimen-0005.eml` |
| 134 | Unknown | New | `text/html` | none | - | 46 | 4.6% | PASS | `specimen-0134.eml` |
| 135 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 45 | 4.5% | PASS | `specimen-0135.eml` |
| 70 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 32 | 3.2% | PASS | `specimen-0070.eml` |
| 19 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 26 | 2.6% | PASS | `specimen-0019.eml` |
| 8 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 24 | 2.4% | PASS | `specimen-0008.eml` |
| 42 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 24 | 2.4% | PASS | `specimen-0042.eml` |
| 14 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 21 | 2.1% | PASS | `specimen-0014.eml` |
| 6 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 19 | 1.9% | PASS | `specimen-0006.eml` |
| 67 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 17 | 1.7% | PASS | `specimen-0067.eml` |
| 69 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 17 | 1.7% | PASS | `specimen-0069.eml` |
| 136 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 17 | 1.7% | PASS | `specimen-0136.eml` |
| 157 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 14 | 1.4% | PASS | `specimen-0157.eml` |
| 12 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 12 | 1.2% | PASS | `specimen-0012.eml` |
| 22 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 11 | 1.1% | PASS | `specimen-0022.eml` |
| 18 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 10 | 1.0% | PASS | `specimen-0018.eml` |
| 146 | Other | New | `multipart/alternative(text/plain+text/html)` | none | - | 10 | 1.0% | PASS | `specimen-0146.eml` |
| 15 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 9 | 0.9% | PASS | `specimen-0015.eml` |
| 7 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 8 | 0.8% | PASS | `specimen-0007.eml` |
| 95 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 8 | 0.8% | PASS | `specimen-0095.eml` |
| 77 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 7 | 0.7% | PASS | `specimen-0077.eml` |
| 86 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 7 | 0.7% | PASS | `specimen-0086.eml` |
| 143 | Unknown | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 7 | 0.7% | PASS | `specimen-0143.eml` |
| 44 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 6 | 0.6% | PASS | `specimen-0044.eml` |
| 100 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 6 | 0.6% | PASS | `specimen-0100.eml` |
| 10 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0010.eml` |
| 26 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | OWA-AppendOnSend | - | 5 | 0.5% | PASS | `specimen-0026.eml` |
| 71 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 5 | 0.5% | PASS | `specimen-0071.eml` |
| 148 | Unknown | Reply | `multipart/related(text/html+image/png+image/png)` | none | - | 5 | 0.5% | PASS | `specimen-0148.eml` |
| 154 | Unknown | New | `multipart/related(text/html+image/png+image/png+image/png...` | none | - | 5 | 0.5% | PASS | `specimen-0154.eml` |
| 66 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 4 | 0.4% | PASS | `specimen-0066.eml` |
| 93 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 4 | 0.4% | PASS | `specimen-0093.eml` |
| 96 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 4 | 0.4% | PASS | `specimen-0096.eml` |
| 139 | Unknown | New | `multipart/related(text/html+image/jpeg)` | none | - | 4 | 0.4% | PASS | `specimen-0139.eml` |
| 155 | Unknown | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 4 | 0.4% | PASS | `specimen-0155.eml` |
| 158 | Unknown | New | `multipart/mixed(text/plain+application/pdf)` | none | - | 4 | 0.4% | PASS | `specimen-0158.eml` |
| 9 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 3 | 0.3% | PASS | `specimen-0009.eml` |
| 11 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 3 | 0.3% | PASS | `specimen-0011.eml` |
| 24 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0024.eml` |
| 43 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 3 | 0.3% | PASS | `specimen-0043.eml` |
| 61 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 3 | 0.3% | PASS | `specimen-0061.eml` |
| 74 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 3 | 0.3% | PASS | `specimen-0074.eml` |
| 78 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 3 | 0.3% | PASS | `specimen-0078.eml` |
| 83 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 3 | 0.3% | PASS | `specimen-0083.eml` |
| 87 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 3 | 0.3% | PASS | `specimen-0087.eml` |
| 90 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 3 | 0.3% | PASS | `specimen-0090.eml` |
| 92 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 3 | 0.3% | PASS | `specimen-0092.eml` |
| 99 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | outlook-underscore-separator | 3 | 0.3% | PASS | `specimen-0099.eml` |
| 145 | Unknown | New | `text/html` | none | - | 3 | 0.3% | PASS | `specimen-0145.eml` |
| 151 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 3 | 0.3% | PASS | `specimen-0151.eml` |
| 16 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0016.eml` |
| 27 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0027.eml` |
| 34 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 2 | 0.2% | PASS | `specimen-0034.eml` |
| 39 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | - | 2 | 0.2% | PASS | `specimen-0039.eml` |
| 48 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0048.eml` |
| 64 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0064.eml` |
| 79 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 2 | 0.2% | PASS | `specimen-0079.eml` |
| 84 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0084.eml` |
| 85 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0085.eml` |
| 88 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0088.eml` |
| 98 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0098.eml` |
| 101 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0101.eml` |
| 106 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0106.eml` |
| 110 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0110.eml` |
| 123 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 2 | 0.2% | PASS | `specimen-0123.eml` |
| 129 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-BorderTop | - | 2 | 0.2% | PASS | `specimen-0129.eml` |
| 131 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 2 | 0.2% | PASS | `specimen-0131.eml` |
| 140 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 2 | 0.2% | PASS | `specimen-0140.eml` |
| 144 | Unknown | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 2 | 0.2% | PASS | `specimen-0144.eml` |
| 149 | Unknown | New | `multipart/alternative(text/plain+text/html)` | none | - | 2 | 0.2% | PASS | `specimen-0149.eml` |
| 156 | Exchange-Server | New | `text/plain` | none | - | 2 | 0.2% | PASS | `specimen-0156.eml` |
| 160 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 2 | 0.2% | PASS | `specimen-0160.eml` |
| 161 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 2 | 0.2% | PASS | `specimen-0161.eml` |
| 180 | Unknown | New | `text/html` | none | - | 2 | 0.2% | PASS | `specimen-0180.eml` |
| 2 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0002.eml` |
| 3 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0003.eml` |
| 13 | Exchange-Server | New | `multipart/alternative(text/plain+text/html+text/calendar)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0013.eml` |
| 17 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0017.eml` |
| 20 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0020.eml` |
| 21 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0021.eml` |
| 23 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0023.eml` |
| 25 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0025.eml` |
| 28 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0028.eml` |
| 29 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0029.eml` |
| 30 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0030.eml` |
| 31 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0031.eml` |
| 32 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0032.eml` |
| 33 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0033.eml` |
| 35 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0035.eml` |
| 36 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0036.eml` |
| 37 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0037.eml` |
| 40 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0040.eml` |
| 41 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0041.eml` |
| 45 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0045.eml` |
| 46 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0046.eml` |
| 47 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0047.eml` |
| 49 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0049.eml` |
| 50 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0050.eml` |
| 51 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0051.eml` |
| 52 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0052.eml` |
| 53 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0053.eml` |
| 54 | Exchange-Server | Reply | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0054.eml` |
| 55 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0055.eml` |
| 56 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0056.eml` |
| 57 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0057.eml` |
| 58 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0058.eml` |
| 59 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0059.eml` |
| 60 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0060.eml` |
| 62 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0062.eml` |
| 63 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0063.eml` |
| 65 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | OWA-Signature | 1 | 0.1% | PASS | `specimen-0065.eml` |
| 68 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0068.eml` |
| 72 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0072.eml` |
| 73 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0073.eml` |
| 75 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0075.eml` |
| 76 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0076.eml` |
| 80 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0080.eml` |
| 81 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0081.eml` |
| 82 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0082.eml` |
| 89 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0089.eml` |
| 91 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0091.eml` |
| 94 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0094.eml` |
| 97 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0097.eml` |
| 102 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0102.eml` |
| 103 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0103.eml` |
| 104 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0104.eml` |
| 105 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0105.eml` |
| 107 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0107.eml` |
| 108 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0108.eml` |
| 109 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0109.eml` |
| 111 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0111.eml` |
| 112 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0112.eml` |
| 113 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0113.eml` |
| 114 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0114.eml` |
| 115 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0115.eml` |
| 116 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0116.eml` |
| 117 | Exchange-Server | New | `multipart/alternative(text/plain+text/calendar)` | none | - | 1 | 0.1% | PASS | `specimen-0117.eml` |
| 118 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0118.eml` |
| 119 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0119.eml` |
| 120 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0120.eml` |
| 121 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | - | 1 | 0.1% | PASS | `specimen-0121.eml` |
| 122 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0122.eml` |
| 124 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0124.eml` |
| 125 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0125.eml` |
| 126 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0126.eml` |
| 127 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0127.eml` |
| 128 | Exchange-Server | Reply | `multipart/mixed(multipart/related(multipart/alternative(t...` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0128.eml` |
| 130 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0130.eml` |
| 132 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0132.eml` |
| 133 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0133.eml` |
| 137 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | Outlook-divRplyFwdMsg | - | 1 | 0.1% | PASS | `specimen-0137.eml` |
| 138 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0138.eml` |
| 141 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0141.eml` |
| 142 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0142.eml` |
| 147 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0147.eml` |
| 150 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0150.eml` |
| 152 | Exchange-Server | Forward | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0152.eml` |
| 153 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0153.eml` |
| 159 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0159.eml` |
| 162 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+multipar...` | none | - | 1 | 0.1% | PASS | `specimen-0162.eml` |
| 163 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0163.eml` |
| 164 | Exchange-Server | New | `multipart/alternative(text/plain+multipart/related(text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0164.eml` |
| 165 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0165.eml` |
| 166 | Exchange-Server | Reply | `multipart/alternative(text/plain+multipart/related(text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0166.eml` |
| 167 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0167.eml` |
| 168 | Exchange-Server | New | `multipart/alternative(text/plain+text/html)` | none | - | 1 | 0.1% | PASS | `specimen-0168.eml` |
| 169 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | OWA-AppendOnSend | - | 1 | 0.1% | PASS | `specimen-0169.eml` |
| 170 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-divRplyFwdMsg | OWA-Signature | 1 | 0.1% | PASS | `specimen-0170.eml` |
| 171 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | Outlook-BorderTop | OWA-Signature | 1 | 0.1% | PASS | `specimen-0171.eml` |
| 172 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | OWA-Signature | 1 | 0.1% | PASS | `specimen-0172.eml` |
| 173 | Exchange-Server | New | `multipart/mixed(multipart/related(multipart/alternative(t...` | none | - | 1 | 0.1% | PASS | `specimen-0173.eml` |
| 174 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0174.eml` |
| 175 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0175.eml` |
| 176 | Exchange-Server | Reply | `multipart/alternative(text/plain+text/html)` | none | outlook-underscore-separator | 1 | 0.1% | PASS | `specimen-0176.eml` |
| 177 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0177.eml` |
| 178 | Exchange-Server | New | `multipart/mixed(multipart/alternative(text/plain+text/htm...` | none | - | 1 | 0.1% | PASS | `specimen-0178.eml` |
| 179 | Exchange-Server | New | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0179.eml` |
| 181 | Exchange-Server | New | `multipart/signed(multipart/related(multipart/alternative(...` | OriginalMessage-Text | - | 1 | 0.1% | PASS | `specimen-0181.eml` |
| 182 | Exchange-Server | Reply | `multipart/related(multipart/alternative(text/plain+text/h...` | none | - | 1 | 0.1% | PASS | `specimen-0182.eml` |
