using System;

class Program
{
    static void Main(string[] args)
    {
        // Create publisher
        var publisher = new Publisher();

        // Create subscribers
        var subscriberA = new SubscriberA();
        var subscriberB = new SubscriberB();

        // Subscribe to the publisher's event
        publisher.MessagePublished += subscriberA.OnMessageReceived;
        publisher.MessagePublished += subscriberB.OnMessageReceived;

        // Publisher sends out messages
        Console.WriteLine("Publishing a message...");
        publisher.PublishMessage("Hello Subscribers!");

        // Publishing a second message
        Console.WriteLine("Publishing another message...");
        publisher.PublishMessage("Pub/Sub model in action!");

        // Unsubscribe SubscriberA
        Console.WriteLine("Unsubscribing Subscriber A...");
        publisher.MessagePublished -= subscriberA.OnMessageReceived;

        // Publish another message after unsubscribing
        Console.WriteLine("Publishing a final message...");
        publisher.PublishMessage("Goodbye!");
    }
}
