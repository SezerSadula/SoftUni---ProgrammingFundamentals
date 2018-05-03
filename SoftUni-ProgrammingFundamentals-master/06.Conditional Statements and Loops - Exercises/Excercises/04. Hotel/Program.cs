using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studioCostForTheStay = 0.0d;
            double doubleCostForTheStay = 0.0d;
            double suiteCostForTheStay = 0.0d;
            
            switch (month)
            {
                case "may":
                case "october":
                    studioCostForTheStay = 50.0d;
                    doubleCostForTheStay = 65.0d;
                    suiteCostForTheStay = 75.0d;
                    if (nights > 7)
                    {
                        studioCostForTheStay *= 0.95d;
                    }
                    break;
                case "june":
                case "september":
                    studioCostForTheStay = 60.0d;
                    doubleCostForTheStay = 72.0d;
                    suiteCostForTheStay = 82.0d;
                    if (nights > 14)
                    {
                        doubleCostForTheStay *= 0.90d;
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    studioCostForTheStay = 68.0d;
                    doubleCostForTheStay = 77.0d;
                    suiteCostForTheStay = 89.0d;
                    if (nights > 14)
                    {
                        suiteCostForTheStay *= 0.85d;
                    }
                    break;
                default:
                    break;
            }
            
            doubleCostForTheStay *= nights;
            suiteCostForTheStay *= nights;

            if (nights > 7 && (month == "september" || month == "october"))
            {
                nights--;
            }

            studioCostForTheStay *= nights;

            Console.WriteLine($"Studio: {studioCostForTheStay:F2} lv.");
            Console.WriteLine($"Double: {doubleCostForTheStay:F2} lv.");   
            Console.WriteLine($"Suite: {suiteCostForTheStay:F2} lv.");
        }
    }
}
