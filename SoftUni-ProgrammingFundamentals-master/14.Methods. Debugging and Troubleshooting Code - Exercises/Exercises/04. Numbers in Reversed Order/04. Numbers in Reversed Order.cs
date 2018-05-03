using System;
using System.Text;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine().Trim();

            PrintInReversedOrder(numberString);
        }

        static void PrintInReversedOrder(string textToReverse)
        {
            StringBuilder reversedNumber = new StringBuilder();

            for (int i = textToReverse.Length - 1; i >= 0; i--)
            {
                reversedNumber.Append(textToReverse[i]);
            }

            Console.WriteLine(reversedNumber.ToString());
        }
    }
}
