using Patterns.Structural.Proxy.ProxyAsRestriction.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsRestriction.Implementations;

public class MinecraftServerDatabase : IMinecraftServerDatabase
{
    public IEnumerable<string> GetBannedUsers()
    {
        return new[] { "quartzRT", "chelik", "dude" };
    }
}