using System;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(numA, numB), numC));
        }

        static int GetMax(int numA, int numB)
        {
            return (numA > numB) ? numA : numB;
        }
    }
}
