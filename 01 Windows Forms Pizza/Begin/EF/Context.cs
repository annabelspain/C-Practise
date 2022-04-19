using Microsoft.EntityFrameworkCore;
using PizzaProj;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
