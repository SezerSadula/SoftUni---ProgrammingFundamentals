using System;
using System.Linq;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine()
                .Split(' ')
                .ToArray();

            
            long[] quantities= Console.ReadLine()
                .Split(' ')
                .Select(x => long.Parse(x))
                .ToArray();
            Array.Resize<long>(ref quantities, products.Length);

            double[] prices = Console.ReadLine()
                .Split(' ')
                .Select(x => double.Parse(x))
                .ToArray();

            string order = Console.ReadLine();

            while (order != "done")
            {
                string[] orderSplit = order.Split(' ').ToArray();
                string product  = orderSplit[0];
                long quantity = long.Parse(orderSplit[1]);
                int index = Array.IndexOf(products, product);

                if (quantity <= quantities[index])
                {
                    double cost = quantity * prices[index];
                    quantities[index] -= quantity;
                    Console.WriteLine($"{product} x {quantity} costs {cost:F2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {product}");
                }

                order = Console.ReadLine();
            }
        }
    }
}
