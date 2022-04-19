using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProj
{
    public class OrderTooBigException : Exception
    {
        public OrderTooBigException(string msg) : base(msg)
        {
        }
    }
}
