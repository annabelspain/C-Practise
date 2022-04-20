using InterfaceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    // Inheritance is here 
    //Below animal is the base or Super or Parent class
    //Dog is the derived or sub or child 
    class Dog : Animal
    {
        public override void Speaks()
        {
            Console.WriteLine("I am a Dog");
            Console.WriteLine("I am an Animal");
            Console.WriteLine($"my name is {Name} with colour {Colour} and I have {Legs} number of legs");
        }
    }
}
