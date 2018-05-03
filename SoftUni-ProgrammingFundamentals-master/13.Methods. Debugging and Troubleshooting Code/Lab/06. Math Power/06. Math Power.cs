using System;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RiseNumberToPower(number, power));
        }

        static double RiseNumberToPower(double number, int power)
        {
            double result = number;
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
