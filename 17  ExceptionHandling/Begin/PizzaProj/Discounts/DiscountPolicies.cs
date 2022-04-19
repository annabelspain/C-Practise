using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProj
{
    public static class DiscountPolicies
    {
        public static DiscountPolicyData CheapestIsFree(Order order)
        {
            System.Diagnostics.Debug.WriteLine("CheapestIsFree");
            var pizzas = order.Pizzas;
            if (pizzas.Count < 2)
            {
                return new DiscountPolicyData(DiscountPolicyName.None, 0M);
            }

            return new DiscountPolicyData(DiscountPolicyName.Cheapest_Is_Free, pizzas.Min(p => p.Price));
        }

        public static DiscountPolicyData FivePercentOffMoreThan50Dollars(Order order)
        {
            decimal nonDiscounted = order.Pizzas.Sum(p => p.Price);

            // if the total is more than 50 then give a 5% discount
            return new DiscountPolicyData(DiscountPolicyName.Five_Percent_Off_More_Than_50_Dollars, nonDiscounted >= 50 ? nonDiscounted * 0.05M : 0);

        }

        public static DiscountPolicyData FiveDollarsOffStuffedCrust(Order order)
        {
            return new DiscountPolicyData(DiscountPolicyName.Five_Dollars_Off_StuffedCrust, order.Pizzas.Sum(p => p.Crust == Crust.Stuffed_3 ? 5M : 0M));
        }


    }
}
