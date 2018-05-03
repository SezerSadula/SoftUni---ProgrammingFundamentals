using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] commands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int index = numbers
                .IndexOf(
                    commands[2], 
                    commands[1], 
                    commands[0] - commands[1]);

            if (index < 0)
            {
                Console.WriteLine("NO!");
            }
            else
            {
                Console.WriteLine("YES!");
            }
        }
    }
}
