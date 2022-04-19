using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Zoo
    {
        public string Name { get; set; }
        public /*virtual*/ ICollection<Animal> Animals { get; set; } = new List<Animal>();
    }

}
