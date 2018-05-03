using System;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double factor = 1.60934d;
            double miles = double.Parse(Console.ReadLine());
            double km = miles * factor;
            Console.WriteLine(km.ToString("F2"));
        }
    }
}
