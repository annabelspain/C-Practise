using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProj
{
    public class Order
    {
        public virtual IEnumerable<Pizza> Pizzas { get; set; }
                                                    = new List<Pizza>();
        public void Add(Pizza pizza)
        {
            if (Pizzas.Count() >= 50)
            {
                throw new OrderTooBigException("Can't have more than 50 pizzas in an order");
            }
            ((List<Pizza>)Pizzas).Add(pizza);
        }

        public decimal NonDiscountedPrice => Pizzas.Sum(p => p.Price);

    }
}
