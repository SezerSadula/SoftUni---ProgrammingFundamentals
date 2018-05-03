using System;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = decimal.Parse(Console.ReadLine());
            var priceBanana = decimal.Parse(Console.ReadLine()) * 2M;
            var priceEggs = decimal.Parse(Console.ReadLine()) * 4M;
            var priceBerries = decimal.Parse(Console.ReadLine()) * 0.2M;

            var costPerDessert = priceBanana + priceEggs + priceBerries;
            var dessertsNeeded = Math.Ceiling(guests / 6M);

            var neededMoney = dessertsNeeded * costPerDessert;

            Console.WriteLine(neededMoney <= cash
                ? $"Ivancho has enough money - it would cost {neededMoney:F2}lv."
                : $"Ivancho will have to withdraw money - he will need {neededMoney - cash:F2}lv more.");
        }
    }
}
