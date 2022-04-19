namespace OrderProj
{
    public class Shoe
    {
        public decimal Price { get; set; }

        //double size;
        public ShoeSize ShoeSize { get; set; }

        /*
        public double Size
        {
            get { return size; }
            set { size = Math.Round(value * 2) / 2; }
        }
        */
    }
}