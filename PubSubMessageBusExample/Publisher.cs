public class Publisher
{
    private readonly MessageQueue _queue;

    public Publisher(MessageQueue queue)
    {
        _queue = queue;
    }

    public void PublishMessage(string message)
    {
        // Publisher publishes the message to the queue
        _queue.Publish(message);
    }
}
