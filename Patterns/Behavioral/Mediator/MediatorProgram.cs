using Patterns.Behavioral.Mediator.Implementations;
using Patterns.Behavioral.Mediator.Interfaces;
using Patterns.Behavioral.Mediator.Models;

namespace Patterns.Behavioral.Mediator;

public class MediatorProgram
{
    public static void MediatorMain(string[] args)
    {
        IChat chat = new Chat();
        ChatUser user1 = new ChatUser("Vitalii");
        ChatUser user2 = new ChatUser("Dude");
        ChatUser user3 = new ChatUser("Chel");
        
        chat.EnterChatApplication(user1);
        chat.EnterChatApplication(user2);
        chat.EnterChatApplication(user3);
        
        user1.SendMessageGlobally("Hello world");
        user2.SendMessageGlobally("Hello world");
        user3.SendMessageGlobally("Hello world");
        user2.SendMessagePrivately("Chel", "Hello chel");
        user3.SendMessagePrivately("Vitalii", "Hello vitalii");
        user1.SendMessagePrivately("Vitalii", "Hello vitalii");
    }
}