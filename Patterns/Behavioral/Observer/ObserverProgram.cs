using Patterns.Behavioral.Observer.Interfaces;
using Patterns.Behavioral.Observer.Models;

namespace Patterns.Behavioral.Observer;

public class ObserverProgram
{
    public static void ObserverMain(string[] args)
    {
        StreamingPlatform streamingPlatform = new StreamingPlatform();
        
        streamingPlatform.RegisterStreamer("quartz");
        streamingPlatform.RegisterStreamer("fortniteOnTop");
        streamingPlatform.RegisterStreamer("obiwan");

        ISubscriber firstSubscriber = new Subscriber("first");
        ISubscriber secondSubscriber = new Subscriber("second");
        ISubscriber thirdSubscriber = new Subscriber("third");
        
        streamingPlatform.SubscribeTo(firstSubscriber, "quartz");
        streamingPlatform.SubscribeTo(firstSubscriber, "fortniteOnTop");
        streamingPlatform.SubscribeTo(firstSubscriber, "obiwan");
        
        streamingPlatform.SubscribeTo(secondSubscriber, "obiwan");
        streamingPlatform.SubscribeTo(secondSubscriber, "quartz");
        
        streamingPlatform.SubscribeTo(thirdSubscriber, "obiwan");
        
        streamingPlatform.StartStreaming("quartz");

        Console.WriteLine("=========================================");
        
        streamingPlatform.StartStreaming("obiwan");

        Console.WriteLine("=========================================");
        
        streamingPlatform.UnsubscribeFrom(firstSubscriber, "quartz");
        
        streamingPlatform.StartStreaming("quartz");
    }
}