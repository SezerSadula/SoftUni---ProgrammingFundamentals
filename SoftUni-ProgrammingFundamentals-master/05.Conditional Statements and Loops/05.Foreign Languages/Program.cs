using System;

namespace _05.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
