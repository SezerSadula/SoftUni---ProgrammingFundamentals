using System;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                int num = i;
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
