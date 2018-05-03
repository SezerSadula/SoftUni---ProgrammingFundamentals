using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
