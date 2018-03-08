using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"<a href=(.*?)>(.*?)<\/a>";
            var line = Console.ReadLine();
            while (line != "end")
            {
                string replacement = @"[URL href=$1]$2[/URL]";
                string repaced = Regex.Replace(line, regex, replacement);
                Console.WriteLine(repaced);
                line = Console.ReadLine();
            }
        }
    }
}
