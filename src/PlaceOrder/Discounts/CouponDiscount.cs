
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.order.Discounts
{
    public class CouponDiscount : DiscountPrice, IDiscountPrice
    {
        public override int calcTotalAmountbyDiscount(DiscountDTO discount, int totalAmount)
        {
            return Convert.ToInt32(totalAmount * discount.coupon);
        }

        public override bool checkDiscount(DiscountDTO discount, int totalAmount)
        {
            return discount.DiscountType == DiscountEnum.Coupon;
        }
    }
}
