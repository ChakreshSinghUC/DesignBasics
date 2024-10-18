using System;

public class SubscriberA
{
    public void OnMessageReceived(object sender, MessageEventArgs e)
    {
        Console.WriteLine($"Subscriber A received message: {e.Message}");
    }
}

public class SubscriberB
{
    public void OnMessageReceived(object sender, MessageEventArgs e)
    {
        Console.WriteLine($"Subscriber B received message: {e.Message}");
    }
}
