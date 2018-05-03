using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var catchedExceptions = 0;

            while (catchedExceptions < 3)
            {
                var tokens = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToList();

                var command = tokens[0];
                switch (command)
                {
                    case "replace":
                        {
                            if (!Replace(numbers, tokens))
                            {
                                catchedExceptions++;
                            }
                            break;
                        }
                    case "show":
                        {
                            if (!Show(numbers, tokens))
                            {
                                catchedExceptions++;
                            }
                            break;
                        }
                    case "print":
                        {
                            if (!Print(numbers, tokens))
                            {
                                catchedExceptions++;
                            }
                            break;
                        }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static bool Print(List<int> numbers, List<string> tokens)
        {
            int stratIndex;
            int endIndex;

            try
            {
                stratIndex = int.Parse(tokens[1]);
                endIndex = int.Parse(tokens[2]);

            }
            catch
            {
                Console.WriteLine("The variable is not in the correct format!");
                return false;
            }

            if (ValidateIndex(numbers, stratIndex) && ValidateIndex(numbers, endIndex))
            {
                var range = numbers.Skip(stratIndex).Take(endIndex - stratIndex + 1);
                Console.WriteLine(string.Join(", ", range));
                return true;
            }

            return false;
        }

        private static bool Show(List<int> numbers, List<string> tokens)
        {
            int index;

            try
            {
                index = int.Parse(tokens[1]);

            }
            catch
            {
                Console.WriteLine("The variable is not in the correct format!");
                return false;
            }

            if (ValidateIndex(numbers, index))
            {
                Console.WriteLine(numbers[index]);
                return true;
            }

            return false;
        }

        private static bool Replace(List<int> numbers, List<string> tokens)
        {
            int index;
            int number;

            try
            {
                index = int.Parse(tokens[1]);
                number = int.Parse(tokens[2]);

            }
            catch
            {
                Console.WriteLine("The variable is not in the correct format!");
                return false;
            }

            if (ValidateIndex(numbers, index))
            {
                numbers[index] = number;
                return true;
            }

            return false;
        }

        private static bool ValidateIndex(List<int> numbers, int index)
        {
            if (index >= numbers.Count || index < 0)
            {
                Console.WriteLine("The index does not exist!");
                return false;
            }

            return true;
        }
    }
}
