using Patterns.Structural.Proxy.ProxyAsLogging.Implementations;
using Patterns.Structural.Proxy.ProxyAsLogging.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsLogging;

public class ProxyAsLoggingProgram
{
    public static void ProxyAsLoggingMain(string[] args)
    {
        IInternetService internetService = new LoggedInternetService(new InternetService());
        internetService.PerformCall();
    }
}