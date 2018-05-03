using System;
using System.Linq;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            int numbersLenght = numbers.Length;

            for (int i = 0; i < numbersLenght; i++)
            {
                if (SumElements(numbers, 0, i) == 
                    SumElements(numbers, i + 1, numbersLenght))
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }

        private static long SumElements(long[] numbers, 
            int startIndex, int endIndex)
        {
            long sum = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
