class Program
{
    static void Main(string[] args)
    {
        // Create a message queue (broker)
        var messageQueue = new MessageQueue();

        // Create the publisher and pass the queue to it
        var publisher = new Publisher(messageQueue);

        // Create subscribers
        var subscriberA = new Subscriber("Subscriber A");
        var subscriberB = new Subscriber("Subscriber B");

        // Subscribe subscribers to the message queue
        subscriberA.SubscribeToQueue(messageQueue);
        subscriberB.SubscribeToQueue(messageQueue);

        // Publish messages to the queue
        Console.WriteLine("Publishing a message...");
        publisher.PublishMessage("Hello from the Publisher!");

        // Publish another message
        Console.WriteLine("Publishing another message...");
        publisher.PublishMessage("Message queues in Pub/Sub systems!");

        // Keep the console open
        Console.ReadLine();
    }
}
