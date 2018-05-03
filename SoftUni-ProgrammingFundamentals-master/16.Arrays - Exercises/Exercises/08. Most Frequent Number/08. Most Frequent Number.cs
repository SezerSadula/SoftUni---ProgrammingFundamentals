using System;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxIndex = ushort.MaxValue + 1;
            ushort[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(ushort.Parse)
                .ToArray();

            ushort[] occurencies = new ushort[maxIndex];

            foreach (var number in numbers)
            {
                occurencies[number]++;
            }

            int maxOccurencies = 0;
            ushort firstNumber = 0;
            int firstNumberIndex = 0;

            for (int numIndex = 0; numIndex < maxIndex; numIndex++)
            {
                if (occurencies[numIndex] > maxOccurencies)
                {
                    maxOccurencies = occurencies[numIndex];
                    firstNumber = (ushort)numIndex;
                    firstNumberIndex = Array.IndexOf(numbers, (ushort)numIndex);
                }
                else if (occurencies[numIndex] == maxOccurencies)
                {
                    int index = Array.IndexOf(numbers, (ushort)numIndex); ;
                    if (index < firstNumberIndex)
                    {
                        firstNumber = (ushort)numIndex;
                        firstNumberIndex = index;
                    }
                }
            }

            Console.WriteLine(firstNumber);
        }
    }
}
