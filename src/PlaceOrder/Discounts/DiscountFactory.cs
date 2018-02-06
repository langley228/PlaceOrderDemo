
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace kata.order.Discounts
{
    public static class DiscountFactory
    {
        private static List<IDiscountPrice> discountList = getDiscountList();
        public static IDiscountPrice getDiscount(DiscountDTO discount, int totalAmount)
        {
            for (int i = 0; i < discountList.Count; i++)
            {
                var bank = discountList[i];
                if (bank.checkDiscount(discount, totalAmount))
                    return bank;
            }
            return null;
        }

        private static List<IDiscountPrice> getDiscountList()
        {
            List<IDiscountPrice> list = new List<IDiscountPrice>();
            IEnumerable<Type> theList = Assembly.GetExecutingAssembly().GetTypes()
                         .Where(t => t.Namespace == typeof(IDiscountPrice).Namespace && !t.IsAbstract &&
                                     t.GetInterfaces().Contains(typeof(IDiscountPrice)));
            foreach (var item in theList)
            {
                IDiscountPrice obj = Activator.CreateInstance(item) as IDiscountPrice;
                if (obj != null)
                    list.Add(obj);
            }
            return list;
        }
    }
}