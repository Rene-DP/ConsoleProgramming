namespace Inheritance
{
    class Triangle : Shape, IShape
    {
        public Triangle()
        {

        }

        public Triangle(int hyp)
        {
            Hypotenuse = hyp;
        }

        public Triangle(int hyp, int length, int heigth)
        {
            Hypotenuse = hyp;
            Length = length;
            Height = heigth;
        }

        public double Hypotenuse { get; set; }

        public double GetArea()
        {
            return (Length * Height) / 2;
        }
    }
}
