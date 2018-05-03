using System;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int stopper = int.Parse(Console.ReadLine());

            int combinations = 0;
            int total = 0;
            for (int i = first; i > 0; i--)
            {
                for (int j = 1; j <= second; j++)
                {
                    combinations++;
                    total += 3 * i * j;

                    if (total >= stopper)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {total} >= {stopper}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {total}");
        }
    }
}
