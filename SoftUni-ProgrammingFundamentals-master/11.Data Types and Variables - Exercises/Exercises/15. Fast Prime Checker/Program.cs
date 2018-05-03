using System;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for (int num = 2; num <= limit; num++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
                {
                    if (num % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isPrime}");
            }
        }
    }
}
