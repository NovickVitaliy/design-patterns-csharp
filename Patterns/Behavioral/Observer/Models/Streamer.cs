using Patterns.Behavioral.Observer.Interfaces;

namespace Patterns.Behavioral.Observer.Models;

public class Streamer : IStreamer
{
    public string Username { get; set; }
    public ICollection<ISubscriber> Subscribers { get; set; }

    public Streamer(string username)
    {
        Username = username;
        Subscribers = new List<ISubscriber>();
    }

    public void AddSubscriber(ISubscriber subscriber)
    {
        Subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(ISubscriber subscriber)
    {
        Subscribers.Remove(subscriber);
    }

    public void NotifySubscribers()
    {
        foreach (var subscriber in Subscribers)
        {
            subscriber.AcceptNotification(this);
        }
    }
}