using System;

namespace _02.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2d);

            Console.WriteLine($"{area:F12}");
        }
    }
}
