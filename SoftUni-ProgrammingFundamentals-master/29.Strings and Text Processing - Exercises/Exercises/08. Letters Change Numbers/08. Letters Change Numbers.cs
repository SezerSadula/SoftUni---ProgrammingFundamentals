using System;
using System.Linq;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = 0d;

            foreach (var numStr in input)
            {
                var num = double.Parse(numStr.Substring(1, numStr.Length - 2));
                var firstLetter = numStr[0];
                var lastLetter = numStr[numStr.Length - 1];

                if (char.IsUpper(firstLetter))
                {
                    num /= firstLetter - 'A' + 1;
                }
                else
                {
                    num *= firstLetter - 'a' + 1;
                }

                if (char.IsUpper(lastLetter))
                {
                    num -= lastLetter - 'A' + 1;
                }
                else
                {
                    num += lastLetter - 'a' + 1;
                }

                result += num;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
