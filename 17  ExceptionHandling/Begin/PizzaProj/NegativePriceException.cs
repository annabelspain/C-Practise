using PizzaProj;
using System;

namespace PizzaProj
{
    public class NegativePriceException : Exception
    {
        public NegativePriceException(string message):
            base(message)
        {

        }
    }
}