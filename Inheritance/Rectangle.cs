namespace Inheritance
{
    class Rectangle : Shape, IShape
    {
        public double Width { get; set; }

        public double GetArea()
        {
            return Length * Height;
        }
    }
}
