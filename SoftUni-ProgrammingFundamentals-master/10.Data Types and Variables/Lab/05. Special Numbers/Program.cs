using System;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} -> {IsSpecial(FindSum(i))}");
            }
        }

        private static bool IsSpecial(int num)
        {
            return num == 5 || num == 7 || num == 11;
        }

        private static int FindSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
