using System;
using System.Collections.Generic;

namespace Syntax3
{
    public partial class Car
    {
        //public Make Make { get; set; }

        public static int Count { get; private set; }

        public Car()
        {
            Count++;
        }
        public bool Start()
        {
            return true;
        }
    }
}