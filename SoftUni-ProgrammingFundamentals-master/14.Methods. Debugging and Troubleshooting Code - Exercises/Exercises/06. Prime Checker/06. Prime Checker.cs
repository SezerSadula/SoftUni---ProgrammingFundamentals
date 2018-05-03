using System;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }

            long maxNum = (long)Math.Sqrt(number);
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
