using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.order
{
    public class OrderDTO
    {
        public string id { get; set; }
        public int TotalPrice { get; set; }
        public List<OrderItemDTO> items { get; set; }
        public DiscountDTO discount { get; set; }
    }

    public class OrderItemDTO
    {
        public string name { get; set; }
        public int quanity { get; set; }
        public int unitPrice { get; set; }
    }

    public class DiscountDTO
    {
        public DiscountEnum DiscountType { get; set; }
        public int bouns { get; set; }
        public float coupon { get; set; }
    }

    public  enum DiscountEnum
    {
        None,
        Bouns,
        Coupon
    }

}
