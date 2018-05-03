using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (!command.Equals("print"))
            {
                string[] tokens = command
                    .Split(' ')
                    .ToArray();

                switch (tokens[0])
                {
                    case "add":
                        numbers.Insert(int.Parse(tokens[1]), 
                            long.Parse(tokens[2]));
                        break;
                    case "addMany":
                        var newElements = tokens
                            .Skip(2)
                            .Select(long.Parse)
                            .ToList();
                        numbers.InsertRange(int.Parse(tokens[1]), 
                            newElements);
                        break;
                    case "contains":
                        Console.WriteLine(numbers
                            .IndexOf(long.Parse(tokens[1])));
                        break;
                    case "remove":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "shift":
                        int positions = int.Parse(tokens[1]) % numbers.Count;
                        numbers = numbers
                            .Skip(positions)
                            .Concat(numbers.Take(positions))
                            .ToList();
                        break;
                    case "sumPairs":
                        List<long> newNumbers = new List<long>();

                        long sum = 0;

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];

                            if (i % 2 == 1)
                            {
                                newNumbers.Add(sum);
                                sum = 0;
                            }
                        }

                        if (numbers.Count % 2 == 1)
                        {
                            newNumbers.Add(numbers.Last());
                        }

                        numbers = newNumbers;
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
