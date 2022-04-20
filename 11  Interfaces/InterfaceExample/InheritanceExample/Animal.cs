using InterfaceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    abstract class Animal : ISpeakable
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Legs { get; set; }

        public abstract void Speaks();

        //virtual here signifies that the derived classes can override the speaks method 
        //public virtual void Speaks()
        //{
        //    Console.WriteLine("I am an Animal");
        //    Console.WriteLine($"my name is {Name} with colour {Colour} and I have {Legs} number of legs");

        //}
    }
}
