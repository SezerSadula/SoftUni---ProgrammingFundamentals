using System;
using System.Linq;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] quantities = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] prices = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string product = Console.ReadLine();

            while (product != "done")
            {
                int index = Array.IndexOf(products, product);
                Console.WriteLine($"{product} costs: {prices[index]}; Available quantity: {quantities[index]}");
                product = Console.ReadLine();
            }
        }
    }
}
