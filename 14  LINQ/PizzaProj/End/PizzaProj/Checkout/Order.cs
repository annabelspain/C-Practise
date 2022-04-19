using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProj
{
    public class Order
    {
        public List<Pizza> Pizzas { get; private set; } = new List<Pizza>();

        // TODO 1) Replace NonDiscountedPrice property with a 1-liner :
        // public decimal NonDiscountedPrice =>  <A LINQ Expression that sums the prices of all the pizzas>

        //public decimal NonDiscountedPrice {
        //     get {
        //        // Loop round all pizzas and sume their prices to achieve a total
        //        decimal total = 0;
        //        foreach(Pizza p in Pizzas)
        //        {
        //            total += p.Price;C:\VSO\QACS_VS2019\Courseware\12_LINQ\LABS\End\PizzaProj\Pizza\Pizza.cs
        //        }
        //        return total;
        //    }
        //}
        public decimal NonDiscountedPrice => Pizzas.Sum(p => p.Price);

    }
}
