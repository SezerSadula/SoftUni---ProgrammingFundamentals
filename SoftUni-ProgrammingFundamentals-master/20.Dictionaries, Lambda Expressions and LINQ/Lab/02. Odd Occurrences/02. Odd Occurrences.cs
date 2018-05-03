using System;
using System.Linq;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var oddOccurences = Console.ReadLine()
                .ToLower()
                .Split()
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 == 1)
                .Select(x => x.Key)
                .ToList();

            Console.WriteLine(string.Join(", ", oddOccurences));
        }
    }
}
