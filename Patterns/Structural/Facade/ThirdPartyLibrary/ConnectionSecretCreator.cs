namespace Patterns.Structural.Facade.ThirdPartyLibrary;

public static class ConnectionSecretCreator
{
    public static string GetSecret(string username)
    {
        return $"Some secret key for user {username.ToLower()}";
    }
}