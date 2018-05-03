using System;
using System.Linq;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => long.Parse(x))
                .ToArray();

            int stopNumber = int.Parse(Console.ReadLine());

            int lastIndex = Array.LastIndexOf(numbers, stopNumber);

            if (lastIndex == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long n = numbers
                        .Take(lastIndex)
                        .ToArray()
                        .Sum();
                Console.WriteLine(n);
            }
        }
    }
}
