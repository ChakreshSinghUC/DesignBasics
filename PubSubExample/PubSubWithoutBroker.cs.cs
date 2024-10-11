using System;
using System.Collections.Generic;

public class Publisher
{
    private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

    // Method to add subscribers
    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    // Method to notify all subscribers
    public void Publish(string message)
    {
        Console.WriteLine("Publisher: Sending message to all subscribers...");
        foreach (var subscriber in _subscribers)
        {
            subscriber.Receive(message);
        }
    }
}

// Define an interface for the Subscriber
public interface ISubscriber
{
    void Receive(string message);
}

// Concrete implementation of a Subscriber
public class ConcreteSubscriber : ISubscriber
{
    private string _name;

    public ConcreteSubscriber(string name)
    {
        _name = name;
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{_name} received message: {message}");
    }
}

public static class PubSubWithoutBroker
{
    public static void Run()
    {
        // Create a Publisher
        var publisher = new Publisher();

        // Create Subscribers
        var subscriber1 = new ConcreteSubscriber("Subscriber 1");
        var subscriber2 = new ConcreteSubscriber("Subscriber 2");

        // Subscribe to the publisher
        publisher.Subscribe(subscriber1);
        publisher.Subscribe(subscriber2);

        // Publish a message
        publisher.Publish("Hello Subscribers!");
    }
}
