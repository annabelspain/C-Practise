using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PizzaProj.DiscountPolicies;

namespace PizzaProj
{
    public abstract class BestDiscount
    {
        protected List<Func<Order,DiscountPolicyData>> policies { get; private set;} = new List<Func<Order, DiscountPolicyData>>();

        public BestDiscount()
        {
            policies.Add(CheapestIsFree);
        }
        public DiscountPolicyData GetBestDiscount(Order order)
        {
            return policies.Max(policy => policy(order));
        }
    }

    public class WeekdayDiscounts : BestDiscount
    {
        public WeekdayDiscounts()
        {
            policies.Add(FivePercentOffMoreThan50Dollars);
            policies.Add(FiveDollarsOffStuffedCrust);
        }
    }

    public class WeekendDiscounts : BestDiscount
    {
        public WeekendDiscounts()
        {
            policies.Add(order=> new DiscountPolicyData(DiscountPolicyName.Weekend_10_Percent_Off, order.NonDiscountedPrice * 0.1M) );
        }
    }

}
