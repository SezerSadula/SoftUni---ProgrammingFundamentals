using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            var booksToParse = int.Parse(Console.ReadLine());

            while (booksToParse-- > 0)
            {
                library.Books.Add(new Book(Console.ReadLine().Split()));
            }

            var authorsPrice = new Dictionary<string, double>();
            foreach (var book in library.Books)
            {
                if (!authorsPrice.ContainsKey(book.Author))
                {
                    authorsPrice.Add(book.Author, 0d);
                }

                authorsPrice[book.Author] += book.Price;
            }

            var sorted = authorsPrice
                .OrderByDescending(a => a.Value)
                .ThenBy(a => a.Key);

            foreach (var author in sorted)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name = "")
        {
            Name = name;
            Books = new List<Book>();
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ulong ISBN { get; set; }
        public double Price { get; set; }

        public Book(string [] bookData)
        {
            Title = bookData[0];
            Author = bookData[1];
            Publisher = bookData[2];
            ReleaseDate = ParseDate(bookData[3]);
            ISBN = ulong.Parse(bookData[4]);
            Price = double.Parse(bookData[5]);
        }

        private static DateTime ParseDate(string date)
        {
            return DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }
    }
}
