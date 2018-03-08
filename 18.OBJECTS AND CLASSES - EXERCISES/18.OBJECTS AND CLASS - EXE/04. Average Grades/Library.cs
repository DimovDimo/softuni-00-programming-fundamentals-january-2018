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

        static public Dictionary<string, DateTime> GetTitlesByData(List<Book> Books)
        {
            var titles = new Dictionary<string, DateTime>();
            for (int i = 0; i < Books.Count; i++)
            {
                var currentTitle = Books[i].Author;
                if (titles.ContainsKey(currentTitle) == false)
                {
                    var dataEmpty = new DateTime();
                    titles.Add(currentTitle, dataEmpty);
                }

                titles[currentTitle] = Books[i].Data;
            }

            return titles;
        }

        static public void PrintTitlesByData(List<Book> Books)
        {
            var titles = new Dictionary<string, decimal>();
            titles = Library.GetPricesByAuthor(Books);
            foreach (var author in titles.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }

        static public void PrintPricesByAuthor(List<Book> Books)
        {
            var authors = new Dictionary<string, decimal>();
            authors = Library.GetPricesByAuthor(Books);
            foreach (var author in authors.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }
}
