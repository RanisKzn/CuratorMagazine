namespace CuratorMagazineWebAPI.RabbitMq;

/// <summary>
/// Interface IRabbitMqService
/// </summary>
public interface IRabbitMqService
{
    /// <summary>
    /// Sends the message.
    /// </summary>
    /// <param name="obj">The object.</param>
    void SendMessage(object obj);

    /// <summary>
    /// Sends the message.
    /// </summary>
    /// <param name="message">The message.</param>
    void SendMessage(string message);
}