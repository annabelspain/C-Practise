using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProj
{
    public class Order 
    {
        //public List<Pizza> Pizzas { get; private set; } = new List<Pizza>();
        public virtual IEnumerable<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public decimal NonDiscountedPrice => Pizzas.Sum(p => p.Price);

        public void Add(Pizza pizza)
        {
            if (Pizzas.Count() >= 50)
            {
                throw new OrderTooBigException("Can't have more than 50 pizzas in one order");
            }

            ((List<Pizza>)Pizzas).Add(pizza);

        }
    }
}
