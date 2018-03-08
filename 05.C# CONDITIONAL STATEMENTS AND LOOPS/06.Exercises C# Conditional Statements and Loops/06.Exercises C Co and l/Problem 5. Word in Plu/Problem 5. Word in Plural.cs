using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Word_in_Plu
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            if (word.EndsWith("y") == true)
            {
                word = word.Remove(word.Length - 1) + "ies";
            }
            else if (word.EndsWith("o") == true
                || word.EndsWith("s") == true
                || word.EndsWith("x") == true
                || word.EndsWith("z") == true)
            {
                word = word + "es";
            }
            else if (word.EndsWith("ch") == true || word.EndsWith("sh") == true)
            {
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }

            Console.WriteLine(word);
        }
    }
}
