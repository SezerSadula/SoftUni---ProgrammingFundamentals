using System;
using System.Linq;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            long [] numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => long.Parse(x))
                .ToArray();

            long min = long.MaxValue;
            long max = long.MinValue;
            long sum = 0L;

            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }

                sum += number;
            }

            Console.WriteLine($"Min = {min}\n" +
                              $"Max = {max}\n" +
                              $"Sum = {sum}\n" +
                              $"Average = {(double)sum /numbers.Length}");
        }
    }
}
