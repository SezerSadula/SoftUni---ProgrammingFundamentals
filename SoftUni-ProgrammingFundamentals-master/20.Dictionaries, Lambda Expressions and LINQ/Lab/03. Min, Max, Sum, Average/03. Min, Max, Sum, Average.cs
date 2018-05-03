using System;
using System.Linq;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            var numbers = new int[numbersToRead];

            for (int numIndex = 0; numIndex < numbersToRead; numIndex++)
            {
                numbers[numIndex] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
