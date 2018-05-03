using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int index = 1; index < numbers.Count; index++)
            {
                if (numbers[index - 1] == numbers[index])
                {
                    numbers[index - 1] *= 2d;
                    numbers.RemoveAt(index);
                    index = 0;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
