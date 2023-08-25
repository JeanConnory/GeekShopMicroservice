using GeekShop.MessageBus;

namespace GeekShop.PaymentAPI.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage baseMessage); //sem exchange tem que passar a fila string queueName
    }
}
