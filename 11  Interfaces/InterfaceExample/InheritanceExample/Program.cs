using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Dog1 Instance");

            //create a new instance of Dog1
            Dog dog1 = new Dog
            {
                Name = "Bingo",
                Colour = "Grey",
                Legs = 4
            };

            //call the speak method
            dog1.Speaks();

            Console.WriteLine();
            Console.WriteLine("Dog2 Instance");

            //create a new instance of Dog1 using the base class
            Animal dog2 = new Dog
            {
                Name = "Buster",
                Colour = "Yellow",
                Legs = 4
            };
            //call the speak method
            dog2.Speaks();

            Console.WriteLine();
            Console.WriteLine("Cat1 Instance");

            //create a new instance of Cat
            Animal cat1 = new Cat
            {
                Name = "Timmy",
                Colour = "Orange",
                Legs = 4
            };
            //call the speak method
            cat1.Speaks();
        }
    }
}
