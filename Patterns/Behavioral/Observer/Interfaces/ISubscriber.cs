namespace Patterns.Behavioral.Observer.Interfaces;

public interface ISubscriber
{
    string Username { get; set; }
    void AcceptNotification(IStreamer streamer);
}