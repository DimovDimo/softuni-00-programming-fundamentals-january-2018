using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToCharArray();
                //.Select(x => x.ToString())
                //.Select(int.Parse);
            foreach (var oneChar in input)
            {
                Console.Write(GetEscapeSequence(oneChar).ToLower());
            }
        }

        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}
