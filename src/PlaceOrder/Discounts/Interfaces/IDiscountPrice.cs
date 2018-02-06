using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.order.Discounts
{
    public interface IDiscountPrice
    {
        bool checkDiscount(DiscountDTO discount, int totalAmount);
        int calcTotalAmountbyDiscount(DiscountDTO discount, int totalAmount);
    }
}
