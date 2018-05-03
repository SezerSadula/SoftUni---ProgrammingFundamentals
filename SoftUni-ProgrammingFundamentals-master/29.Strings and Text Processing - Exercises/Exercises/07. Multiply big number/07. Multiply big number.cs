using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine().TrimStart('0');

            var secondNum = Console.ReadLine().TrimStart('0');

            if (firstNum.Length == 0 || secondNum.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(MultBigNums(firstNum, secondNum));
            }
        }

        private static string MultBigNums(string firstNum, string secondNum)
        {
            var digitsFirst = StringToDigitsArray(firstNum);
            var digitsSecond = StringToDigitsArray(secondNum);

            var carry = "0";
            var result = string.Empty;

            for (var i = digitsFirst.Length - 1; i >= 0; i--)
            {
                var power = 0;

                for (var j = digitsSecond.Length - 1; j >= 0; j--)
                {
                    var tempSum = digitsFirst[i] * digitsSecond[j]
                        * (int)Math.Pow(10, power++);

                    carry = SumBigNums(carry, tempSum.ToString());
                }

                result = carry.Last() + result;
                carry = carry.Substring(0, carry.Length - 1);
            }

            if (carry != "0")
            {
                result = carry + result;
            }

            return result;
        }

        private static string SumBigNums(string firstNum, string secondNum)
        {
            var elements = Math.Max(firstNum.Length, secondNum.Length);

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

            while (result.Count > 1 && result.Peek() == 0)
            {
                result.Pop();
            }

            return string.Concat(result);
        }

        private static int[] StringToDigitsArray(string numString, int elements = -1)
        {
            if (elements == -1)
            {
                elements = numString.Length;
            }

            return numString
                .PadLeft(elements, '0')
                .ToCharArray()
                .Select(x => x - '0')
                .ToArray();
        }
    }
}
