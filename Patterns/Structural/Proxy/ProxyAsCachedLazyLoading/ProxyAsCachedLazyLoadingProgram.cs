using Patterns.Structural.Proxy.ProxyAsLazyLoading.Implementations;
using Patterns.Structural.Proxy.ProxyAsLazyLoading.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsCachedLazyLoading;

public class ProxyAsCachedLazyLoadingProgram
{
    public static void ProxyAsCachedLazyLoadingMain(string[] args)
    {
        IDatabase database = new CachedDatabase(new LazyDatabase());
        foreach (var s in database.GetData())
        {
            Console.WriteLine(s);
        }
        
        foreach (var s in database.GetData())
        {
            Console.WriteLine(s);
        }
        Thread.Sleep(3000);
        foreach (var s in database.GetData())
        {
            Console.WriteLine(s);
        }
    }
}