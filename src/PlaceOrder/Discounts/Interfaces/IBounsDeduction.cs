using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.order.Discounts
{
   public interface IBounsDeduction
    {
        bool checkTotal(int totalAmount);
        int deduction(DiscountDTO discount, int totalAmount);
    }
}
