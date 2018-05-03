using System;
using System.Linq;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Array.Sort<int>(numbers, (i1, i2) => i2.CompareTo(i1));

            int difference = int.Parse(Console.ReadLine());

            int pairs = 0;

            int arrayLength = numbers.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i; j < arrayLength; j++)
                {
                    int dif = numbers[i] - numbers[j];
                    if (dif == difference)
                    {
                        pairs++;
                    }

                    if (dif > difference)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(pairs);
        }
    }
}
