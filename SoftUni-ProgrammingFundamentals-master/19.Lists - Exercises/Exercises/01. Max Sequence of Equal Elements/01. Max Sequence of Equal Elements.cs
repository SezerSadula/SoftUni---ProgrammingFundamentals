using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxNum = 0;
            int maxCount = 0;

            int currentNum = numbers[0];
            int currentCount = 0;

            foreach (var number in numbers)
            {
                if (currentNum == number)
                {
                    currentCount++;

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxNum = currentNum;
                    }
                }
                else
                {
                    currentNum = number;
                    currentCount = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{maxNum} ");
            }
        }
    }
}
