using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int secondIndex = userInput.Length / 4 - 1;
            int firstIndex = userInput.Length / 4;

            for (int i = 0; i < userInput.Length / 2; i++)
            {
                if (secondIndex < 0)
                {
                    secondIndex = userInput.Length - 1;
                }

                Console.Write($"{userInput[firstIndex++] + userInput[secondIndex--]} ");
            }
        }
    }
}
