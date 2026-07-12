# Shadow Mode Testing Plan

## Phase 1: Infrastructure Setup

1. **Create on-prem sink mailbox** — e.g. `signature-shadow@invia.cz` on the on-prem Exchange. No forwarding, no user access needed.

2. **Create on-prem transport rule** — match messages arriving at `signature-shadow@invia.cz`, action: silently delete (or redirect to a journal mailbox if you want to inspect results).

3. **Configure SignatureService shadow mode** — add a processing mode where after signature injection, instead of returning the message to Exchange Online, it forwards the result to the on-prem sink via SMTP. The original delivery path is untouched.

4. **Open SMTP connectivity** — ensure the SignatureService ACI can reach the on-prem Exchange SMTP endpoint (port 25). You likely already have this path since the service lives behind the NSG with EXO rules. Add a rule for outbound to on-prem MX if needed.

5. **Create ETR in Exchange Online** — rule: "If sender is member of CEE-IT group AND message is outbound, BCC a copy to `inviasignature.invia.eu:25`". Use BCC (not redirect) so original delivery is completely unaffected.

6. **Scope control** — start with 1 user (yourself), verify end-to-end, then expand to all 14 CEE-IT users.

## Phase 2: Execution

1. **Deploy updated SignatureService** with the 3 boundary detection fixes + shadow mode config.
2. **Enable ETR for ondrej-stefka only.**
3. **Send test emails** — fresh compose, reply, forward, with attachments, meeting invites.
4. **Verify on on-prem** — check that messages arrive at the sink mailbox with signatures injected correctly.
5. **Check service logs** — confirm boundary detection, injection outcome, no errors.
6. **Expand ETR scope** to all 14 CEE-IT users.
7. **Run for 3–5 business days** to capture representative traffic volume.

## Phase 3: Success/Failure Analysis

### Data Sources

- SignatureService structured logs (every message logged with outcome)
- On-prem sink mailbox (actual processed messages for visual inspection)
- ETR message trace (total messages that hit the rule — baseline count)

### Metrics to Capture Per Message (in service logs)

| Field | Purpose |
|---|---|
| `MessageId` | Correlation |
| `Sender` | Per-user breakdown |
| `Subject` (first 5 chars or hash) | Pattern matching |
| `MessageType` | New / Reply / Forward |
| `ClientFamily` | Outlook / OWA / Mobile / etc. |
| `BoundaryDetector` | Which detector fired (or "None") |
| `InjectionOutcome` | SignatureApplied / NoMatchingRule / Skipped / Error |
| `InjectionPlacement` | BeforeQuotedReply / BeforeBodyClose |
| `ProcessingTimeMs` | Performance |
| `ErrorDetail` | If failed, why |

### Analysis Queries (after 3–5 day window)

1. **Overall success rate** — `InjectionOutcome == SignatureApplied / total messages * 100`
2. **Boundary detection rate for replies/forwards** — `BoundaryDetector != "None" / (MessageType in Reply, Forward) * 100` — this is the key metric, target ≥98%
3. **Failure breakdown** — group errors by `ErrorDetail` to find systematic issues
4. **Per-client breakdown** — detection rate by `ClientFamily` to spot problematic clients
5. **Placement accuracy** — for replies/forwards, what % got `BeforeQuotedReply` vs `BeforeBodyClose` (fallback)
6. **Visual spot-check** — pull 20–30 random processed messages from the sink mailbox, open them, visually confirm signature placement looks correct. Prioritize replies/forwards.

### Success Criteria

- Zero processing errors (no crashes/exceptions)
- ≥98% boundary detection on replies/forwards from human senders
- Visual inspection confirms correct placement in all spot-checked messages
- Processing time <500ms p99

### If Boundary Detection <98%

Pull the failed specimens from logs, run the same fingerprint analysis, identify new patterns, fix, redeploy, repeat.
