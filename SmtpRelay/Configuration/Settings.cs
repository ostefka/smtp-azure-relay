namespace SmtpRelay.Configuration;

public class SmtpSettings
{
    public int Port { get; set; } = 25;
    public string ServerName { get; set; } = "smtp-relay";
    public int MaxMessageSizeKb { get; set; } = 35840;
}

public class AzureStorageSettings
{
    public string ConnectionString { get; set; } = string.Empty;
    public string AccountName { get; set; } = string.Empty;
    public string BlobContainerName { get; set; } = "raw-emails";
    public string QueueName { get; set; } = "email-processing";
    public string TableName { get; set; } = "EmailMetadata";

    public bool UseManagedIdentity => !string.IsNullOrEmpty(AccountName);
    public Uri BlobServiceUri => new($"https://{AccountName}.blob.core.windows.net");
    public Uri QueueServiceUri => new($"https://{AccountName}.queue.core.windows.net");
    public Uri TableServiceUri => new($"https://{AccountName}.table.core.windows.net");
}

public class ProcessingSettings
{
    public int BatchSize { get; set; } = 32;
    public int VisibilityTimeoutSeconds { get; set; } = 120;
    public int MaxDequeueCount { get; set; } = 10;
}
