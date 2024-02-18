using Patterns.Structural.Proxy.ProxyAsLazyLoading.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsCachedLazyLoading;

public class CachedDatabase : IDatabase
{
    private readonly IDatabase _database;
    private readonly Dictionary<string, object?> _cache = new();
    private readonly TimeSpan _slidingTimeExpiration = TimeSpan.FromSeconds(5);
    private DateTime _lastTimeRetrieval;
    public CachedDatabase(IDatabase database)
    {
        _database = database;
    }

    public IEnumerable<string> GetData()
    {
        _lastTimeRetrieval = DateTime.UtcNow; ;
        if (_lastTimeRetrieval.Add(_slidingTimeExpiration) > DateTime.UtcNow)
        {
            if (_cache.TryGetValue("GetData()", out object? data))
            {
                return (IEnumerable<string>)data!;
            }
            data = _database.GetData();
            _cache.Add("GetData()", data);
            return (IEnumerable<string>)data;
        }

        var newData = _database.GetData();
        _cache.Remove("GetData()");
        _cache.Add("GetData()", newData);
        return newData;
    }
}