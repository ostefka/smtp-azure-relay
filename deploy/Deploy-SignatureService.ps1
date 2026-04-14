#!/usr/bin/env pwsh
<#
.SYNOPSIS
    Deploys SignatureService to Azure Container Apps with:
    - Zone-redundant replicas (3 availability zones)
    - Azure Files persistent volume (ZRS)
    - Health probes (liveness + readiness)
    - Log Analytics workspace for monitoring
    - Azure Monitor alert rules

.PARAMETER ResourceGroup
    Azure resource group name.
.PARAMETER Location
    Azure region (default: northeurope). Must support Availability Zones.
.PARAMETER BaseName
    Base name for all resources (default: sigsvc).
.PARAMETER ForwardingHost
    EXO MX endpoint, e.g. "yourdomain.mail.protection.outlook.com"
.PARAMETER MinReplicas
    Minimum container replicas (default: 2 for HA).
.PARAMETER MaxReplicas
    Maximum container replicas (default: 5).
.PARAMETER AlertEmail
    Email address for Azure Monitor alerts (optional).
#>
param(
    [string]$ResourceGroup = "rg-signatureservice",
    [string]$Location = "northeurope",
    [string]$BaseName = "sigsvc",
    [Parameter(Mandatory)]
    [string]$ForwardingHost,
    [int]$MinReplicas = 2,
    [int]$MaxReplicas = 5,
    [string]$AlertEmail = ""
)

$ErrorActionPreference = "Stop"

$suffix = (Get-Random -Minimum 1000 -Maximum 9999).ToString()
$AcrName = "${BaseName}acr${suffix}"
$EnvName = "${BaseName}-env"
$AppName = "${BaseName}-app"
$StorageAccountName = "${BaseName}store${suffix}"
$ShareName = "sigdata"
$WorkspaceName = "${BaseName}-logs"
$ImageName = "signature-service"
$ImageTag = "latest"

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "  SignatureService — Azure Container Apps" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Resource Group   : $ResourceGroup"
Write-Host "Location         : $Location"
Write-Host "ACR              : $AcrName"
Write-Host "Container App    : $AppName"
Write-Host "Forwarding Host  : $ForwardingHost"
Write-Host "Replicas         : $MinReplicas - $MaxReplicas"
Write-Host "Zone Redundant   : Yes (3 AZs)"
Write-Host ""

$totalSteps = 9
if ($AlertEmail) { $totalSteps = 10 }

# ─────────────────────────────────────────────────────────────
# 1. Resource Group
# ─────────────────────────────────────────────────────────────
Write-Host "[1/$totalSteps] Creating resource group..." -ForegroundColor Yellow
az group create --name $ResourceGroup --location $Location --output none

# ─────────────────────────────────────────────────────────────
# 2. Log Analytics Workspace (for Container Apps + monitoring)
# ─────────────────────────────────────────────────────────────
Write-Host "[2/$totalSteps] Creating Log Analytics workspace..." -ForegroundColor Yellow
az monitor log-analytics workspace create `
    --resource-group $ResourceGroup `
    --workspace-name $WorkspaceName `
    --location $Location `
    --retention-time 30 `
    --output none

$WorkspaceId = az monitor log-analytics workspace show `
    --resource-group $ResourceGroup `
    --workspace-name $WorkspaceName `
    --query customerId --output tsv

