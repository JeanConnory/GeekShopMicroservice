using GeekShop.CouponAPI.Data.ValueObjects;
using GeekShop.CouponAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShop.CouponAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly ICouponRepository _repository;

        public CouponController(ICouponRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [Authorize]
        [HttpGet("{couponCode}")]
        public async Task<ActionResult<CouponVO>> GetCouponByCouponCode(string couponCode)
        {
            //var token = await HttpContext.GetTokenAsync("access_token");
            var coupon = await _repository.GetCouponByCouponCode(couponCode);

            if (coupon == null)
                return NotFound();

            return Ok(coupon);
        }
    }
}
