using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            int maxNum = 0;
            int maxCount = 0;

            int currentNum = numbers[0];
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (currentNum == numbers[i])
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
                    currentNum = numbers[i];
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
