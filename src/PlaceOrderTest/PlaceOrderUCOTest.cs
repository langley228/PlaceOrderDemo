using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace kata.order.test
{
    [TestClass]
    public class PlaceOrderUCOTest
    {
        private PlaceOrderUCO uco;


        [TestMethod]
        public void testPlaceOrderNoAnyDiscount()
        {
            int expected = 600;
            int actual = 0;
            OrderDTO orderDTO = preparebaseOrderData();
            orderDTO = uco.procOrder(orderDTO);
            actual = orderDTO.TotalPrice;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testPlaceOrderwithDiscountOfBouns_1()
        {
            int expected = 550;
            int actual = 0;
            OrderDTO orderDTO = preparebaseOrderData();
            setDiscountOfBouns(orderDTO, 100);

            orderDTO = uco.procOrder(orderDTO);
            actual = orderDTO.TotalPrice;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testPlaceOrderwithDiscountOfBouns_2()
        {
            int expected = 1120;
            int actual = 0;
            OrderDTO orderDTO = preparebaseOrderData();
            orderDTO.items.Add(new OrderItemDTO
            {
                name = "玄鳳鸚鵡玩偶",
                quanity = 1,
                unitPrice = 800
            });
            setDiscountOfBouns(orderDTO, 280);

            orderDTO = uco.procOrder(orderDTO);
            actual = orderDTO.TotalPrice;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testPlaceOrderwithDiscountOfCoupon()
        {
            int expected = 540;
            int actual = 0;
            OrderDTO orderDTO = preparebaseOrderData();

            setDiscountOfCoupon(orderDTO, 0.9F);

            orderDTO = uco.procOrder(orderDTO);
            actual = orderDTO.TotalPrice;

            Assert.AreEqual(expected, actual);
        }
        private static void setDiscountOfBouns(OrderDTO orderDTO, int bouns)
        {
            orderDTO.discount.DiscountType = DiscountEnum.Bouns;
            orderDTO.discount.bouns = bouns;
        }
        private static void setDiscountOfCoupon(OrderDTO orderDTO, float coupon)
        {
            orderDTO.discount.DiscountType = DiscountEnum.Coupon;
            orderDTO.discount.coupon = coupon;
        }

        [TestInitialize]
        public void setup()
        {
            uco = new PlaceOrderUCO();
        }

        private OrderDTO preparebaseOrderData()
        {
            OrderDTO orderDTO = new OrderDTO
            {
                discount = new DiscountDTO
                {
                    DiscountType = DiscountEnum.None,
                    bouns = 0,
                    coupon = 1
                },
                TotalPrice = 0,
                items = new System.Collections.Generic.List<OrderItemDTO>()
            };
            orderDTO.items.Add(new OrderItemDTO
            {
                name = "毫米行動電源",
                quanity = 2,
                unitPrice = 100
            });
            orderDTO.items.Add(new OrderItemDTO
            {
                name = "微笑鋼筆",
                quanity = 1,
                unitPrice = 400
            });
            return orderDTO;
        }


    }
}
