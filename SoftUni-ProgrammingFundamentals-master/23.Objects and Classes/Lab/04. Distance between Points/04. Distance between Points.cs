using System;
using System.Linq;

namespace _04.Distance_between_Points
{
    internal class Program
    {
        private static void Main()
        {
            var p1 = Point.Parse(Console.ReadLine());
            var p2 = Point.Parse(Console.ReadLine());

            Console.WriteLine($"{CalcDistance(p1, p2):F3}");
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2d) + Math.Pow((p2.Y - p1.Y), 2d));
        }
    }

    internal class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Point Parse(string coordinates)
        {
            var coord = coordinates
                .Split()
                .Select(double.Parse)
                .ToArray();

            return new Point(coord[0], coord[1]);
        }
    }
}
