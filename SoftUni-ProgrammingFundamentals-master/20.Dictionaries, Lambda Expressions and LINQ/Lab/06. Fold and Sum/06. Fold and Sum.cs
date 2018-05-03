using System;
using System.Linq;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            var k = numbers.Length / 4;

            var firstRow = numbers
                .Take(k)
                .Reverse()
                .Concat(numbers.Skip(3 * k).Reverse().ToList())
                .ToArray();

            var secondRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var sum = firstRow.Zip(secondRow, (a, b) => a + b);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
