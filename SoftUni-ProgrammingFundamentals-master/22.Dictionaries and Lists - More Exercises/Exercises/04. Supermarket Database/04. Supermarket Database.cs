using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, Tuple<long, double>>();

            var command = Console.ReadLine();

            while (!command.Equals("stocked"))
            {
                var order = command
                    .Split()
                    .ToArray();
                var item = order[0];
                var price = double.Parse(order[1]);
                var quantity = long.Parse(order[2]);

                if (!database.ContainsKey(item))
                {
                    database[item] = new Tuple<long, double>(0L, 0d);
                }

                database[item] = new Tuple<long, double>(database[item].Item1 + quantity, price);

                command = Console.ReadLine();
            }

            var totalValue = 0d;
            foreach (var item in database)
            {
                var name = item.Key;
                var price = item.Value.Item2;
                var quantity = item.Value.Item1;
                var value = price * quantity;

                Console.WriteLine($"{name}: ${price:F2} * {quantity} = ${value:F2}");

                totalValue += value;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalValue:F2}");
        }
    }
}
