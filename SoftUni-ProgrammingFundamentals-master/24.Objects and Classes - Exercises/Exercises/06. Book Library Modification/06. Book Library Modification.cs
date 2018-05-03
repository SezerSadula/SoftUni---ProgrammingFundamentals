using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.Book_Library_Modification
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

            var checkDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var titlesByDate = new Dictionary<string, DateTime>();
            foreach (var book in library.Books)
            {
                if (book.ReleaseDate > checkDate)
                {
                    titlesByDate[book.Title] = book.ReleaseDate;
                }
            }

            var sorted = titlesByDate
                .OrderBy(a => a.Value)
                .ThenBy(a => a.Key);

            foreach (var title in sorted)
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", title.Key, title.Value);
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

        public Book(string[] bookData)
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
