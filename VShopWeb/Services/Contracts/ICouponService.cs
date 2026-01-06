using VShopWeb.Models;

namespace VShopWeb.Services.Contracts
{
    public interface ICouponService
    {
        Task<CouponViewModel> GetDiscountCoupon(string couponCode, string token);

    }
}
