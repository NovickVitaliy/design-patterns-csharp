using Patterns.Behavioral.Observer.Interfaces;

namespace Patterns.Behavioral.Observer.Models;

public class Subscriber : ISubscriber
{
    public string Username { get; set; }

    public Subscriber(string username)
    {
        Username = username;
    }

    public void AcceptNotification(IStreamer streamer)
    {
        Console.WriteLine($"Hello {Username}! {streamer.Username} has started streaming!!!");
    }
}