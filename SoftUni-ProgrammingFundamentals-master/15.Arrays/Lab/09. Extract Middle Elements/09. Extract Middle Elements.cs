using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            int elements = numbers.Length;

            List<long> result = new List<long>();
            if (elements == 1)
            {
                result.Add(numbers[0]);
            }
            else if (elements % 2 == 0)
            {
                result.Add(numbers[(elements / 2) - 1]);
                result.Add(numbers[elements / 2]);
            }
            else
            {
                result.Add(numbers[(elements / 2) - 1]);
                result.Add(numbers[elements / 2]);
                result.Add(numbers[(elements / 2) + 1]);
            }

            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }
    }
}
