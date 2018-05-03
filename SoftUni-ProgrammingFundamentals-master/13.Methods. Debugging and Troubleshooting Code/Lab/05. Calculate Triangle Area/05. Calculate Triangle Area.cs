using System;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateTriangleArea(width, height));
        }

        static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2d;
        }
    }
}
