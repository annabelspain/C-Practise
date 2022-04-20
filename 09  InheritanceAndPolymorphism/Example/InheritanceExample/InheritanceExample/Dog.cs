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

            base.Speaks();
        }
    }
}
