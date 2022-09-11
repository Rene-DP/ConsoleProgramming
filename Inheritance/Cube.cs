namespace Inheritance
{
    class Cube : Shape, IShape
    {
        public Cube()
        {

        }

        public Cube(int width, int length, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }

        public double Width { get; set; }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetVolume()
        {
            return Length * Width * Height;
        }
    }
}
