using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            string command = Console.ReadLine();

            while (!command.Equals("END"))
            {
                var tokens = command.Split().ToArray();
                var name = tokens[1];

                if (tokens[0] == "A")
                {
                    phonebook[name] = tokens[2];
                }
                else
                {
                    Console.WriteLine(phonebook.ContainsKey(name)
                        ? $"{name} -> {phonebook[name]}"
                        : $"Contact {name} does not exist.");
                }

                command = Console.ReadLine();
            }
        }
    }
}
