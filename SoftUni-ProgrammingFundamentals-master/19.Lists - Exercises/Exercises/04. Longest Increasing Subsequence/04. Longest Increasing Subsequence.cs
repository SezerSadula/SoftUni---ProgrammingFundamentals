using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", FindLIS(numbers)));
        }

        private static List<int> FindLIS(List<int> numbers)
        {
            var elements = numbers.Count;
            var lenghts = new int[elements];
            var previous = new int[elements];

            var bestLenght = 0;
            var lastIndex = -1;

            for (int anchor = 0; anchor < elements; anchor++)
            {
                lenghts[anchor] = 1;
                previous[anchor] = -1;

                var anchorNum = numbers[anchor];

                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = numbers[i];

                    if (currentNum < anchorNum 
                        && lenghts[i] + 1 > lenghts[anchor])
                    {
                        lenghts[anchor] = lenghts[i] + 1;
                        previous[anchor] = i;
                    }
                }

                if (lenghts[anchor] > bestLenght)
                {
                    bestLenght = lenghts[anchor];
                    lastIndex = anchor;
                }
            }

            List<int> LIS = new List<int>();

            while (lastIndex != -1)
            {
                LIS.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            LIS.Reverse();

            return LIS;
        }
    }
}