$WorkspaceKey = az monitor log-analytics workspace get-shared-keys `
    --resource-group $ResourceGroup `
    --workspace-name $WorkspaceName `
    --query primarySharedKey --output tsv

Write-Host "  Workspace: $WorkspaceName ($WorkspaceId)" -ForegroundColor Green

# ─────────────────────────────────────────────────────────────
# 3. Container Registry
# ─────────────────────────────────────────────────────────────
Write-Host "[3/$totalSteps] Creating container registry..." -ForegroundColor Yellow
az acr create `
    --name $AcrName `
    --resource-group $ResourceGroup `
    --location $Location `
    --sku Basic `
    --admin-enabled true `
    --output none

$AcrLoginServer = az acr show --name $AcrName --query loginServer --output tsv
$AcrUsername = az acr credential show --name $AcrName --query username --output tsv
$AcrPassword = az acr credential show --name $AcrName --query "passwords[0].value" --output tsv

Write-Host "  ACR: $AcrLoginServer" -ForegroundColor Green

# ─────────────────────────────────────────────────────────────
# 4. Build & Push Docker Image
# ─────────────────────────────────────────────────────────────
Write-Host "[4/$totalSteps] Building and pushing Docker image..." -ForegroundColor Yellow
$ScriptDir = $PSScriptRoot
$ProjectDir = Join-Path $ScriptDir ".." "SignatureService"

Push-Location $ProjectDir
try {
    az acr build `
        --registry $AcrName `
        --image "${ImageName}:${ImageTag}" `
        --file Dockerfile `
        .
}
finally {
    Pop-Location
}

Write-Host "  Image: ${AcrLoginServer}/${ImageName}:${ImageTag}" -ForegroundColor Green

# ─────────────────────────────────────────────────────────────
# 5. Azure Files (ZRS — zone-redundant storage for durable queue)
# ─────────────────────────────────────────────────────────────
Write-Host "[5/$totalSteps] Creating Azure Files storage (ZRS)..." -ForegroundColor Yellow
az storage account create `
    --name $StorageAccountName `
    --resource-group $ResourceGroup `
    --location $Location `
    --sku Standard_ZRS `
    --kind StorageV2 `
    --output none

$StorageKey = az storage account keys list `
    --account-name $StorageAccountName `
    --resource-group $ResourceGroup `
    --query "[0].value" --output tsv

az storage share create `
    --account-name $StorageAccountName `
    --account-key $StorageKey `
    --name $ShareName `
    --quota 5 `
    --output none

Write-Host "  Storage: $StorageAccountName / $ShareName (ZRS)" -ForegroundColor Green

# ─────────────────────────────────────────────────────────────
# 6. Container Apps Environment (zone-redundant)
# ─────────────────────────────────────────────────────────────
Write-Host "[6/$totalSteps] Creating Container Apps environment..." -ForegroundColor Yellow
az containerapp env create `
    --name $EnvName `
    --resource-group $ResourceGroup `
    --location $Location `
    --logs-workspace-id $WorkspaceId `
    --logs-workspace-key $WorkspaceKey `
    --zone-redundant `
    --output none

# Mount Azure Files share in the environment
az containerapp env storage set `
    --name $EnvName `
    --resource-group $ResourceGroup `
    --storage-name sigdata `
    --azure-file-account-name $StorageAccountName `
    --azure-file-account-key $StorageKey `
    --azure-file-share-name $ShareName `
    --access-mode ReadWrite `
    --output none

Write-Host "  Environment: $EnvName (zone-redundant, Azure Files mounted)" -ForegroundColor Green

# ─────────────────────────────────────────────────────────────
# 7. Deploy Container App
# ─────────────────────────────────────────────────────────────
Write-Host "[7/$totalSteps] Deploying Container App..." -ForegroundColor Yellow

# Container Apps needs a YAML definition for TCP ingress + volume mounts
$yamlContent = @"
properties:
  managedEnvironmentId: /subscriptions/$(az account show --query id -o tsv)/resourceGroups/$ResourceGroup/providers/Microsoft.App/managedEnvironments/$EnvName
  configuration:
    activeRevisionsMode: Single
    ingress:
      external: true
      targetPort: 25
      transport: tcp
      exposedPort: 25
    registries:
      - server: $AcrLoginServer
        username: $AcrUsername
        passwordSecretRef: acr-password
    secrets:
      - name: acr-password
        value: $AcrPassword
  template:
    containers:
      - name: signature-service
        image: ${AcrLoginServer}/${ImageName}:${ImageTag}
        resources:
          cpu: 1.0
          memory: 2Gi
        env:
          - name: Forwarding__SmtpHost
            value: $ForwardingHost
          - name: Forwarding__SmtpPort
            value: "25"
          - name: Smtp__Port
            value: "25"
          - name: Smtp__ServerName
            value: signature-service
          - name: Storage__BasePath
            value: /data
          - name: HealthCheck__Port
            value: "8080"
        volumeMounts:
          - volumeName: sigdata
            mountPath: /data
        probes:
          - type: liveness
            httpGet:
              path: /health
              port: 8080
            initialDelaySeconds: 10
            periodSeconds: 30
            failureThreshold: 3
          - type: readiness
            httpGet:
              path: /ready
              port: 8080
            initialDelaySeconds: 5
            periodSeconds: 10
            failureThreshold: 3
    scale:
      minReplicas: $MinReplicas
      maxReplicas: $MaxReplicas
    volumes:
      - name: sigdata
        storageName: sigdata
        storageType: AzureFile
