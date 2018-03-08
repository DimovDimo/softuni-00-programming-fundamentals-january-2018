using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        static public Dictionary<string, decimal> GetPricesByAuthor(List<Book> Books)
        {
            var authors = new Dictionary<string, decimal>();
            for (int i = 0; i < Books.Count; i++)
            {
                var currentAuthor = Books[i].Author;
                if (authors.ContainsKey(currentAuthor) == false)
                {
                    authors.Add(currentAuthor, 0.0m);
                }

                authors[currentAuthor] += Books[i].Price;
            }

            return authors;
        }

        static public void PrintPricesByAuthor(List<Book> books)
        {
            foreach (var book in books.GroupBy(x => x.Author)
                .OrderByDescending(x => x.Sum(y => y.Price))
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(x => x.Price):F2}");
            }
        }
    }
}
