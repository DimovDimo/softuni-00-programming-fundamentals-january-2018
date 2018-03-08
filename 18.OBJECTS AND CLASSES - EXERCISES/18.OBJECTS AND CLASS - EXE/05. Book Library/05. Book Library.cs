using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var countBooks = int.Parse(Console.ReadLine());
            var library = new Library();
            var books = new List<Book>();
            for (int i = 0; i < countBooks; i++)
            {
                var book = Book.ReadBook();
                books.Add(book);
            }

            library.Books = books;
            Library.PrintPricesByAuthor(library.Books);
        }
    }
}
