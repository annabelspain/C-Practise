using PizzaProj;
using Xunit;

namespace TestProject
{
    public class CheckExceptions
    {
        Order order;
        public CheckExceptions()
        {
            order = new Order();
        }

        [Fact]
        public void Total_Price_Never_Negative()
        {
            Checkout checkout = new Checkout(new TestDiscount());
            order.Add(new Pizza(Size.Small_10, Crust.Regular_2));
            Assert.Throws<NegativePriceException>(() =>
             checkout.GetBestPrice(order));
        }

        class TestDiscount : BestDiscount
        {
            public TestDiscount()
            {
                policies.Add(order =>
                new DiscountPolicyData(DiscountPolicyName.None, 50M));
            }
        }

        //[Fact]
        //public void Denial_Of_Service_Attack()
        //{
        //    Checkout checkout = new Checkout(new WeekdayDiscounts());
        //    decimal total = 0;
        //    for (int i = 0; i < 100; i++)
        //    {
        //        order.Add(new Pizza(Size.Small_10, Crust.Regular_2));
        //        PriceData priceData = checkout.GetBestPrice(order);
        //        total += priceData.TotalPrice;
        //    }
        //    Assert.Equal(57468.00M, total);
        //}

        //[Fact]
        //public void Denial_Of_Service_Attack2()
        //{
        //    Checkout checkout = new Checkout(new WeekdayDiscounts());
        //    Assert.Throws<OrderTooBigException>(() =>
        //    {
        //        decimal total = 0;
        //        for (int i = 0; i < 100; i++)
        //        {
        //            order.Add(new Pizza(Size.Small_10, Crust.Regular_2));
        //            PriceData priceData = checkout.GetBestPrice(order);
        //            total += priceData.TotalPrice;
        //        }
        //    });
        //}

    }
}
