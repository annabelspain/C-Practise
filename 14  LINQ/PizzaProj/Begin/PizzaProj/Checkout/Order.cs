using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProj
{
    public class Order
    {
        public List<Pizza> Pizzas { get; private set; } = new List<Pizza>();

        // TODO 1) Replace NonDiscountedPrice property with a 1-liner :
        // public decimal NonDiscountedPrice =>  <A LINQ Expression that sums the prices of all the pizzas>

        public decimal NonDiscountedPrice {
             get {
                // Loop round all pizzas and sum their prices to achieve a total
                decimal total = 0;
                foreach(Pizza p in Pizzas)
                {
                    total += p.Price;
                }
                return total;
            }
        }

    }
}
