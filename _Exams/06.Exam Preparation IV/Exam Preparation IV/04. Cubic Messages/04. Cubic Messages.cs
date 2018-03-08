using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "Over!")
            {
                var validLenght = int.Parse(Console.ReadLine());
                var pattern = @"(\d+)([A-Za-z]+)([^A-Za-z]+)(.*)";
                MatchCollection matches = Regex.Matches(input, pattern);
                

                input = Console.ReadLine();
            }
        }
    }
}
