#!/usr/bin/env pwsh
<#
.SYNOPSIS
    Deploys SmtpSignatureProxy to Azure Container Instances.
.PARAMETER ResourceGroup
    Azure resource group name.
.PARAMETER Location
    Azure region (default: northeurope).
.PARAMETER BaseName
    Base name for resources (default: sigproxy).
.PARAMETER ForwardingHost
    EXO MX endpoint, e.g. "yourdomain.mail.protection.outlook.com"
#>
param(
    [string]$ResourceGroup = "rg-sigproxy",
    [string]$Location = "northeurope",
    [string]$BaseName = "sigproxy",
    [Parameter(Mandatory)]
    [string]$ForwardingHost
)

$ErrorActionPreference = "Stop"

$suffix = (Get-Random -Minimum 1000 -Maximum 9999).ToString()
$AcrName = "${BaseName}acr${suffix}"
$ContainerName = "${BaseName}-aci"
$ImageName = "signature-proxy"
$ImageTag = "latest"

Write-Host "=== SmtpSignatureProxy Deployment ===" -ForegroundColor Cyan
Write-Host "Resource Group  : $ResourceGroup"
Write-Host "Location        : $Location"
Write-Host "ACR             : $AcrName"
Write-Host "Forwarding Host : $ForwardingHost"
Write-Host ""

# 1. Resource Group
Write-Host "[1/5] Creating resource group..." -ForegroundColor Yellow
az group create --name $ResourceGroup --location $Location --output none

# 2. ACR
Write-Host "[2/5] Creating container registry..." -ForegroundColor Yellow
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

# 3. Build and push
Write-Host "[3/5] Building and pushing Docker image..." -ForegroundColor Yellow
$ScriptDir = $PSScriptRoot
$ProjectDir = Join-Path $ScriptDir ".." "SmtpSignatureProxy"

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

# 4. Deploy ACI
Write-Host "[4/5] Deploying container instance..." -ForegroundColor Yellow
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
    --environment-variables `
        "Forwarding__SmtpHost=$ForwardingHost" `
        "Smtp__Port=25" `
        "Smtp__ServerName=signature-proxy" `
    --output none

# 5. Get public IP
Write-Host "[5/5] Retrieving public IP..." -ForegroundColor Yellow
$PublicIp = az container show `
    --resource-group $ResourceGroup `
    --name $ContainerName `
    --query ipAddress.ip `
    --output tsv

Write-Host ""
Write-Host "=== Deployment Complete ===" -ForegroundColor Green
Write-Host "Public IP (SMTP port 25): $PublicIp" -ForegroundColor Cyan
Write-Host "Forwarding to           : $ForwardingHost" -ForegroundColor Cyan
Write-Host ""
Write-Host "EXO Setup:" -ForegroundColor Yellow
Write-Host "  1. Create inbound connector accepting mail from $PublicIp" -ForegroundColor White
Write-Host "  2. Create mail flow rule:" -ForegroundColor White
Write-Host "     - Condition: sent to external recipients" -ForegroundColor White
Write-Host "     - Exception: header 'X-Signature-Applied' contains 'true'" -ForegroundColor White
Write-Host "     - Action: redirect to $PublicIp" -ForegroundColor White
Write-Host ""
Write-Host "Test with:" -ForegroundColor Yellow
Write-Host "  .\tests\Send-SignatureProxyTest.ps1 -SmtpServer $PublicIp" -ForegroundColor White
Write-Host ""
Write-Host "Monitor:" -ForegroundColor Yellow
Write-Host "  az container logs --resource-group $ResourceGroup --name $ContainerName --follow" -ForegroundColor White

$deployInfo = @{
    ResourceGroup  = $ResourceGroup
    Location       = $Location
    AcrName        = $AcrName
    AcrLoginServer = $AcrLoginServer
    ContainerName  = $ContainerName
    PublicIp       = $PublicIp
    ForwardingHost = $ForwardingHost
}
$deployInfo | ConvertTo-Json | Set-Content (Join-Path $ScriptDir "sigproxy-deploy-info.json")
Write-Host "Deployment info saved to deploy/sigproxy-deploy-info.json" -ForegroundColor Gray
