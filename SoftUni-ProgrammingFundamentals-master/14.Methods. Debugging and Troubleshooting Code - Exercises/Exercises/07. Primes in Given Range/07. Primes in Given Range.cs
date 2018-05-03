using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long startNumber = long.Parse(Console.ReadLine());
            long endNumber = long.Parse(Console.ReadLine());

            List<long> primes = new List<long>();

            for (long i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", primes));
        }

        static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }

            long maxNum = (long) Math.Sqrt(number);
            for (long i = 2; i <= maxNum; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
