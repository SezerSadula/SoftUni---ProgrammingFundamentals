using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool readNextCommand = true;
            while (readNextCommand)
            {
                string[] command = Console.ReadLine()
                    .ToLower()
                    .Split(' ')
                    .ToArray();

                switch (command[0])
                {
                    case "delete":
                        numbers.RemoveAll(x => x == int.Parse(command[1]));
                        break;
                    case "insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "odd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)));
                        readNextCommand = false;
                        break;
                    case "even":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                        readNextCommand = false;
                        break;
                }
            }
        }
    }
}
