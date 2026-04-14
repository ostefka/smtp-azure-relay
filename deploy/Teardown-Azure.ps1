#!/usr/bin/env pwsh
<#
.SYNOPSIS
    Tears down all Azure resources created by Deploy-Azure.ps1.
#>
param(
    [string]$ResourceGroup = "rg-smtprelay"
)

Write-Host "Deleting resource group '$ResourceGroup' and all contained resources..." -ForegroundColor Yellow
az group delete --name $ResourceGroup --yes --no-wait
Write-Host "Deletion initiated (runs in background). Use 'az group show -n $ResourceGroup' to check status." -ForegroundColor Green
