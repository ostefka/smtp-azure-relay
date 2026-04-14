# SignatureService Session Resume — April 14, 2026

Use this file to brief a new Copilot chat session after reboot. Paste it or reference it.

---

## What We Built

**SignatureService** — An enterprise SMTP signature injection service for Exchange Online.

### Architecture
- **Store-and-forward**: SMTP ingest → raw .eml to filesystem → 250 OK → async worker processes → injects signature → forwards to EXO
- **Fail-open**: If ANYTHING fails, the original message is forwarded unmodified. **NO message loss ever.**
- **Circuit breaker**: 5 consecutive failures → bypass mode (forward raw) → 60s recovery probe
- **EXO IP filter**: Only accepts connections from EXO CIDR ranges (40.92.0.0/15, 40.107.0.0/16, 52.100.0.0/14, 104.47.0.0/17)
- **STARTTLS**: Let's Encrypt certificate for `InviaSignature.invia.eu`
- **Health endpoint**: HTTP on :8080 (/health, /ready, /metrics)

### Key Design Decisions
- Delay OK but message loss NOT acceptable
- Static identity mapping (no Graph API yet)
- Many accepted domains — process everything that arrives, EXO pre-filters upstream
- Reply boundary detection (10 HTML + 6 plain-text patterns)
- `X-Signature-Applied` header to prevent double-signing (EXO exception rule uses this)

### Project Structure — `SignatureService/`
```
Configuration/Settings.cs     — SmtpSettings, ForwardingSettings, StorageSettings, etc.
Domain/                        — SignatureRule, SignatureTemplate, ProcessingResult
Engine/                        — CircuitBreaker, ReplyBoundaryDetector, MessageInspector,
                                 RuleEvaluator, TemplateEngine, IdentityResolver, SignatureInjector
Services/                      — SmtpListenerService, SignatureProcessingWorker,
                                 MessageForwarder, ExoIpFilter, HealthCheckService
Storage/DurableMessageStore.cs — Filesystem durable queue (/data/pending, /data/poison)
templates/                     — default.html, default.txt ({{placeholder}} syntax)
```

### Tech Stack
- .NET 8.0 Worker SDK
- SmtpServer 10.0.1 (IMPORTANT: uses `Task<bool>` not `Task<MailboxFilterResult>` for IMailboxFilter)
- MimeKit 4.10.0, MailKit 4.10.0
- Serilog (Console + File sinks)

---

## What's Deployed in Azure

**Tenant**: Invia Global (rockawaytravel.onmicrosoft.com)  
**Subscription**: CEE-IT-Infrastructure (`f6c1b3db-b3fd-4f9d-9553-aff612cf4a11`)

| Resource | Name | Details |
|---|---|---|
| Resource Group | ItApp-SignatureService | westeurope |
| Log Analytics | ItApp-SignatureService-LA | 30 day retention |
| Storage Account | sigsvcstore | LRS, file share: sigdata |
| VNET | sigsvc-vnet | 10.100.0.0/16 |
| Subnet | containerapp-subnet | 10.100.0.0/23, delegated to Microsoft.App |
| Container Apps Env | sigsvc-env | VNET-integrated (TCP ingress requires VNET) |
| Container App | sigsvc-app | 1 replica, TCP ingress port 25 |
| ACR | InviaItContainerHub | Shared, image: signature-service:latest |
| Static IP | 20.73.110.144 | |
| DNS A record | InviaSignature.invia.eu → 20.73.110.144 | confirmed working |
| TLS cert | Let's Encrypt, CN=inviasignature.invia.eu | expires 2026-07-12 |

**IMPORTANT**: The Azure Container Apps env was **deleted** just before this session ended (see terminal history: `az containerapp env delete --name sigsvc-env`). It needs to be **recreated** before the service can run again. The storage account, VNET, and other resources still exist.

### Azure Login
Session uses isolated `.azure/` config dir:
```bash
export AZURE_CONFIG_DIR="$(pwd)/.azure"
az login --use-device-code
# Select [5] CEE-IT-Infrastructure
```

### Build & Push to ACR
```bash
cd SignatureService
docker build -t signature-service:latest .
ACR_USER=$(az acr credential show -n InviaItContainerHub --query username -o tsv)
ACR_PASS=$(az acr credential show -n InviaItContainerHub --query 'passwords[0].value' -o tsv)
docker login inviaitcontainerhub.azurecr.io -u "$ACR_USER" -p "$ACR_PASS"
docker tag signature-service:latest inviaitcontainerhub.azurecr.io/signature-service:latest
docker push inviaitcontainerhub.azurecr.io/signature-service:latest
```

### TLS Certificate
- PFX at: Azure Files `sigdata/certs/smtp.pfx` (password: `SigSvcTls2026!`)
- Local copy: `/tmp/smtp.pfx` (root-owned, may be gone after reboot)
- Let's Encrypt PEM source: `/etc/letsencrypt/live/inviasignature.invia.eu/` (privkey.pem, fullchain.pem)
- To regenerate PFX:
  ```bash
  sudo openssl pkcs12 -export -out /tmp/smtp.pfx \
    -inkey /etc/letsencrypt/live/inviasignature.invia.eu/privkey.pem \
    -in /etc/letsencrypt/live/inviasignature.invia.eu/fullchain.pem \
    -passout pass:SigSvcTls2026!
  ```

### Container App Environment Variables
```
Smtp__Port=25
Smtp__ServerName=InviaSignature.invia.eu
Smtp__TlsCertificatePath=/data/certs/smtp.pfx
Smtp__TlsCertificatePassword=SigSvcTls2026!
Forwarding__SmtpHost=rockawaytravel.mail.protection.outlook.com
Forwarding__SmtpPort=25
Forwarding__UseTls=true
Storage__BasePath=/data
HealthCheck__Port=8080
Smtp__AllowedClientCidrs__0=40.92.0.0/15
Smtp__AllowedClientCidrs__1=40.107.0.0/16
Smtp__AllowedClientCidrs__2=52.100.0.0/14
Smtp__AllowedClientCidrs__3=104.47.0.0/17
```

---

## What's NOT Done Yet

1. **Redeploy Container Apps env** — env was deleted, needs recreation with VNET (see deploy script or recreate manually)
2. **EXO outbound connector** — Create in Exchange Admin Center: smart host `InviaSignature.invia.eu`, TLS required, certificate match on `inviasignature.invia.eu`
3. **EXO mail flow rule** — Redirect outbound mail through the connector; exception: if header `X-Signature-Applied` exists, skip
4. **SPF record** — Add `ip4:20.73.110.144` to SPF for all sending domains
5. **Graph API integration** — Currently uses static identity resolver; future: resolve sender identity from Entra ID
6. **BCC shadow validation** — Test with BCC copy before enabling live flow
7. **Cert renewal automation** — Current cert is manual; set up `--manual-auth-hook` or switch to Azure managed cert

---

## Known Gotchas

- **TCP ingress requires VNET** — Container Apps external TCP ingress only works with a custom VNET. Cannot use default env.
- **SmtpServer 10.0.1 API** — `IMailboxFilter.CanAcceptFromAsync` returns `Task<bool>`, NOT `Task<MailboxFilterResult>` (newer versions changed this)
- **ExoIpFilter implements both IMailboxFilter + IMailboxFilterFactory** — Register with explicit cast: `serviceProvider.Add((IMailboxFilterFactory)_ipFilter)` to avoid ambiguous overload
- **Shell variables lost across terminal sessions** — Always re-fetch storage keys, ACR creds etc. after new login
- **MimeKit NU1902 advisory** — Known NuGet advisory, not a real issue for this use case
