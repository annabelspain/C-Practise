using InterfaceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Cat : Animal
    {
        public override void Speaks()
        {
            Console.WriteLine("I am a Cat");
            Console.WriteLine("I am an Animal");
            Console.WriteLine($"my name is {Name} with colour {Colour} and I have {Legs} number of legs");
        }
    }
}
