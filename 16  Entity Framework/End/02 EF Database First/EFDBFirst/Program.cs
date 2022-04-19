using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace EFDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = ConfigureServices();
            NorthwindContext ctx = serviceProvider.GetRequiredService<NorthwindContext>();
            var results = from c in ctx.Customers
                          select new { c.CustomerId };

            foreach (var result in results)
                Console.WriteLine(result);
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
            services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(strConn));

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
