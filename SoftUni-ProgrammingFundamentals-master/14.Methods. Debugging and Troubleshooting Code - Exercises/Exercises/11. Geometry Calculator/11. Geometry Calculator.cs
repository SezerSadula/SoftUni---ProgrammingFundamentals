using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().Trim().ToLower();

            double result = 0d;
            switch (figureType)
            {
                case "triangle":
                    result = CalcTriangleArea();
                    break;
                case "square":
                    result = CalcSquareArea();
                    break;
                case "rectangle":
                    result = CalcRectangleArea();
                    break;
                case "circle":
                    result = CalcCircleArea();
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{result:F2}");
        }

        static double CalcCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            return Math.PI * radius * radius;
        }

        static double CalcRectangleArea()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            return sideA * sideB;
        }

        static double CalcSquareArea()
        {
            double side = double.Parse(Console.ReadLine());

            return side * side;
        }

        static double CalcTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return side * height / 2d;
        }
    }
}
