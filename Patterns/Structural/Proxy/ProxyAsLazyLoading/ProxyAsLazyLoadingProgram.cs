using Patterns.Structural.Proxy.ProxyAsLazyLoading.Implementations;
using Patterns.Structural.Proxy.ProxyAsLazyLoading.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsLazyLoading;

public class ProxyAsLazyLoadingProgram
{
    public static void ProxyAsLazyLoadingMain(string[] args)
    {
        IDatabase database = new LazyDatabase();
        foreach (var s in database.GetData())
        {
            Console.WriteLine(s);
        }
    }
}