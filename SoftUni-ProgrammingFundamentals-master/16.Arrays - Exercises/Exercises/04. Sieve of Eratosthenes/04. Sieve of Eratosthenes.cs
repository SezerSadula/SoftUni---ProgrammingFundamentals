using System;
using System.Linq;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            bool [] primes = new bool[limit + 1]
                .Select(x => true)
                .ToArray();

            int cc = (int) Math.Ceiling(Math.Sqrt(limit));
            for (int i = 2; i <= cc; i++)
            {
                if (primes[i])
                {
                    for (int j = i + i; j <= limit; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 2; i <= limit; i++)
            {
                if (primes[i])
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}