using System;

namespace _02.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();

            try
            {
                long num = long.Parse(numberString);
                Console.WriteLine("integer");
            }
            catch
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
