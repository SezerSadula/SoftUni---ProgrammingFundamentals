using System;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            double cost;
            string hallName;

            if (groupSize <= 50)
            {
                cost = 2500.0d;
                hallName = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                cost = 5000.0d;
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                cost = 7500.0d;
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "normal":
                    cost += 500.0d;
                    cost *= 0.95d;
                    break;
                case "gold":
                    cost += 750.0d;
                    cost *= 0.9d;
                    break;
                case "platinum":
                    cost += 1000.0d;
                    cost *= 0.85d;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {(cost / groupSize):F2}$");
        }
    }
}
