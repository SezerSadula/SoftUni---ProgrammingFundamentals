using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nnn = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var dd = new SortedDictionary<double, int>();

            foreach (var number in nnn)
            {
                if (!dd.ContainsKey(number))
                {
                    dd[number] = 0;
                }

                dd[number]++;
            }

            foreach (var pair in dd)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
