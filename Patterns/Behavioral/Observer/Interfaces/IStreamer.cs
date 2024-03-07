namespace Patterns.Behavioral.Observer.Interfaces;

public interface IStreamer
{
    string Username { get; set; }
    ICollection<ISubscriber> Subscribers { get; set; }
    void NotifySubscribers();
    void AddSubscriber(ISubscriber subscriber);
    void RemoveSubscriber(ISubscriber subscriber);
}