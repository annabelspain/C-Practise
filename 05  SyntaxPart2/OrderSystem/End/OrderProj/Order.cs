using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProj
{
    public class Order
    {
        public decimal Price {
            get {
                decimal total = 0;
                for (int i = 0; i < numberOfOrderDetails; i++)
                {
                    total += orderDetails[i].Price;
                }
                return total;
            }
        }

        OrderDetail[] orderDetails = new OrderDetail[100];
        int numberOfOrderDetails = 0;

        public void Add(OrderDetail orderDetail1)
        {
            orderDetails[numberOfOrderDetails++] = orderDetail1;
        }

    }
}
