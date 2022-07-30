using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                double areaOfSquare = sideOfSquare * sideOfSquare;
                Console.WriteLine($"{areaOfSquare:f3}");
            }
            else if (figure == "rectangle")
            {
                double firstSideOfRectangle = double.Parse(Console.ReadLine());
                double secondSideOfRectangle = double.Parse(Console.ReadLine());
                double areaOfRectangle = firstSideOfRectangle * secondSideOfRectangle;
                Console.WriteLine($"{areaOfRectangle:f3}");
            }
            else if (figure == "triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double heightOfTriangle = double.Parse(Console.ReadLine());
                double areaOfTriangle = heightOfTriangle * (sideOfTriangle / 2);
                Console.WriteLine($"{areaOfTriangle:f3}");
            }
            else if (figure == "circle")
            {
                double rOfCircle = double.Parse(Console.ReadLine());
                double areaOfCircle = rOfCircle * Math.PI * rOfCircle;
                Console.WriteLine($"{areaOfCircle:f3}");
            }
        }
    }
}
