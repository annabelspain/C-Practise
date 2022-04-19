using OrderProj;
using System;
using Xunit;

namespace OrderTests
{
    public class OrderTests
    {
        [Fact]
        public void Order_Total_OK()
        {
            Shoe shoe = new Shoe();
            shoe.Price = 25.0M;

            Order order = new Order();

            OrderDetail orderDetail1 = new OrderDetail();
            orderDetail1.Shoe = shoe;
            order.Add(orderDetail1);

            OrderDetail orderDetail2 = new OrderDetail();
            orderDetail2.Shoe = shoe;
            order.Add(orderDetail2);

            Assert.True(order.Price == 50M);
        }

        [Fact]
        public void Set_Shoe_Size_10_OK()
        {
            Shoe shoe = new Shoe();
            shoe.ShoeSize = new ShoeSize(10, false);
            Assert.True(shoe.ShoeSize.GetSize() == 10);
        }

        [Fact]
        public void Shoe_Size_10_5_OK()
        {
            Shoe shoe = new Shoe();
            shoe.ShoeSize = new ShoeSize(10, true);
            Assert.True(shoe.ShoeSize.GetSize() == 10.5);
        }

        //[Fact]
        //public void Shoe_Size_10_3_Invalid()
        //{
        //    Shoe shoe = new Shoe();
        //    shoe.Size = 10.3;
        //    Assert.Equal(10.5, shoe.Size);
        //}

    }
}
