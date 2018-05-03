using System;
using System.Linq;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            bool found = false;
            int numbersLenght = numbers.Length;
            for (int i = 0; i < numbersLenght; i++)
            {
                for (int j = i + 1; j < numbersLenght; j++)
                {
                    long sum = numbers[i] + numbers[j];

                    if (Array.IndexOf(numbers, sum) >= 0)
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
