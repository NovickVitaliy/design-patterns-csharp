using Patterns.Behavioral.Mediator.Interfaces;

namespace Patterns.Behavioral.Mediator.Models;

public class ChatUser
{
    private string _username;
    private IChat _chat;

    public string Username
    {
        get => _username;
        set => _username = value ?? throw new ArgumentNullException(nameof(value));
    }

    public IChat Chat
    {
        get => _chat;
        set => _chat = value ?? throw new ArgumentNullException(nameof(value));
    }

    public ChatUser(string username)
    {
        _username = username;
    }

    public void SendMessageGlobally(string message)
    {
        _chat.SendMessageGlobally(_username, message);
    }

    public void SendMessagePrivately(string to, string message)
    {
        _chat.SendMessagePrivately(_username, to, message);
    }

    public void ReceivePrivateMessage(string from, string message)
    {
        Console.WriteLine($"PRIVATE -> {from} to {_username}: {message}");
    }
}