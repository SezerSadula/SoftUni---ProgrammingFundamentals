using System;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCaloriesAmount = 0;

            int ingredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < ingredients; i++)
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "cheese":
                        totalCaloriesAmount += 500;
                        break;
                    case "tomato sauce":
                        totalCaloriesAmount += 150;
                        break;
                    case "salami":
                        totalCaloriesAmount += 600;
                        break;
                    case "pepper":
                        totalCaloriesAmount += 50;
                        break;
                    default:
                        break;
                }
            }
            
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
