namespace Patterns.Structural.Proxy.ProxyAsRestriction.Interfaces;

public interface IMinecraftServerDatabase
{
    IEnumerable<string> GetBannedUsers();
}