using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using kata.order.Discounts;

namespace kata.order
{
    public class PlaceOrderUCO
    {
        public OrderDTO procOrder(OrderDTO orderinfo)
        {
            int totalAmount = orderinfo.items
                                       .Select(item => item.quanity * item.unitPrice)
                                       .Sum();
            IDiscountPrice d = DiscountFactory.getDiscount(orderinfo.discount, totalAmount);
            if (d != null)
                orderinfo.TotalPrice = d.calcTotalAmountbyDiscount(orderinfo.discount, totalAmount);
            else
                orderinfo.TotalPrice = totalAmount;
            return orderinfo;
        }

    }
}
