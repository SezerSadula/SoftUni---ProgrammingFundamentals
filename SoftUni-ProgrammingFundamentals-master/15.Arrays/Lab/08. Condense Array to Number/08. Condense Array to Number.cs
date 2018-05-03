using System;
using System.Linq;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            while (numbers.Length > 1)
            {
                int condensedLenght = numbers.Length - 1;
                long[] condensed = new long[condensedLenght];

                for (int i = 0; i < condensedLenght; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
