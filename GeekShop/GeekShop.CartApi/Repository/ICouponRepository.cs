using GeekShop.CartApi.Data.ValueObjects;

namespace GeekShop.CartApi.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCoupon(string couponCode, string token);
    }
}
