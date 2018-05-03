using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            int iterations = int.Parse(Console.ReadLine());
            int lastIndex = numbers.Length - 1;
            long[] sum = new long[numbers.Length];

            for (int i = 0; i < iterations; i++)
            {
                long temp = numbers[lastIndex];
                Array.Copy(numbers, 0, numbers, 1, lastIndex);
                numbers[0] = temp;

                sum = sum.Select((x, index) => x + numbers[index]).ToArray();
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
