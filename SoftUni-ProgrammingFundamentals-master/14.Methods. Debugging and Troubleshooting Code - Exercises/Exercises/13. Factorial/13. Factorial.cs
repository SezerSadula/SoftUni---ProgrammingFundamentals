using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = BigInteger.One;

            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }
    }
}
