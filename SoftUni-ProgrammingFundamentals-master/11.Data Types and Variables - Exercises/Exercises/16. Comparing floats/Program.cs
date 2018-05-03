using System;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            const double eps = 0.000001d;

            Console.WriteLine(Math.Abs(a - b) <= eps);
        }
    }
}
