using System;
using System.Collections.Generic;
using System.Threading;

public class MessageQueue
{
    private readonly Queue<string> _messages = new Queue<string>();
    private readonly List<Action<string>> _subscribers = new List<Action<string>>();
    private readonly object _lock = new object();

    // Publisher adds a message to the queue
    public void Publish(string message)
    {
        lock (_lock)
        {
            _messages.Enqueue(message);
            Console.WriteLine($"Message published: {message}");
        }

        // Notify subscribers after publishing
        NotifySubscribers();
    }

    // Subscriber subscribes to the queue
    public void Subscribe(Action<string> subscriber)
    {
        lock (_lock)
        {
            _subscribers.Add(subscriber);
        }
    }

    // Method to notify all subscribers of new messages
    private void NotifySubscribers()
    {
        lock (_lock)
        {
            while (_messages.Count > 0)
            {
                var message = _messages.Dequeue();
                foreach (var subscriber in _subscribers)
                {
                    // Simulate subscriber handling
                    ThreadPool.QueueUserWorkItem(_ => subscriber(message));
                }
            }
        }
    }
}
