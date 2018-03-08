using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modificati
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
            var targetData = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Library.PrintTitlesByData(library.Books, targetData);
        }
    }
}
