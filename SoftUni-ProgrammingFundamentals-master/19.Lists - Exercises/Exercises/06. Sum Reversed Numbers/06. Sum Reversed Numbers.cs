using System;
using System.Linq;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Console.ReadLine()
                .Split()
                .Select(x => long.Parse(
                    new string(
                        x.ToCharArray()
                        .Reverse()
                        .ToArray())))
                .ToArray()
                .Sum();
            Console.WriteLine(sum);
        }
    }
}
