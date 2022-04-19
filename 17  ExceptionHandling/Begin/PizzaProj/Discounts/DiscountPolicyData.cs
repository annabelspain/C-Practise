using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProj
{
    public class DiscountPolicyData : IComparable<DiscountPolicyData>
    {
        public DiscountPolicyName DiscountPolicyName { get; }
        public decimal Discount { get; }

        public DiscountPolicyData(DiscountPolicyName discountPolicyName, decimal discount)
        {
            DiscountPolicyName = discountPolicyName;
            Discount = discount;
        }

        public int CompareTo(DiscountPolicyData other)
        {
            return this.Discount.CompareTo(other.Discount);
        }
    }
}
