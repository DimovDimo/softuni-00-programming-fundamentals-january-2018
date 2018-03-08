using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();
            while (Regex.IsMatch(input, pattern))
            {
                if (pattern.Length == 0)
                {
                    break;
                }

                if (Regex.IsMatch(input, pattern))
                {
                    MatchCollection matches = Regex.Matches(input, pattern);
                    if (matches.Count >= 2)
                    {
                        Console.WriteLine("Shaked it.");
                        Regex rgx = new Regex($@"{pattern}");
                        input = rgx.Replace(input, "");
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);


            //var splited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //foreach (var word in splited)
            //{
            //    if (Regex.IsMatch(word, pattern))
            //    {
            //        Console.WriteLine("Shaked it.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No shake.");
            //    }
            //}
            //
            //var output = Regex.Replace(input, $@"{pattern}", "");
            //Console.WriteLine(output);
        }
    }
}
