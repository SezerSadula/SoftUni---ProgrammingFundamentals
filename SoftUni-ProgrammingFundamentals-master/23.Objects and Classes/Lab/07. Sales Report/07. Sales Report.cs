using System;
using System.Collections.Generic;

namespace _07.Sales_Report
{
    internal class Program
    {
        private static void Main()
        {
            var salesPerTown = new SortedDictionary<string, decimal>();

            var n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                var sale = Sale.Parse(Console.ReadLine());

                if (!salesPerTown.ContainsKey(sale.Town))
                {
                    salesPerTown.Add(sale.Town, 0M);
                }

                salesPerTown[sale.Town] += sale.Quantity * sale.Price;
            }

            foreach (var sales in salesPerTown)
            {
                Console.WriteLine($"{sales.Key} -> {sales.Value:F2}");
            }
        }
    }

    internal class Sale
    {
        public string Town { get; }
        public string Product { get; }
        public decimal Price { get; }
        public decimal Quantity { get; }

        public Sale(string town, string product, decimal price, decimal quantity)
        {
            Town = town;
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public static Sale Parse(string details)
        {
            var saleDetails = details.Split();
            return new Sale(
                saleDetails[0],
                saleDetails[1],
                decimal.Parse(saleDetails[2]),
                decimal.Parse(saleDetails[3]));
        }
    }
}
