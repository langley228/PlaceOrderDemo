
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.order.Discounts
{
    public class BonusDiscount_5000 : BounsDiscount, IDiscountPrice, IBounsDeduction
    {
        public override bool checkTotal(int totalAmount)
        {
            return totalAmount >= 5000;
        }

        public override int deduction(DiscountDTO discount, int totalAmount)
        {
            return -new int[] { discount.bouns, 1000, totalAmount }.Min();
        }
    }
}
