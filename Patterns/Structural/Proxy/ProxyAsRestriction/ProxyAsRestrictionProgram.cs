using Patterns.Structural.Proxy.ProxyAsRestriction.Implementations;
using Patterns.Structural.Proxy.ProxyAsRestriction.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsRestriction;

public class ProxyAsRestrictionProgram
{
    public static void ProxyAsRestrictionMain(string[] args)
    {
        IMinecraftServer minecraftServer = new RestrictedMinecraftServer(new MinecraftServerDatabase(), new MinecraftServer());
        minecraftServer.ConnectToServer("vitalick");
        minecraftServer.ConnectToServer("quartzRT");
    }
}