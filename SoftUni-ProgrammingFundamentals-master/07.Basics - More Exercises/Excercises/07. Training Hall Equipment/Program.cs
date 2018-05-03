using System;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemsToBuy = int.Parse(Console.ReadLine());

            double total = 0.0d;

            for (int i = 0; i < itemsToBuy; i++)
            {
                string itemName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());

                if (quantity > 1)
                {
                    itemName = itemName + "s";
                }
                
                Console.WriteLine($"Adding {quantity} {itemName} to cart.");

                total += price * quantity;

                if (total > budget)
                {
                    Console.WriteLine($"Subtotal: ${total:F2}");
                    Console.WriteLine($"Not enough. We need ${total - budget:F2} more.");
                    return;
                }
            }

            Console.WriteLine($"Subtotal: ${total:F2}");
            Console.WriteLine($"Money left: ${budget - total:F2}");
        }
    }
}
