using System;
using System.Collections.Generic;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemsToRead = int.Parse(Console.ReadLine());

            var items = new Dictionary<string, decimal>();
            while (itemsToRead-- > 0)
            {
                var itemData = Console.ReadLine().Split('-');

                items[itemData[0]] = decimal.Parse(itemData[1]);
            }

            var clientsOrders = new SortedDictionary<string, Dictionary<string, int>>();

            string orderStr = Console.ReadLine();
            while (!"end of clients".Equals(orderStr))
            {
                var orderData = orderStr.Split('-');
                var name = orderData[0];
                var item = orderData[1].Split(',')[0];
                var quantity = int.Parse(orderData[1].Split(',')[1]);

                if (items.ContainsKey(item))
                {
                    if (!clientsOrders.ContainsKey(name))
                    {
                        clientsOrders[name] = new Dictionary<string, int>();
                    }

                    if (!clientsOrders[name].ContainsKey(item))
                    {
                        clientsOrders[name][item] = 0;
                    }

                    clientsOrders[name][item] += quantity;
                }

                orderStr = Console.ReadLine();
            }

            var totalBill = 0M;
            foreach (var clientOrders in clientsOrders)
            {
                var bill = 0M;
                Console.WriteLine(clientOrders.Key);
                foreach (var order in clientOrders.Value)
                {
                    var type = order.Key;
                    var count = order.Value;
                    Console.WriteLine($"-- {type} - {count}");
                    bill += items[type] * count;
                }

                Console.WriteLine($"Bill: {bill:F2}");

                totalBill += bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}
