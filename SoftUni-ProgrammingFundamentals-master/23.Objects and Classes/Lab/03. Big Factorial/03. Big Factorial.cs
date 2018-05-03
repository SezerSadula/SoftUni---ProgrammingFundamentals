using System;
using System.Numerics;

namespace _03.Big_Factorial
{
    internal class Program
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var factorial = BigInteger.One;

            for (var i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
