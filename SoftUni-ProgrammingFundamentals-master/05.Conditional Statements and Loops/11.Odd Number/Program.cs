using System;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = Math.Abs(int.Parse(Console.ReadLine()));

                if (num % 2 == 1)
                {
                    Console.WriteLine($"The number is: {num}");
                    break;
                }

                Console.WriteLine("Please write an odd number.");
            }
        }
    }
}
