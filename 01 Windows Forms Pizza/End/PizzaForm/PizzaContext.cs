using PizzaProj;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForm
{
    public class PizzaContext : DbContext
    {
        public PizzaContext() : base("PizzaDb")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
    }

}
