using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProj
{
    public class NegativePriceException : Exception
    {
        public NegativePriceException(string msg) : base(msg)
        {
        }
    }
}
