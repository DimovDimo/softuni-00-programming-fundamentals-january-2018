using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modificati
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

        static public Dictionary<string, DateTime> GetTitlesAfterData(List<Book> Books, DateTime targetData)
        {
            var titles = new Dictionary<string, DateTime>();
            for (int i = 0; i < Books.Count; i++)
            {
                var currentTitle = Books[i].Title;
                if (titles.ContainsKey(currentTitle) == false
                    && (DateTime.Compare(Books[i].Data, targetData) > 0))
                {
                    var dataEmpty = new DateTime();
                    titles.Add(currentTitle, dataEmpty);
                    titles[currentTitle] = Books[i].Data;
                }
            }

            return titles;
        }

        static public void PrintTitlesByData(List<Book> books, DateTime targetData)
        {
            //books.GroupBy(x => x.Author)
            //   .OrderByDescending(x => x.Sum(y => y.Price))
            //   .ThenBy(x => x.Key)
            foreach (var book in books.Where(x => x.Data > targetData)
                .OrderBy(x => x.Data)
                .ThenBy(x => x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.Data.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}");
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
