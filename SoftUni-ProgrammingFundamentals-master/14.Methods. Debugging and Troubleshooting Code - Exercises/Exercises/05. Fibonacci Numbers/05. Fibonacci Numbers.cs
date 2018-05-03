using System;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }

        static ulong n1 = 0UL;
        static ulong n2 = 1UL;
        static ulong n3 = 0UL;

        static ulong Fib(int n)
        {
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;

            if (n > 1)
            {
                Fib(n - 1);
            }

            return n3;
        }
    }
}
