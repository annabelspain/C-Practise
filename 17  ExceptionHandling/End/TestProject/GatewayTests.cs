using PizzaProj;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject
{
    public class GatewayTests
    {
        [Fact]
        public void Check_Gateway_OK()
        {
            decimal total = new Gateway().OrderPizzas(Size.Medium_15, Crust.Thin_4, 5);
            Assert.Equal(48M, total);
        }

        [Fact]
        public void Check_Benign_Exception2()
        {
            Assert.Throws<BenignException>(() => new Gateway().OrderPizzas(Size.Medium_15, Crust.Thin_4, 100));
        }
    }
}
