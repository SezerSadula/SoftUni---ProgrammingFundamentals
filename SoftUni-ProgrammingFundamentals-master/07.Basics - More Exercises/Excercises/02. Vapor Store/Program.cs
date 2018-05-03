using System;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double initialBuddget = balance;

            while (true)
            {
                double cost = 0.0d;

                string command = Console.ReadLine();
                switch (command)
                {
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${initialBuddget - balance:F2}. Remaining: ${balance:F2}");
                        return;
                    case "OutFall 4":
                        cost = 39.99d;
                        break;
                    case "CS: OG":
                        cost = 15.99d;
                        break;
                    case "Zplinter Zell":
                        cost = 19.99d;
                        break;
                    case "Honored 2":
                        cost = 59.99d;
                        break;
                    case "RoverWatch":
                        cost = 29.99d;
                        break;
                    case "RoverWatch Origins Edition":
                        cost = 39.99d;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (cost <= balance)
                {
                    Console.WriteLine($"Bought {command}");
                    balance -= cost;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                if (balance <= 0.0d)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
        }
    }
}
