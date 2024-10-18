public class Subscriber
{
    public string Name { get; }

    public Subscriber(string name)
    {
        Name = name;
    }

    public void SubscribeToQueue(MessageQueue queue)
    {
        queue.Subscribe(HandleMessage);
    }

    private void HandleMessage(string message)
    {
        Console.WriteLine($"{Name} received message: {message}");
    }
}
