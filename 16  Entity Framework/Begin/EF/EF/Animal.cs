using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public virtual Zoo ZooId { get; set; }
    }
}
