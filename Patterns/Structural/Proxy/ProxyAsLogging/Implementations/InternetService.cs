using Patterns.Structural.Proxy.ProxyAsLogging.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsLogging.Implementations;

public class InternetService : IInternetService
{
    public void PerformCall()
    {
        Console.WriteLine("Performing call to internet service...");
        Console.WriteLine("Call to internet service has been finished.");
    }
}