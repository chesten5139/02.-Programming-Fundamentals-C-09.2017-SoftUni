using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    public class AuthorSales
    {
        public string Author { get; set; }
        public double Sales { get; set; }
    }

    class BookLibrary
    {
        static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Library myLibrary = new Library()
            {
                Name = "Library",
                Books = new List<Book>()
            };

            for (int i = 0; i < numberOfBooks; i++)
            {
                var bookProperties = Console.ReadLine().Split(' ').ToList();
                var book = new Book();
                book.Title = bookProperties[0];
                book.Author = bookProperties[1];
                book.Publisher = bookProperties[2];
                book.ReleaseDate = DateTime.ParseExact(bookProperties[3],"dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = bookProperties[4];
                book.Price = double.Parse(bookProperties[5]);
                myLibrary.Books.Add(book);
            }

            var authorsSales = new List<AuthorSales>();

            var authors = myLibrary.Books.Select(a => a.Author).Distinct().ToArray();

            foreach (var author in authors)
            {
                var sales = myLibrary.Books.Where(a => a.Author == author).Sum(a => a.Price);
                authorsSales.Add(new AuthorSales()
                {
                    Author = author,
                    Sales = sales
                });
            }

            authorsSales = authorsSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Author).ToList();

            foreach (var sale in authorsSales)
            {
                Console.WriteLine("{0} -> {1:F2}", sale.Author, sale.Sales);
            }

        }
    }
}
