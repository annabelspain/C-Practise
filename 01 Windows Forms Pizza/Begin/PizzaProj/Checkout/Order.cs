using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProj
{
    public class Order
    {
        public int OrderId { get; set; } // For EF
        public virtual List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public string CustomerName { get; set; }
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
