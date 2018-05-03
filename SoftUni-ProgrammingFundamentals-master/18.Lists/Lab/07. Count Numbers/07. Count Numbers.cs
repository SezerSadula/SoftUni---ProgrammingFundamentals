using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var counts = new Dictionary<int, int>();
            foreach (var number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 0);
                }

                counts[number]++;
            }

            var results = from pair in counts
                        orderby pair.Key ascending
                        select pair;

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} -> {result.Value}");
            }
        }
    }
}
