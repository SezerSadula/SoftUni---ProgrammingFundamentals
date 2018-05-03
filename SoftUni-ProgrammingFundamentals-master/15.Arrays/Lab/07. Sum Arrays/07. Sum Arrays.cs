using System;
using System.Linq;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arrayOne = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            long[] arrayTwo = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            int arrayOneLength = arrayOne.Length;
            int arrayTwoLength = arrayTwo.Length;
            int maxLenght = Math.Max(arrayOneLength, arrayTwoLength);

            long[] resultArray = new long[maxLenght];
            for (int i = 0; i < maxLenght; i++)
            {
                resultArray[i] = arrayOne[i % arrayOneLength] 
                    + arrayTwo[i % arrayTwoLength];
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
