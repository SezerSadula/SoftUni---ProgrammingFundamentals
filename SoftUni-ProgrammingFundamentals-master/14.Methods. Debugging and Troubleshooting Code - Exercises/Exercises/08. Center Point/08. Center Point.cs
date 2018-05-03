using System;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (CalculateDistance(x1, y1) <= CalculateDistance(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double CalculateDistance(double x1, double y1, double x2 = 0d, double y2 = 0d)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2d) + Math.Pow((y2 - y1), 2d));
        }
    }
}
