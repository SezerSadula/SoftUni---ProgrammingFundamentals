using System;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredients = 0;

            string ingredient = Console.ReadLine();
            while (ingredient != "Bake!")
            {
                ingredients++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}
