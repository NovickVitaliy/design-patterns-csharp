namespace Patterns.Structural.Proxy.ProxyAsLazyLoading.Interfaces;

public interface IDatabase
{
    IEnumerable<string> GetData();
}