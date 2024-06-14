namespace Koshelek.Messaging.Infrastructure.Caching;

public class CacheSettings
{
    public bool UseDistributedCache { get; set; }
    public bool PreferRedis { get; set; }
    public string? ConnectionString { get; set; }
}