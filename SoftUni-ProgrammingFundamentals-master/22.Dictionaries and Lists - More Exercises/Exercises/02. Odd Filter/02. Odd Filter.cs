using System;
using System.Linq;


namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .Where(x => x % 2 == 0)
                .ToArray();

            var result = numbers
                .Select(x => x > numbers.Average() ? ++x : --x)
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
