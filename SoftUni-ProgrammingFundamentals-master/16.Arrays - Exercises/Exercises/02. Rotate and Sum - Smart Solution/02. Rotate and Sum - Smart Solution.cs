using System;
using System.Linq;

namespace _02.Rotate_and_Sum___Smart_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => long.Parse(x))
                .ToArray();

            int iterations = int.Parse(Console.ReadLine());
            int lenght = numbers.Length;
            long[] result = new long[lenght];

            for (int i = 1; i <= iterations; i++)
            {
                for (int j = 0; j < lenght;)
                {
                    result[j] += numbers[(++j + i) % lenght];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
