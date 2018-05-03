using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

            string command = Console.ReadLine();

            while (!command.Equals("END"))
            {
                var tokens = command.Split().ToArray();

                if (tokens[0] == "A")
                {
                    phonebook[tokens[1]] = tokens[2];
                }
                else if (tokens[0] == "ListAll")
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                else
                {
                    var name = tokens[1];
                    Console.WriteLine(phonebook.ContainsKey(name)
                        ? $"{name} -> {phonebook[name]}"
                        : $"Contact {name} does not exist.");
                }

                command = Console.ReadLine();
            }
        }
    }
}
