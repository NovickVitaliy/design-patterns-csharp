using Patterns.Behavioral.Mediator.Interfaces;
using Patterns.Behavioral.Mediator.Models;

namespace Patterns.Behavioral.Mediator.Implementations;

public class Chat : IChat
{
    private readonly Dictionary<string, ChatUser> _chatUsers = new();
    public void SendMessageGlobally(string from, string message)
    {
        Console.WriteLine($"GLOBAL -> {from}: {message}");
    }

    public void SendMessagePrivately(string from, string to, string message)
    {
        ChatUser? user = _chatUsers.GetValueOrDefault(to);
        if (user == null || user.Username == from)
        {
            Console.WriteLine("Invalid user");
            return;
        }
        
        user.ReceivePrivateMessage(from, message);
    }

    public void EnterChatApplication(ChatUser chatUser)
    {
        var added = _chatUsers.TryAdd(chatUser.Username, chatUser);
        if (!added)
        {
            Console.WriteLine("User already entered chat");
        }

        chatUser.Chat = this;
    }
}