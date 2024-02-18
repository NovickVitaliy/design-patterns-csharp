using Patterns.Structural.Proxy.ProxyAsLazyLoading.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsLazyLoading.Implementations;

public class Database : IDatabase
{
    private IEnumerable<string> _data;
    public Database()
    {
        LoadData();
    }

    private void LoadData()
    {
        Thread.Sleep(3000);
        _data = new[] {"data1", "data2", "data3" };
    }

    public IEnumerable<string> GetData()
    {
        return _data;
    }
}