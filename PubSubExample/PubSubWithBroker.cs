using System;
using System.Collections.Generic;

public class EventBroker
{
    private readonly Dictionary<string, List<Action<string>>> _subscriptions = new Dictionary<string, List<Action<string>>>();

    // Subscribe to a specific event (or topic)
    public void Subscribe(string eventName, Action<string> subscriber)
    {
        if (!_subscriptions.ContainsKey(eventName))
        {
            _subscriptions[eventName] = new List<Action<string>>();
        }

        _subscriptions[eventName].Add(subscriber);
    }

    // Publish an event
    public void Publish(string eventName, string message)
    {
        if (_subscriptions.ContainsKey(eventName))
        {
            foreach (var subscriber in _subscriptions[eventName])
            {
                subscriber(message); // Invoke the subscriber's action
            }
        }
    }
}

public static class PubSubWithBroker
{
    public static void Run()
    {
        var broker = new EventBroker();

        // Subscriber 1 subscribes to "news" event
        broker.Subscribe("news", message => Console.WriteLine("Subscriber 1 received: " + message));

        // Subscriber 2 subscribes to "sports" event
        broker.Subscribe("sports", message => Console.WriteLine("Subscriber 2 received: " + message));

        // Publish messages to different topics
        broker.Publish("news", "Breaking News: Market hits all-time high!");
        broker.Publish("sports", "Sports Update: Local team wins championship!");
    }
}
