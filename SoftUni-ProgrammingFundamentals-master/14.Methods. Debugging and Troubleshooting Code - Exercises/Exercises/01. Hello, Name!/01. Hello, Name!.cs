using System;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintGreatingByName(name);
        }

        static void PrintGreatingByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