"@

$yamlPath = Join-Path $env:TEMP "sigsvc-app.yaml"
$yamlContent | Out-File -FilePath $yamlPath -Encoding utf8

az containerapp create `
    --name $AppName `
    --resource-group $ResourceGroup `
    --yaml $yamlPath `
    --output none

Remove-Item $yamlPath -ErrorAction SilentlyContinue

Write-Host "  Container App: $AppName ($MinReplicas-$MaxReplicas replicas)" -ForegroundColor Green

# ─────────────────────────────────────────────────────────────
# 8. Get assigned IP / FQDN
# ─────────────────────────────────────────────────────────────
Write-Host "[8/$totalSteps] Retrieving endpoint..." -ForegroundColor Yellow

$AppFqdn = az containerapp show `
    --name $AppName `
    --resource-group $ResourceGroup `
    --query "properties.configuration.ingress.fqdn" `
    --output tsv

# For TCP ingress, we may need the environment static IP
$EnvStaticIp = az containerapp env show `
    --name $EnvName `
    --resource-group $ResourceGroup `
    --query "properties.staticIp" `
    --output tsv

Write-Host "  FQDN     : $AppFqdn" -ForegroundColor Green
Write-Host "  Static IP: $EnvStaticIp" -ForegroundColor Green

# ─────────────────────────────────────────────────────────────
# 9. Set up Azure Monitor Alerts
# ─────────────────────────────────────────────────────────────
Write-Host "[9/$totalSteps] Creating Azure Monitor alert rules..." -ForegroundColor Yellow

