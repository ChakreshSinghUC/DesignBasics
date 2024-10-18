using System;

public class Publisher
{
    // Declare the event
    public event EventHandler<MessageEventArgs> MessagePublished;

    public void PublishMessage(string message)
    {
        // Raise the event and pass the message to subscribers
        OnMessagePublished(new MessageEventArgs(message));
    }

    protected virtual void OnMessagePublished(MessageEventArgs e)
    {
        // If there are any subscribers, invoke the event
        MessagePublished?.Invoke(this, e);
    }
}
