using System;
using System.Linq;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int startIndex = 0;
            int sequenceLength = 1;

            int bestStartIndex = 0;
            int bestSequenceLength = 0;
            

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    sequenceLength++;

                    if (sequenceLength > bestSequenceLength)
                    {
                        bestStartIndex = startIndex;
                        bestSequenceLength = sequenceLength;
                    }
                }
                else
                {
                    startIndex = i;
                    sequenceLength = 1;
                }
            }

            for (int i = bestStartIndex; i < bestStartIndex + bestSequenceLength; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();
        }
    }
}
