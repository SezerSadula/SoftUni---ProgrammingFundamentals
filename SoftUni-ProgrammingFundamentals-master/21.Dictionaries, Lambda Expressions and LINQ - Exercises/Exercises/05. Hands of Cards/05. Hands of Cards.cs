using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, HashSet<string>>();

            var round = Console.ReadLine();

            while (!round.Equals("JOKER"))
            {
                var hand = round.Split(':').ToList();
                var player = hand[0];
                var cards = hand[1]
                    .Split(new [] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (!players.ContainsKey(player))
                {
                    players[player] = new HashSet<string>();
                }

                players[player].UnionWith(cards);

                round = Console.ReadLine();
            }

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key}: {GetCardsScore(player.Value)}");
            }
        }

        private static int GetCardsScore(HashSet<string> cards)
        {
            var score = 0;
            foreach (var card in cards)
            {
                score += GetCardScore(card);
            }
            return score;
        }

        private static int GetCardScore(string card)
        {
            var cardBase = 0;
            switch (card[0])
            {
                case 'J':
                    cardBase = 11;
                    break;
                case 'Q':
                    cardBase = 12;
                    break;
                case 'K':
                    cardBase = 13;
                    break;
                case 'A':
                    cardBase = 14;
                    break;
                default:
                    cardBase = int.Parse(card.Substring(0, card.Length - 1));
                    break;
            }

            var cardMultiplier = 1;
            switch (card.Substring(card.Length - 1))
            {
                case "S":
                    cardMultiplier = 4;
                    break;
                case "H":
                    cardMultiplier = 3;
                    break;
                case "D":
                    cardMultiplier = 2;
                    break;
                case "C":
                    cardMultiplier = 1;
                    break;
            }

            return cardBase * cardMultiplier;
        }
    }
}