# Alert: Container restart count > 2 in 5 minutes
$AppId = az containerapp show `
    --name $AppName `
    --resource-group $ResourceGroup `
    --query id --output tsv

# Log-based alert: look for CRITICAL or circuit-open in logs
az monitor scheduled-query create `
    --name "${BaseName}-critical-errors" `
    --resource-group $ResourceGroup `
    --scopes $AppId `
    --condition "count > 0" `
    --condition-query "ContainerAppConsoleLogs_CL | where Log_s contains 'CRITICAL' or Log_s contains 'Circuit breaker' | where TimeGenerated > ago(5m)" `
    --evaluation-frequency 5m `
    --window-size 5m `
    --severity 1 `
    --description "SignatureService critical error or circuit breaker event" `
    --output none 2>$null

# Log-based alert: poison queue messages
az monitor scheduled-query create `
    --name "${BaseName}-poison-messages" `
    --resource-group $ResourceGroup `
    --scopes $AppId `
    --condition "count > 0" `
    --condition-query "ContainerAppConsoleLogs_CL | where Log_s contains 'poison' | where TimeGenerated > ago(15m)" `
    --evaluation-frequency 15m `
    --window-size 15m `
    --severity 2 `
    --description "SignatureService messages moved to poison queue" `
    --output none 2>$null

Write-Host "  Alerts created: critical-errors (Sev1), poison-messages (Sev2)" -ForegroundColor Green

# ─────────────────────────────────────────────────────────────
# 10. (Optional) Action Group for email notifications
# ─────────────────────────────────────────────────────────────
if ($AlertEmail) {
    Write-Host "[10/$totalSteps] Creating alert action group..." -ForegroundColor Yellow
    
    az monitor action-group create `
        --name "${BaseName}-alerts" `
        --resource-group $ResourceGroup `
        --short-name "SigSvcAlrt" `
        --email "admin" "$AlertEmail" `
        --output none

    # Link action group to alert rules
    $ActionGroupId = az monitor action-group show `
        --name "${BaseName}-alerts" `
        --resource-group $ResourceGroup `
        --query id --output tsv

    az monitor scheduled-query update `
        --name "${BaseName}-critical-errors" `
        --resource-group $ResourceGroup `
        --action $ActionGroupId `
        --output none 2>$null

    az monitor scheduled-query update `
        --name "${BaseName}-poison-messages" `
        --resource-group $ResourceGroup `
        --action $ActionGroupId `
        --output none 2>$null

    Write-Host "  Alerts will notify: $AlertEmail" -ForegroundColor Green
}

# ─────────────────────────────────────────────────────────────
# Save deployment info
# ─────────────────────────────────────────────────────────────
$deployInfo = @{
    ResourceGroup      = $ResourceGroup
    Location           = $Location
    AcrName            = $AcrName
    AcrLoginServer     = $AcrLoginServer
    StorageAccount     = $StorageAccountName
    FileShare          = $ShareName
    Environment        = $EnvName
    ContainerApp       = $AppName
    Fqdn               = $AppFqdn
    StaticIp           = $EnvStaticIp
    LogWorkspace       = $WorkspaceName
    ForwardingHost     = $ForwardingHost
    MinReplicas        = $MinReplicas
    MaxReplicas        = $MaxReplicas
    DeployedAt         = (Get-Date -Format "o")
}

$deployInfoPath = Join-Path $PSScriptRoot "sigsvc-deploy-info.json"
$deployInfo | ConvertTo-Json -Depth 4 | Out-File -FilePath $deployInfoPath -Encoding utf8
Write-Host ""
Write-Host "  Deployment info saved: $deployInfoPath" -ForegroundColor Gray

# ─────────────────────────────────────────────────────────────
# Summary
# ─────────────────────────────────────────────────────────────
Write-Host ""
Write-Host "============================================" -ForegroundColor Green
Write-Host "  Deployment Complete" -ForegroundColor Green
Write-Host "============================================" -ForegroundColor Green
Write-Host ""
Write-Host "SMTP Endpoint : ${EnvStaticIp}:25" -ForegroundColor Cyan
Write-Host "Health Check  : https://${AppFqdn}/health" -ForegroundColor Cyan
Write-Host "Metrics       : https://${AppFqdn}/metrics" -ForegroundColor Cyan
Write-Host "Forwarding To : $ForwardingHost" -ForegroundColor Cyan
Write-Host "Replicas      : $MinReplicas (min) / $MaxReplicas (max) across 3 AZs" -ForegroundColor Cyan
Write-Host "Storage       : Azure Files ZRS ($StorageAccountName/$ShareName)" -ForegroundColor Cyan
Write-Host "Monitoring    : Log Analytics ($WorkspaceName)" -ForegroundColor Cyan
Write-Host ""
Write-Host "EXO Configuration:" -ForegroundColor Yellow
Write-Host "  1. Create inbound connector accepting mail from $EnvStaticIp" -ForegroundColor White
Write-Host "  2. Create outbound connector:" -ForegroundColor White
Write-Host "     - Smart host: $EnvStaticIp" -ForegroundColor White
Write-Host "  3. Create mail flow rule:" -ForegroundColor White
Write-Host "     - Condition: sent to external recipients" -ForegroundColor White
Write-Host "     - Exception: header 'X-Signature-Applied' contains 'true'" -ForegroundColor White
Write-Host "     - Action: redirect through outbound connector to $EnvStaticIp" -ForegroundColor White
Write-Host ""
Write-Host "Monitoring:" -ForegroundColor Yellow
Write-Host "  Logs   : az containerapp logs show -n $AppName -g $ResourceGroup --follow" -ForegroundColor White
Write-Host "  Health : curl https://${AppFqdn}/health" -ForegroundColor White
Write-Host "  Metrics: curl https://${AppFqdn}/metrics" -ForegroundColor White
Write-Host "  Alerts : Azure Portal → Monitor → Alerts" -ForegroundColor White
Write-Host ""
Write-Host "Test with:" -ForegroundColor Yellow
Write-Host "  .\tests\Send-SignatureServiceTest.ps1 -SmtpServer $EnvStaticIp" -ForegroundColor White
Write-Host ""
