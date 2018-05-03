using System;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());
            int elementsToSum = int.Parse(Console.ReadLine());

            long[] numbers = new long[elements];

            numbers[0] = 1;

            for (int i = 1; i < elements; i++)
            {
                int prev = Math.Max(0, i - elementsToSum);
                for (int j = prev; j < i; j++)
                {
                    numbers[i] += numbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
