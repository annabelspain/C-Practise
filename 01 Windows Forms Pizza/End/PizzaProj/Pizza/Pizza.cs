using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PizzaProj
{

    public class Pizza
    {
        public int PizzaId { get; set; } // For EF

        public Size Size { get; set; } // For EF
        public Crust Crust { get; set; } // For EF
        public Pizza() { } //For EF
        public Pizza(Size size, Crust crust)
        {
            Size = size;
            Crust = crust;
        }
        public decimal Price { 
            get {
                decimal price;
                switch(Size)
                {
                    case Size.Small_10: price = 10; break;
                    case Size.Medium_15: price = 15; break;
                    case Size.Large_20: price = 20; break;
                        default: throw new Exception("Bad Size");
                }
                switch (Crust)
                {
                    case Crust.Regular_2: price += 2; break;
                    case Crust.Stuffed_3: price += 3; break;
                    case Crust.Thin_4: price += 4; break;
                    default: throw new Exception("Bad Size");
                }
                return price;
            }
        }

        // Explicitly describe how foreign keys are to be mapped to the database
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
