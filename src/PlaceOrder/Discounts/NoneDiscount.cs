using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.order.Discounts
{
    public class NoneDiscount : DiscountPrice, IDiscountPrice
    {
        public override int calcTotalAmountbyDiscount(DiscountDTO discount, int totalAmount)
        {
            return totalAmount;
        }

        public override bool checkDiscount(DiscountDTO discount, int totalAmount)
        {
            return discount.DiscountType == DiscountEnum.None;
        }
    }
}
