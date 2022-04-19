using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProj
{
    public class Shoe
    {
        public decimal Price { get; set; }

        //double size;
        //public double Size {
        //    get { return size; }
        //    // set { size = (int)(value * 2) / 2; }
        //    set { size = Math.Round(value * 2) / 2; }
        //}

        public ShoeSize ShoeSize { get; set; }
    }
}
