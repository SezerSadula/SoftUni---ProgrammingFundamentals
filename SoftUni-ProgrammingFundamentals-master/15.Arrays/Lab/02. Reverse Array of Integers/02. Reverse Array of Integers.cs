using System;
using System.Linq;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());

            int[] numbers = new int[elements];

            for (int i = 0; i < elements; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
