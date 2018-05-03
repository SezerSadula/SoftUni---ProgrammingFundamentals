using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Serbian_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var venues = new Dictionary<string, Dictionary<string, long>>();

            string concert = Console.ReadLine();

            while (!concert.Equals("End"))
            {
                if (ValidateInput(concert))
                {
                    var artist = concert
                        .Split('@')[0]
                        .Trim();

                    var venueDetails = concert
                        .Split('@')[1]
                        .Split();
                    var venueTokens = venueDetails.Length;

                    var venue = concert.Substring(artist.Length + 2,
                    concert.Length - artist.Length - 2 - 
                    venueDetails[venueTokens - 1].Length -
                    venueDetails[venueTokens - 2].Length - 2);

                    var ticketsCount = int.Parse(venueDetails[venueTokens - 1]);

                    var ticketsPrice = int.Parse(venueDetails[venueTokens - 2]);

                    long revenues = ticketsCount * ticketsPrice;

                    if (!venues.ContainsKey(venue))
                    {
                        venues[venue] = new Dictionary<string, long>();
                    }

                    if (!venues[venue].ContainsKey(artist))
                    {
                        venues[venue][artist] = 0L;
                    }

                    venues[venue][artist] += revenues;
                }

                concert = Console.ReadLine();
            }

            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);
                foreach (var artist in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {artist.Key} -> {artist.Value}");
                }
            }
        }

        private static bool ValidateInput(string concert)
        {
            var nameSplit = concert.Split('@');
            if (!nameSplit[0].EndsWith(" "))
            {
                return false;
            }

            var venueSplit = nameSplit[1].Split();

            if (venueSplit.Length < 3)
            {
                return false;
            }

            var ticketsValidation = venueSplit[venueSplit.Length - 1]
                .ToCharArray()
                .All(char.IsDigit);

            var priceValidation = venueSplit[venueSplit.Length - 2]
                .ToCharArray()
                .All(char.IsDigit);

            return ticketsValidation && priceValidation;
        }
    }
}
