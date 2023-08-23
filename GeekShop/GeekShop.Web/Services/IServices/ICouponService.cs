using GeekShop.Web.Models;

namespace GeekShop.Web.Services.IServices
{
    public interface ICouponService
    {
        Task<CouponViewModel> GetCoupon(string code, string token);
      
    }
}
