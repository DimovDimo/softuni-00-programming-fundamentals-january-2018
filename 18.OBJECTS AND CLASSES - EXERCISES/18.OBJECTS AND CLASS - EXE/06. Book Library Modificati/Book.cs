using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modificati
{
    class Book
    {
        //The books must contain the title, author, publisher, 
        //release date (in dd.MM.yyyy format), ISBN-number and price. 

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime Data { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        static public Book ReadBook()
        {
            //Books in the input will be in format {title} 
            //{ author} {publisher} {release date} {ISBN} {price}.
            var separated = Console.ReadLine()
                .Split(' ')
                .ToArray();
            return new Book
            {
                Title = separated[0],
                Author = separated[1],
                Publisher = separated[2],
                Data = DateTime.ParseExact(separated[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = separated[4],
                Price = decimal.Parse(separated[5])
            };
        }
    }
}
