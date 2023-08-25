using GeekShop.MessageBus;

namespace GeekShop.PaymentAPI.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage baseMessage, string queueName);
    }
}
