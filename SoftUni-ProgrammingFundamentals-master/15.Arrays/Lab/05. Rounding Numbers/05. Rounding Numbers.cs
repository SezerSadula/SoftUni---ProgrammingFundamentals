using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
