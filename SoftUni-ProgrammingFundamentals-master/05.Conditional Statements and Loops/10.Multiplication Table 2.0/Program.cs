using System;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int mult = int.Parse(Console.ReadLine());

            if (mult > 10)
            {
                Console.WriteLine($"{num} X {mult} = {num * mult}");
            }
            else
            {
                for (int i = mult; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
        }
    }
}
