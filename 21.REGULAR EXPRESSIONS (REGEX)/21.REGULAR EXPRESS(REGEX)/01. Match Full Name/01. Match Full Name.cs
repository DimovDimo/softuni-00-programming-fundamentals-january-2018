using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+\s+[A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection mathedNames = Regex.Matches(names, regex);
            foreach (Match name in mathedNames)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
