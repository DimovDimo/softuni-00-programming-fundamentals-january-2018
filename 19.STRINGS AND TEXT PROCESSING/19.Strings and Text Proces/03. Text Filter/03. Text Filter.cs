using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var banWords = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                text = text.Replace(banWord, 
                    new string('*', banWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
