namespace OrderProj
{
    public class OrderDetail
    {
        public Shoe Shoe { get; set; }
        public decimal Price => Shoe.Price;
    }
}