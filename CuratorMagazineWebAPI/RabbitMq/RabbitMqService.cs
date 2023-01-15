using System.Text;
using System.Text.Json;
using RabbitMQ.Client;

namespace CuratorMagazineWebAPI.RabbitMq;

/// <summary>
/// Class RabbitMqService.
/// Implements the <see cref="CuratorMagazineWebAPI.RabbitMq.IRabbitMqService" />
/// </summary>
/// <seealso cref="CuratorMagazineWebAPI.RabbitMq.IRabbitMqService" />
public class RabbitMqService : IRabbitMqService
{
    /// <summary>
    /// Sends the message.
    /// </summary>
    /// <param name="obj">The object.</param>
    public void SendMessage(object obj)
    {
        var message = JsonSerializer.Serialize(obj);
        SendMessage(message);
    }

    /// <summary>
    /// Sends the message.
    /// </summary>
    /// <param name="message">The message.</param>
    public void SendMessage(string message)
    {
        var factory = new ConnectionFactory()
        {
            HostName = "localhost"
        };

        using (var connection = factory.CreateConnection())
        {
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "MyQueue",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                    routingKey: "MyQueue",
                    basicProperties: null,
                    body: body);
            }
        }
    }
}