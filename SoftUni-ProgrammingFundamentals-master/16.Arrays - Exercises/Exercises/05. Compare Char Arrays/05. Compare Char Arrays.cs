using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] first = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char [] second = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            bool equal = true;
            bool firstArray = true;

            int lenToCompare = (first.Length < second.Length) ? 
                first.Length : second.Length;
            for (int i = 0; i < lenToCompare; i++)
            {
                equal = first[i] == second[i];

                if (!equal)
                {
                    if (first[i] > second[i])
                    {
                        firstArray = false;
                    }
                    break;
                }
            }

            if (equal)
            {
                if (first.Length > second.Length)
                {
                    firstArray = false;
                }
            }

            if (firstArray)
            {
                Console.WriteLine(first);
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(second);
                Console.WriteLine(first);
            }
        }
    }
}
