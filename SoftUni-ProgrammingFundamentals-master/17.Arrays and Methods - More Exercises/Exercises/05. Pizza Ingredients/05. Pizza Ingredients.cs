using System;
using System.Linq;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split(' ').ToArray();

            var ingredientLenght = int.Parse(Console.ReadLine());

            var addedIngredients = ingredients
                .Select((p, i) => new { Item = p, Index = i })
                .Where(p => p.Item.Length == ingredientLenght)
                .Select(p => p.Item)
                .Take(10)
                .ToArray();

            foreach (var ingredient in addedIngredients)
            {
                Console.WriteLine($"Adding {ingredient}.");
            }

            Console.WriteLine($"Made pizza with total of {addedIngredients.Count()} ingredients.");
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", addedIngredients));
        }
    }
}
