﻿using System;
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
            // TODO 2) Replace all of the code in this method with a 1-liner:
            // return policies.  <a LINQ expression that returns the maximum of all the policy(order) in policies>

            //// Loop round all discount policies to determine the maximum discount
            //DiscountPolicyData discountPolicyWithMaxDiscount = new DiscountPolicyData(DiscountPolicyName.None, 0);
            //foreach (Func<Order,DiscountPolicyData> policy in policies)
            //{
            //    DiscountPolicyData thisOrdersPolicyData = policy(order);
            //    if (thisOrdersPolicyData.Discount > discountPolicyWithMaxDiscount.Discount)
            //    {
            //        discountPolicyWithMaxDiscount = thisOrdersPolicyData;
            //    }
            //}
            //return discountPolicyWithMaxDiscount;
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
