using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProj
{
    public class Order
    {
        public List<Pizza> Pizzas { get; private set; } = new List<Pizza>();

        public decimal NonDiscountedPrice => Pizzas.Sum(p => p.Price);

    }
}
