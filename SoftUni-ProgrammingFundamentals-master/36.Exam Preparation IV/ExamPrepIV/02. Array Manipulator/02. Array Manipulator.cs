using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            while (true)
            {
                var command = Console.ReadLine().ToLower();

                if ("end".Equals(command))
                {
                    break;
                }

                ExecuteCommand(command, ref numbers);
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void ExecuteCommand(string command, ref long[] numbers)
        {
            var tokens = command
                .Split()
                .Select(x => x.Trim())
                .ToArray();

            if ("exchange".Equals(tokens[0]))
            {
                var index = int.Parse(tokens[1]);

                if (index < 0 || index > numbers.Length - 1)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    var list = new List<long>();
                    list.AddRange(numbers.Skip(index + 1).Take(numbers.Length - index));
                    list.AddRange(numbers.Take(index + 1));
                    numbers = list.ToArray();
                }
            }
            else if ("max".Equals(tokens[0]))
            {
                var maxNum = long.MinValue;
                var index = -1;
                var rem = "even".Equals(tokens[1]) ? 0 : 1;

                for (var i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == rem && numbers[i] >= maxNum)
                    {
                        maxNum = numbers[i];
                        index = i;
                    }
                }

                if (index != -1)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if ("min".Equals(tokens[0]))
            {
                var minNum = long.MaxValue;
                var index = -1;
                var rem = "even".Equals(tokens[1]) ? 0 : 1;

                for (var i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == rem && numbers[i] <= minNum)
                    {
                        minNum = numbers[i];
                        index = i;
                    }
                }

                if (index != -1)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if ("first".Equals(tokens[0]))
            {
                var count = long.Parse(tokens[1]);

                if (count > numbers.Length)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }

                var rem = "even".Equals(tokens[2]) ? 0 : 1;
                var list = new List<long>();

                for (var i = 0; i < numbers.Length && count > 0; i++)
                {
                    if (numbers[i] % 2 == rem)
                    {
                        list.Add(numbers[i]);
                        count--;
                    }
                }

                Console.WriteLine($"[{string.Join(", ", list)}]");
            }
            else if ("last".Equals(tokens[0]))
            {
                var count = long.Parse(tokens[1]);

                if (count > numbers.Length)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }

                var rem = "even".Equals(tokens[2]) ? 0 : 1;
                var list = new LinkedList<long>();

                for (var i = numbers.Length - 1; i >= 0 && count > 0; i--)
                {
                    if (numbers[i] % 2 == rem)
                    {
                        list.AddFirst(numbers[i]);
                        count--;
                    }
                }

                Console.WriteLine($"[{string.Join(", ", list)}]");
            }
        }
    }
}
