using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Zoo
    {
        public int ZooId { get;set;}
        public string Name { get; set; }
        public /*virtual*/ ICollection<Animal> Animals { get; set; } = new List<Animal>();
    }
}
