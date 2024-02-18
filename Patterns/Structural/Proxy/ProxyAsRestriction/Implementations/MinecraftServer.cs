using Patterns.Structural.Proxy.ProxyAsRestriction.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsRestriction.Implementations;

public class MinecraftServer : IMinecraftServer
{
    public void ConnectToServer(string username)
    {
        Console.WriteLine($"{username} has connected to minecraft server!");
    }
}