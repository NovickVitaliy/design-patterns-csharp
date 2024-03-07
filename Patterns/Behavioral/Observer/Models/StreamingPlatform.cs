using Patterns.Behavioral.Observer.Interfaces;

namespace Patterns.Behavioral.Observer.Models;

public class StreamingPlatform
{
    private IDictionary<string, IStreamer> _streamers;

    public StreamingPlatform()
    {
        _streamers = new Dictionary<string, IStreamer>();
    }

    public void RegisterStreamer(string username)
    {
        IStreamer streamer = new Streamer(username);

        _streamers.Add(username, streamer);
    }
    
    public void SubscribeTo(ISubscriber subscriber, string streamerUsername)
    {
        if (!_streamers.TryGetValue(streamerUsername.ToLower(), out var streamer))
        {
            Console.WriteLine("Streamer not found");
            return;
        }
        
        streamer.AddSubscriber(subscriber);
    }

    public void UnsubscribeFrom(ISubscriber subscriber, string streamerUsername)
    {
        if (!_streamers.TryGetValue(streamerUsername, out var streamer))
        {
            Console.WriteLine("Stream not found");
            return;
        }
        
        streamer.RemoveSubscriber(subscriber);
    }

    public void StartStreaming(string username)
    {
        if (!_streamers.TryGetValue(username, out var streamer))
        {
            Console.WriteLine("Streamer not found");
            return;
        }
        
        streamer.NotifySubscribers();
    }
}