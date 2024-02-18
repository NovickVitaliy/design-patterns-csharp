using Patterns.Structural.Proxy.ProxyAsLogging.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsLogging.Implementations;

public class LoggedInternetService : IInternetService
{
    private readonly IInternetService _internetService;

    public LoggedInternetService(IInternetService internetService)
    {
        _internetService = internetService;
    }

    public void PerformCall()
    {
        Console.WriteLine($"[{DateTime.UtcNow:G}] LoggedInternetService.PerformCall() started");
        _internetService.PerformCall();
        Console.WriteLine($"[{DateTime.UtcNow:G}] LoggedInternetService.PerformCall() finished");
    }
}