using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(ushort.Parse)
                .ToArray();

            Dictionary<ushort, ushort> dict = new Dictionary<ushort, ushort>();

            foreach (var number in numbers)
            {
                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 0);
                }

                dict[number]++;
            }

            int maxOccurencies = 0;
            List<ushort> occurenciesList = new List<ushort>();

            foreach (var pair in dict)
            {
                if (pair.Value < maxOccurencies)
                {
                    continue;
                }
                
                if (pair.Value > maxOccurencies)
                {
                    maxOccurencies = pair.Value;
                    occurenciesList.Clear();
                }

                occurenciesList.Add(pair.Key);
            }

            Console.WriteLine(occurenciesList.First());
            //if (occurenciesList.Count == 1)
            //{
            //    Console.WriteLine($"The number {occurenciesList.First()} is the most frequent (occurs {maxOccurencies} times)");
            //}
            //else
            //{
            //    ushort lastNumber = occurenciesList.Last();
            //    occurenciesList.RemoveAt(occurenciesList.Count - 1);
            //    Console.WriteLine($"The numbers {string.Join(", ", occurenciesList)} and {lastNumber} have the same maximal frequence (each occurs {maxOccurencies} times). The leftmost of them is {occurenciesList.First()}.");
            //}
           // Console.WriteLine(string.Join(", ", dict.Select(m => m.Key + ":" + m.Value).ToArray()));
        }
    }
}
