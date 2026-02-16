#!/usr/bin/env pwsh
<#
.SYNOPSIS
    Deploys SmtpRelay to Azure: Storage Account + ACR + ACI with Managed Identity.
.DESCRIPTION
    Creates all Azure resources, builds and pushes the Docker image to ACR,
    and deploys the container to ACI with a system-assigned managed identity
    and RBAC roles for Azure Storage (no shared key auth).
.PARAMETER ResourceGroup
    Azure resource group name. Will be created if it doesn't exist.
.PARAMETER Location
    Azure region (default: northeurope).
.PARAMETER BaseName
    Base name for all resources (default: smtprelay). Must be lowercase alphanumeric.
#>
param(
    [string]$ResourceGroup = "rg-smtprelay",
    [string]$Location = "northeurope",
    [string]$BaseName = "smtprelay"
)

$ErrorActionPreference = "Stop"

# Derive resource names (storage and ACR names must be globally unique, lowercase, no hyphens)
$suffix = (Get-Random -Minimum 1000 -Maximum 9999).ToString()
$StorageAccountName = "${BaseName}stor${suffix}"
$AcrName = "${BaseName}acr${suffix}"
$ContainerName = "${BaseName}-aci"
$ImageName = "smtp-relay"
$ImageTag = "latest"

Write-Host "=== SmtpRelay Azure Deployment (Managed Identity) ===" -ForegroundColor Cyan
Write-Host "Resource Group : $ResourceGroup"
Write-Host "Location       : $Location"
Write-Host "Storage Account: $StorageAccountName"
Write-Host "ACR            : $AcrName"
Write-Host "ACI            : $ContainerName"
Write-Host ""

# 1. Resource Group
Write-Host "[1/9] Creating resource group..." -ForegroundColor Yellow
az group create --name $ResourceGroup --location $Location --output none

# 2. Storage Account
Write-Host "[2/9] Creating storage account..." -ForegroundColor Yellow
az storage account create `
    --name $StorageAccountName `
    --resource-group $ResourceGroup `
    --location $Location `
    --sku Standard_LRS `
    --kind StorageV2 `
    --min-tls-version TLS1_2 `
    --output none

$StorageId = az storage account show `
    --name $StorageAccountName `
    --resource-group $ResourceGroup `
    --query id `
    --output tsv

Write-Host "  Storage account created." -ForegroundColor Green

# 3. Pre-create storage resources (blob container, queue, table) using CLI auth
Write-Host "[3/9] Creating storage containers, queue, and table..." -ForegroundColor Yellow
az storage container create `
    --name raw-emails `
    --account-name $StorageAccountName `
    --auth-mode login `
    --output none

az storage queue create `
    --name email-processing `
    --account-name $StorageAccountName `
    --auth-mode login `
    --output none

az storage table create `
    --name EmailMetadata `
    --account-name $StorageAccountName `
    --auth-mode login `
    --output none 2>$null

Write-Host "  Storage resources created." -ForegroundColor Green

# 4. ACR
Write-Host "[4/9] Creating container registry..." -ForegroundColor Yellow
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

# 5. Build and push Docker image
Write-Host "[5/9] Building and pushing Docker image..." -ForegroundColor Yellow
$ScriptDir = $PSScriptRoot
$ProjectDir = Join-Path $ScriptDir ".." "SmtpRelay"

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

Write-Host "  Image pushed: ${AcrLoginServer}/${ImageName}:${ImageTag}" -ForegroundColor Green

# 6. Deploy ACI with system-assigned managed identity
Write-Host "[6/9] Deploying container instance with managed identity..." -ForegroundColor Yellow
az container create `
    --resource-group $ResourceGroup `
    --name $ContainerName `
    --image "${AcrLoginServer}/${ImageName}:${ImageTag}" `
    --registry-login-server $AcrLoginServer `
    --registry-username $AcrUsername `
    --registry-password $AcrPassword `
    --cpu 1 `
    --memory 1 `
    --ports 25 `
    --protocol TCP `
    --ip-address Public `
    --os-type Linux `
    --restart-policy Always `
    --assign-identity `
    --environment-variables `
        "AzureStorage__AccountName=$StorageAccountName" `
        "Smtp__Port=25" `
        "Smtp__ServerName=smtp-relay" `
    --output none

# 7. Assign RBAC roles for the managed identity
Write-Host "[7/9] Assigning RBAC roles..." -ForegroundColor Yellow
$PrincipalId = az container show `
    --resource-group $ResourceGroup `
    --name $ContainerName `
    --query identity.principalId `
    --output tsv

# Storage Blob Data Contributor
az role assignment create `
    --assignee-object-id $PrincipalId `
    --assignee-principal-type ServicePrincipal `
    --role "Storage Blob Data Contributor" `
    --scope $StorageId `
    --output none

# Storage Queue Data Contributor
az role assignment create `
    --assignee-object-id $PrincipalId `
    --assignee-principal-type ServicePrincipal `
    --role "Storage Queue Data Contributor" `
    --scope $StorageId `
    --output none

# Storage Table Data Contributor
az role assignment create `
    --assignee-object-id $PrincipalId `
    --assignee-principal-type ServicePrincipal `
    --role "Storage Table Data Contributor" `
    --scope $StorageId `
    --output none

Write-Host "  RBAC roles assigned to MI principal: $PrincipalId" -ForegroundColor Green

# 8. Restart container so it picks up the RBAC assignments
Write-Host "[8/9] Restarting container..." -ForegroundColor Yellow
az container restart --resource-group $ResourceGroup --name $ContainerName
Start-Sleep -Seconds 15

# 9. Get public IP
Write-Host "[9/9] Retrieving public IP..." -ForegroundColor Yellow
$PublicIp = az container show `
    --resource-group $ResourceGroup `
    --name $ContainerName `
    --query ipAddress.ip `
    --output tsv

Write-Host ""
Write-Host "=== Deployment Complete ===" -ForegroundColor Green
Write-Host "Public IP (SMTP port 25): $PublicIp" -ForegroundColor Cyan
Write-Host "Auth: System-Assigned Managed Identity (no shared keys)" -ForegroundColor Cyan
Write-Host ""
Write-Host "Test with:" -ForegroundColor Yellow
Write-Host "  Send-MailMessage -SmtpServer $PublicIp -From test@example.com -To crm@example.com -Subject 'Test' -Body 'Hello'" -ForegroundColor White
Write-Host ""
Write-Host "Monitor logs:" -ForegroundColor Yellow
Write-Host "  az container logs --resource-group $ResourceGroup --name $ContainerName --follow" -ForegroundColor White
Write-Host ""
Write-Host "Storage Account: $StorageAccountName (Managed Identity auth)" -ForegroundColor White
Write-Host ""

# Save deployment info for other scripts
$deployInfo = @{
    ResourceGroup      = $ResourceGroup
    Location           = $Location
    StorageAccountName = $StorageAccountName
    AcrName            = $AcrName
    AcrLoginServer     = $AcrLoginServer
    ContainerName      = $ContainerName
    PublicIp           = $PublicIp
    ManagedIdentityPrincipalId = $PrincipalId
}
$deployInfo | ConvertTo-Json | Set-Content (Join-Path $ScriptDir "deploy-info.json")
Write-Host "Deployment info saved to deploy/deploy-info.json" -ForegroundColor Gray
