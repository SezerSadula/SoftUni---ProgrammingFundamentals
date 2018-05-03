using System;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            float quantity = float.Parse(Console.ReadLine());
            float cost;

            switch (profession)
            {
                case "Athlete":
                    cost = 0.7f;
                    break;
                case "Businessman":
                case "Businesswoman":
                    cost = 1.0f;
                    break;
                case "SoftUni Student":
                    cost = 1.7f;
                    break;
                default:
                    cost = 1.2f;
                    break;
            }

            cost *= quantity;

            Console.WriteLine($"The {profession} has to pay {cost:F2}.");
        }
    }
}
