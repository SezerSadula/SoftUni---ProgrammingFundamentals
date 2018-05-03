using System;
using System.Linq;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var circleOneData = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var circleTwoData = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var CircleOne = new Circle(circleOneData[0], 
                circleOneData[1], circleOneData[2]);

            var CircleTwo = new Circle(circleTwoData[0], 
                circleTwoData[1], circleTwoData[2]);

            Console.WriteLine(Intersect(CircleOne, CircleTwo)? "Yes" : "No");
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            var distance = Math.Sqrt(
                Math.Pow(c1.Center.X - c2.Center.X, 2) 
                + Math.Pow(c1.Center.Y - c2.Center.Y, 2));
            return distance <= c1.Radius + c2.Radius;
        }

        private class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }

            public Circle(double x, double y, double r)
            {
                Center = new Point(x, y);
                Radius = r;
            }

            internal class Point
            {
                public double X { get; set; }
                public double Y { get; set; }

                public Point(double x, double y)
                {
                    X = x;
                    Y = y;
                }
            }
        }
    }
}
