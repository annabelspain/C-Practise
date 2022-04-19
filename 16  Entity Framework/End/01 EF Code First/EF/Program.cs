using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createNewDatabase = false;
            ServiceProvider serviceProvider = ConfigureServices();
            ZooContext ctx = serviceProvider.GetService<ZooContext>();

            if (createNewDatabase) {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
                LoadZoo(ctx);
            } else
            {
                ViewZoo(ctx);
            }
        }

        static void LoadZoo(ZooContext ctx)
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

            // write to database
            foreach (Zoo zoo in zoos)
            {
                ctx.Zoos.Add(zoo);
            }
            ctx.SaveChanges();
        }

        static void ViewZoo(ZooContext ctx)
        {
            foreach (Zoo zoo in ctx.Zoos /*.Include(z => z.Animals)*/ )
            {
                //ctx.Entry(zoo).Collection(z => z.Animals).Load();
                Console.WriteLine($"\nName = {zoo.Name}, number of animals = {zoo.Animals.Count}");
                foreach (Animal animal in zoo.Animals)
                {
                    Console.WriteLine($"...{animal.Type,-10}{animal.Name}");
                }
            }

            var elephants = from animal in ctx.Animals
                            where animal.Type == "Elephant"
                            select animal;
            foreach (var elephant in elephants)
            {
                Console.WriteLine($"{elephant.Name} is an elephant");
            }

        }

        private static ServiceProvider ConfigureServices()
        {
            var builder = new ConfigurationBuilder() 
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            string strConn = configuration.GetConnectionString("conn");

            Console.WriteLine(configuration.GetConnectionString("conn"));

            var services = new ServiceCollection();
            services.AddDbContext<ZooContext>(options => options.UseSqlServer(strConn));

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
