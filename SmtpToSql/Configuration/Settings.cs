namespace SmtpToSql.Configuration;

public class SmtpSettings
{
    public int Port { get; set; } = 25;
    public string ServerName { get; set; } = "localhost";
    public int MaxMessageSizeKb { get; set; } = 35840; // 35 MB
}

public class SqlSettings
{
    public string ConnectionString { get; set; } = string.Empty;
    public int BatchSize { get; set; } = 50;
    public int ProcessingIntervalSeconds { get; set; } = 5;
}

public class FallbackStorageSettings
{
    public string Path { get; set; } = @"C:\SmtpToSql\Fallback";
}
