namespace OrderProj
{
    public class ShoeSize
    {
        private readonly int size;
        private readonly bool addHalfASize;

        public ShoeSize(int size, bool addHalfASize)
        {
            this.size = size;
            this.addHalfASize = addHalfASize;
        }

        public double GetSize()
        {
            return size + ((addHalfASize) ? 0.5 : 0);
        }
    }
}