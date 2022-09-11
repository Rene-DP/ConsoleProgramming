using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter heigth: ");
            int heigth = Convert.ToInt32(Console.ReadLine());

            var cube = new Cube(width, length, heigth);

            var triangle = new Triangle() { Length = length, Height = heigth, Hypotenuse = 10};
            var triangle2 = new Triangle();
            var triangle3 = new Triangle(10);
            var triangle4 = new Triangle(10, length, heigth);

            var rectangle = new Rectangle() { Length = length, Height = heigth};

            Console.WriteLine("\nCube area is: " + cube.GetArea());
            Console.WriteLine("Cube volume is: " + cube.GetVolume());

            Console.WriteLine("Triangle area is: " + triangle.GetArea());
            Console.WriteLine("Triangle area is: " + triangle2.GetArea());
            Console.WriteLine("Triangle area is: " + triangle3.GetArea());
            Console.WriteLine("Triangle area is: " + triangle4.GetArea());

            Console.WriteLine("Rectangle area is: " + rectangle.GetArea());

            Console.ReadKey();
        }
    }
}
