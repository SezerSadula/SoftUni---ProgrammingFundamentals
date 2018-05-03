using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        static void Main()
        {
            var pokemons = new Dictionary<string, List<PokemonEvolution>>();

            while (true)
            {
                var input = Console.ReadLine();

                if ("wubbalubbadubdub".Equals(input))
                {
                    break;
                }

                var tokens = input
                    .Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var name = tokens[0];

                if (tokens.Length == 1)
                {
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");

                        foreach (var pokemonEvolution in pokemons[name])
                        {
                            Console.WriteLine(pokemonEvolution);
                        }
                    }

                    continue;
                }

                var evolution = tokens[1];
                var index = int.Parse(tokens[2]);

                if (!pokemons.ContainsKey(name))
                {
                    pokemons.Add(name, new List<PokemonEvolution>());
                }

                pokemons[name].Add(new PokemonEvolution(evolution, index));

            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var pokemonEvolution in pokemon.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine(pokemonEvolution);
                }
            }
        }

        private class PokemonEvolution
        {
            public string Evolution { get; }
            public int Index { get; }

            public PokemonEvolution(string evolution, int index)
            {
                Evolution = evolution;
                Index = index;
            }

            public override string ToString()
            {
                return $"{Evolution} <-> {Index}";
            }
        }
    }
}
