
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.order.Discounts
{
    public abstract class BounsDiscount : DiscountPrice, IDiscountPrice, IBounsDeduction
    {
        public override int calcTotalAmountbyDiscount(DiscountDTO discount, int totalAmount)
        {
            return totalAmount += deduction(discount, totalAmount);
        }
        public override bool checkDiscount(DiscountDTO discount, int totalAmount)
        {
            return discount.DiscountType == DiscountEnum.Bouns && checkTotal(totalAmount);
        }
        public abstract bool checkTotal(int totalAmount);
        public abstract int deduction(DiscountDTO discount, int totalAmount);
    }
}
