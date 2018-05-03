using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    internal class Program
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            while (n-- > 0)
            {
                points.Add(Point.Parse(Console.ReadLine()));
            }

            var closestPoints = FindClosestPoints(points);

            Console.WriteLine($"{CalcDistance(closestPoints[0], closestPoints[1]):F3}");
            Console.WriteLine(closestPoints[0]);
            Console.WriteLine(closestPoints[1]);
        }

        private static Point[] FindClosestPoints(IReadOnlyList<Point> points)
        {
            var closestPoints = new Point[2];

            var shortestDistance = double.MaxValue;

            for (var i = 0; i < points.Count; i++)
            {
                for (var j = 0; j < points.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    var currentDistance = CalcDistance(points[i], points[j]);

                    if (currentDistance >= shortestDistance)
                    {
                        continue;
                    }

                    shortestDistance = currentDistance;
                    closestPoints[0] = points[i];
                    closestPoints[1] = points[j];
                }
            }

            return closestPoints;
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

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
