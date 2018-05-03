using System;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = width * 2d +  height * 2d;
            double area = width * height;
            double diagonal = Math.Sqrt(Math.Pow(width, 2d) + Math.Pow(height, 2d));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
