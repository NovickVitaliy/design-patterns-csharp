using Patterns.Structural.Proxy.ProxyAsLazyLoading.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsLazyLoading.Implementations;

public class LazyDatabase : IDatabase
{
    private IDatabase _database;
    public IEnumerable<string> GetData()
    {
        if (_database == null)
        {
            _database = new Database();
        }

        return _database.GetData();
    }
}