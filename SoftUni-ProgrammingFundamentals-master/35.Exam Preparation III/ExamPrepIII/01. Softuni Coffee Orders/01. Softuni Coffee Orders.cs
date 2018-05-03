using System;
using System.Linq;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main()
        {
            var totalPrice = 0M;
            var orders = int.Parse(Console.ReadLine());

            while (orders-- > 0)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());

                var date = Console.ReadLine()
                    .Split('/')
                    .Select(int.Parse)
                    .ToArray();

                var daysInMonth = DateTime.DaysInMonth(date[2], date[1]);

                var capsulesCount = int.Parse(Console.ReadLine());

                var price = pricePerCapsule * daysInMonth * capsulesCount;

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
