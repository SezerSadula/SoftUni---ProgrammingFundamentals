using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(BigInteger.Parse)
                .ToArray();

            var baseN = input[0];
            var decNum = input[1];

            var digits = new Stack<BigInteger>();

            while (decNum > 0)
            {
                digits.Push(decNum % baseN);
                decNum /= baseN;
            }

            var sb = new StringBuilder();

            while (digits.Count > 0)
            {
                sb.Append(digits.Pop());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
