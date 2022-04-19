using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProj
{
    public class BenignException : Exception
    {
        public BenignException(string msg, Exception innerException) : base(msg, innerException)
        {
        }
    }
}
