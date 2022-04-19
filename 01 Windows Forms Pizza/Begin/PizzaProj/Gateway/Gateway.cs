using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProj
{
    public class Gateway
    {
        public decimal OrderPizzas(Size size, Crust crust, int numberOf)
        {
            try
            {
                Checkout checkout = new Checkout(new WeekdayDiscounts());
                Order order = new Order();
                for (int i = 0; i < numberOf; i++)
                {
                    order.Add(new Pizza(Size.Small_10, Crust.Regular_2));
                }
                return checkout.GetBestPrice(order).TotalPrice;
            }
            catch (Exception e)
            {
                throw new BenignException("A problem occurred while ordering your pizzas", e);
            }
        }
    }

}
