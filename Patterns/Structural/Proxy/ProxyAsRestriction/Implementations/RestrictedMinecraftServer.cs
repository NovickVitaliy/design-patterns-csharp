using Patterns.Structural.Proxy.ProxyAsRestriction.Interfaces;

namespace Patterns.Structural.Proxy.ProxyAsRestriction.Implementations;

public class RestrictedMinecraftServer : IMinecraftServer
{
    private List<string> _bannedUsers;
    private readonly IMinecraftServerDatabase _minecraftServerDatabase;
    private readonly IMinecraftServer _minecraftServer;

    public RestrictedMinecraftServer(
        IMinecraftServerDatabase minecraftServerDatabase, 
        IMinecraftServer minecraftServer)
    {
        _minecraftServerDatabase = minecraftServerDatabase;
        _minecraftServer = minecraftServer;
        LoadBannedPlayers();
    }

    private void LoadBannedPlayers()
    {
        _bannedUsers = _minecraftServerDatabase.GetBannedUsers().ToList();
    }

    public void ConnectToServer(string username)
    {
        if (_bannedUsers.Contains(username))
        {
            Console.WriteLine($"{username} is banned from connecting the server.");
            return;
        }
        _minecraftServer.ConnectToServer(username);
    }
}