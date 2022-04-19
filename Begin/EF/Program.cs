using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaProj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EF
{
    // NuGet
    //Microsoft.Extensions.Configuration
    //Microsoft.Extensions.Configuration.FileExtensions
    //Microsoft.Extensions.Configuration.Json
    // Microsoft.EntityFrameworkCore
    // Microsoft.EntityFrameworkCore.SqlServer
    // Microsoft.EntityFrameworkCore.Proxies
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = ConfigureServices();
            PizzaContext ctx = serviceProvider.GetService<PizzaContext>();

            bool createDatabase = true;
            if (createDatabase) {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
                LoadOrder1(ctx);
                LoadOrder2(ctx);
            } else { 
                ViewOrders(ctx);
            }

        }

        static void LoadOrder1(PizzaContext ctx)
        {
            Order order = new Order() { CustomerName = "Fred" };
            order.Add(new Pizza(Size.Small_10, Crust.Regular_2));
            order.Add(new Pizza(Size.Small_10, Crust.Regular_2));
            order.Add(new Pizza(Size.Medium_15, Crust.Thin_4));

            LogOrderToConsole(order);

            ctx.Orders.Add(order);
            ctx.SaveChanges();
        }

        static void LoadOrder2(PizzaContext ctx)
        {
            Order order = new Order() { CustomerName = "Barney" };
            order.Add(new Pizza(Size.Large_20, Crust.Stuffed_3));

            LogOrderToConsole(order);

            ctx.Orders.Add(order);
            ctx.SaveChanges();
        }

        private static void LogOrderToConsole(Order order)
        {
            Console.WriteLine($"\nOrder for : {order.CustomerName}");
            foreach (Pizza pizza in order.Pizzas)
            {
                Console.WriteLine($"Pizza : {pizza.Size.ToString()} / {pizza.Crust.ToString()}");
            }

            Checkout checkout = new Checkout(new WeekdayDiscounts());
            PriceData priceData = checkout.GetBestPrice(order);
            Console.WriteLine($"Price = {priceData.TotalPrice}, Discount applied = {priceData.DiscountPolicyName}");
        }



        static void ViewOrders(PizzaContext ctx)
        {
            foreach (Order order in ctx.Orders)
            {
                LogOrderToConsole(order);
            }
        }

        static IConfigurationRoot configuration; 
        private static ServiceProvider ConfigureServices()
        {
            var builder = new ConfigurationBuilder() 
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();
            string strConn = configuration.GetConnectionString("conn");

            var services = new ServiceCollection();

            services.AddDbContext<PizzaContext>(options => options.UseSqlServer(strConn));

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
