using GeekShop.Email.Messages;
using GeekShop.Email.Model;

namespace GeekShop.Email.Repository
{
    public interface IEmailRepository
    {        
        Task LogEmail(UpdatePaymentResultMessage message);
    }
}
