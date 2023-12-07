using System.Text;
using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;

namespace TicketTVD.MessageBus;

public class MessageBus : IMessageBus
{

    private string connectionString = "Endpoint=sb://tickettvdweb.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=mONqXi/RXcS41WQ/bDSMEb0PqLEtnug75+ASbDzLnxs=";

    public async Task PublishMessage(object message, string topic_queue_Name)
    {
        await using var client = new ServiceBusClient(connectionString);

        ServiceBusSender sender = client.CreateSender(topic_queue_Name);

        var jsonMessage = JsonConvert.SerializeObject(message);
        ServiceBusMessage finalMessage = new ServiceBusMessage(Encoding
            .UTF8.GetBytes(jsonMessage))
        {
            CorrelationId = Guid.NewGuid().ToString(),
        };

        await sender.SendMessageAsync(finalMessage);
        await client.DisposeAsync();
    }
}