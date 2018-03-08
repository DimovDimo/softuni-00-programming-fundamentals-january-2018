using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Senten_by_Key
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTarget = Console.ReadLine();
            var inputText = Console.ReadLine()
                .Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string pattern = $@"\b{inputTarget}\b";
            foreach (var text in inputText)
            {
                if (Regex.IsMatch(text, pattern))
                {
                    Console.WriteLine(text.Trim());
                }
            }
        }
    }
}
