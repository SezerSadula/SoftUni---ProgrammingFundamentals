using System;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());

            ulong trailingZeroes = 0;
            ulong lastZeroes = 1;
            ulong powerOfFive = 1;

            while (lastZeroes > 0)
            {
                powerOfFive *= 5;
                lastZeroes = n / powerOfFive;
                trailingZeroes += lastZeroes;
            }

            Console.WriteLine(trailingZeroes);
        }
    }
}
