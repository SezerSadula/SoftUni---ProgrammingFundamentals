using System;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower().Trim();

            switch (type)
            {
                case "int":
                    Console.WriteLine(GetMax(
                        int.Parse(Console.ReadLine()), 
                        int.Parse(Console.ReadLine())));
                    break;
                case "char":
                    Console.WriteLine(GetMax(
                        char.Parse(Console.ReadLine()), 
                        char.Parse(Console.ReadLine())));
                    break;
                default:
                    Console.WriteLine(GetMax(
                        Console.ReadLine(), 
                        Console.ReadLine()));
                    break;
            }
        }

        static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static char GetMax(char a, char b)
        {
            return (a > b) ? a : b;
        }

        static string GetMax(string a, string b)
        {
            return (String.Compare(a, b, StringComparison.Ordinal) > 0) ? a : b;
        }
    }
}
