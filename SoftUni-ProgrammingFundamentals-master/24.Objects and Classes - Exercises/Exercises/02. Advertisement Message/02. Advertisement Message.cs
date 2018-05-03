using System;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = new []
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new []
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new []
            {
                "Diana", "Petya",
                "Stella", "Elena",
                "Katya", "Iva",
                "Annie", "Eva"
            };

            var cities = new[]
            {
                "Burgas", "Sofia",
                "Plovdiv", "Varna",
                "Ruse"
            };

            var rnd = new Random();

            var messages = int.Parse(Console.ReadLine());
            while (messages-- > 0)
            {
                var phraseIndex = rnd.Next(0, phrases.Length);
                var eventIndex = rnd.Next(0, events.Length);
                var authorIndex = rnd.Next(0, authors.Length);
                var cityIndex = rnd.Next(0, cities.Length);

                Console.WriteLine("{0} {1} {2} - {3}",
                    phrases[phraseIndex], events[eventIndex],
                    authors[authorIndex], cities[cityIndex]); 
            }
        }
    }
}
