using System;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            byte start = byte.Parse(Console.ReadLine());
            byte end = byte.Parse(Console.ReadLine());

            for (int chrIndex = start; chrIndex <= end; chrIndex++)
            {
                Console.Write($"{(char)chrIndex} ");
            }

            Console.WriteLine();
        }
    }
}
