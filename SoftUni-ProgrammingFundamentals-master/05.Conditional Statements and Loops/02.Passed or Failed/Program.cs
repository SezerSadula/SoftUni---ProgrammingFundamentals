using System;

namespace _02.Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(((double.Parse(Console.ReadLine())) >= 3.0d) ? "Passed!" : "Failed!");
        }
    }
}
