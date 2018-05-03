using System;
using System.Linq;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
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
            var number = input[1];
            var result = BigInteger.Zero;

            var pow = 0;
            while (!number.IsZero)
            {
                result += (number % 10) * BigInteger.Pow(baseN, pow++);
                number /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
