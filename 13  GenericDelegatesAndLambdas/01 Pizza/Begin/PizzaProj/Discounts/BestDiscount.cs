using System;
using System.Collections.Generic;
using System.Text;
using static PizzaProj.DiscountPolicies;

namespace PizzaProj
{
    public abstract class BestDiscount
    {
        // protected List<IDiscountPolicy> policies { get; private set;} = new List<IDiscountPolicy>();
        protected List<Func<Order, DiscountPolicyData>> policies
        { get; private set; }
                = new List<Func<Order, DiscountPolicyData>>();

        public BestDiscount()
        {
            //policies.Add(new CheapestIsFree());
            policies.Add(DiscountPolicies.CheapestIsFree);
        }
        public DiscountPolicyData GetBestDiscount(Order order)
        {
            // Loop round all discount policies to determine the maximum discount
            DiscountPolicyData discountPolicyWithMaxDiscount = new DiscountPolicyData(DiscountPolicyName.None, 0);
            //foreach (IDiscountPolicy policy in policies)
            foreach (Func<Order, DiscountPolicyData> policy in policies)
            {
                DiscountPolicyData thisOrdersPolicyData = policy(order);
                {
                    if (thisOrdersPolicyData.Discount > discountPolicyWithMaxDiscount.Discount)
                    {
                        discountPolicyWithMaxDiscount = thisOrdersPolicyData;
                    }
                }
            }
            return discountPolicyWithMaxDiscount;
        }

        public class WeekdayDiscounts : BestDiscount
        {
            public WeekdayDiscounts()
            {
                //policies.Add(new FivePercentOffMoreThan50Dollars());
                //policies.Add(new FiveDollarsOffStuffedCrust());
                policies.Add(DiscountPolicies.FivePercentOffMoreThan50Dollars);
                policies.Add(DiscountPolicies.FiveDollarsOffStuffedCrust);
            }
        }

        public class WeekendDiscounts : BestDiscount
        {
            public WeekendDiscounts()
            {
                policies.Add(order => new
                    DiscountPolicyData(DiscountPolicyName.Weekend_10_Percent_Off,
                    order.NonDiscountedPrice * 0.1M));
            }
        }
    }
}
