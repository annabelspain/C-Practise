using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadZoo();
        }

        static void LoadZoo()
        {
            List<Zoo> zoos = new List<Zoo>();
            Zoo londonZoo = new Zoo() { Name = "London" };
            Zoo edinburghZoo = new Zoo() { Name = "Edinburgh" };
            zoos.Add(londonZoo);
            zoos.Add(edinburghZoo);
            londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Dumbo" });
            londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Heffalumps" });
            londonZoo.Animals.Add(new Animal() { Type = "Lion", Name = "Clarence" }); // Lion tamer = Claude Bottom
            edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sweetie" });
            edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sunshine" });

            foreach (Zoo zoo in zoos)
            {
                Console.WriteLine($"\nName = {zoo.Name}, number of animals = {zoo.Animals.Count}");
                foreach (Animal animal in zoo.Animals)
                {
                    Console.WriteLine($"...{animal.Type,-10}{animal.Name}");
                }
            }
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }

    }
}
