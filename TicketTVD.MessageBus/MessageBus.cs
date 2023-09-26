namespace TicketTVD.MessageBus;

public class MessageBus : IMessageBus
{
    public async Task PublishMessage(object message, string topic_queue_Name)
    {
        await new Task(null);
    }
}