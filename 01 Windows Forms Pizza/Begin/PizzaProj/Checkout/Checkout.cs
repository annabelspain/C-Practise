using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProj
{
    public class Checkout
    {
        readonly BestDiscount bestDiscount;
        public Checkout(BestDiscount bestDiscount)
        {
            this.bestDiscount = bestDiscount;
        }

        public PriceData GetBestPrice(Order order)
        {
            DiscountPolicyData discountPolicyData = bestDiscount.GetBestDiscount(order);
            PriceData priceData = new PriceData(discountPolicyData.DiscountPolicyName, order.NonDiscountedPrice, discountPolicyData.Discount);
            if (priceData.TotalPrice < 0)
            {
                throw new NegativePriceException("Price can not be less than 0");
            }
            return priceData;
        }
    }
}
