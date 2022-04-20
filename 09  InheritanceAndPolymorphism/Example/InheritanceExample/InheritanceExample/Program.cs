using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new ionstance of animal 
            Animal anim = new Animal
            {
                Name = "DkAnim",
                Colour = "Unknown",
                Legs = 0
            };

            //call speak method
            anim.Speaks();

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

            //create a new instance of Dog1
            Animal dog2 = new Dog
            {
                Name = "Buster",
                Colour = "Yellow",
                Legs = 4
            };
            //call the speak method
            dog2.Speaks();
        }
    }
}
