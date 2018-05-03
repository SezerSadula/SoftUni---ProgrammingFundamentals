using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine();

            var secondNum = Console.ReadLine();

            Console.WriteLine(SumBigNums(firstNum, secondNum));
        }

        private static string SumBigNums(string firstNum, string secondNum)
        {
            var elements = Math.Max(
                firstNum.TrimStart('0').Length,
                secondNum.TrimStart('0').Length);

            var digitsFirst = StringToDigitsArray(firstNum, elements);
            var digitsSecond = StringToDigitsArray(secondNum, elements);

            var result = new Stack<int>();
            var carry = 0;
            for (var i = elements - 1; i >= 0; i--)
            {
                var tempSum = carry + digitsFirst[i] + digitsSecond[i];
                result.Push(tempSum % 10);
                carry = tempSum / 10;
            }
            result.Push(carry);

            while (result.Peek() == 0)
            {
                result.Pop();
            }

            return string.Concat(result);
        }

        private static int[] StringToDigitsArray(string numString, int elements)
        {
            return numString
                .TrimStart('0')
                .PadLeft(elements, '0')
                .ToCharArray()
                .Select(x => x - '0')
                .ToArray();
        }
    }
}
