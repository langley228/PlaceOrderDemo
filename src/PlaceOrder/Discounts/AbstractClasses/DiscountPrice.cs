
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.order.Discounts
{
    public abstract class DiscountPrice : IDiscountPrice
    {
        public abstract int calcTotalAmountbyDiscount(DiscountDTO discount, int totalAmount);
        public abstract bool checkDiscount(DiscountDTO discount, int totalAmount);
    }
}
