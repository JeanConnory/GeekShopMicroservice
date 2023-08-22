using GeekShop.CouponAPI.Data.ValueObjects;

namespace GeekShop.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCouponByCouponCode(string couponCode);
    }
}
