using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volume = Int32.Parse(Console.ReadLine());
            int energy = Int32.Parse(Console.ReadLine());
            int sugar = Int32.Parse(Console.ReadLine());

            double kcal = energy * volume / 100.0d;
            double sugars = sugar * volume / 100.0d;
            Console.WriteLine("{0}ml {1}:", volume, productName);
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
