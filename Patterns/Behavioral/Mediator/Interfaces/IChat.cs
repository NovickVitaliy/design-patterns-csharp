using Patterns.Behavioral.Mediator.Models;

namespace Patterns.Behavioral.Mediator.Interfaces;

public interface IChat
{
    void SendMessageGlobally(string from, string message);
    void SendMessagePrivately(string from, string to, string message);
    void EnterChatApplication(ChatUser chatUser);
}