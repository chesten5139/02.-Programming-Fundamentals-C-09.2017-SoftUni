using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace _06.BookLibraryModification
{
    public class Book
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    class BookLibraryModification
    {
        static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var bookProperties = Console.ReadLine().Split(' ').ToList();
                var book = new Book();
                book.Title = bookProperties[0];
                book.ReleaseDate = DateTime.ParseExact(bookProperties[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                books.Add(book);
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in books.OrderBy(x => x.ReleaseDate).ThenBy(y => y.Title))
            {
                if (book.ReleaseDate > date)
                {
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Title, book.ReleaseDate);
                }
            }

        }
    }
}
