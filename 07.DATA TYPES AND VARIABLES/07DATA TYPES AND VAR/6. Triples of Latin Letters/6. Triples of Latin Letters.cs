using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var latinLetter = 'a' + int.Parse(Console.ReadLine());
            for (int i = 'a'; i < latinLetter; i++)
            {
                for (int j = 'a'; j < latinLetter; j++)
                {
                    for (int k = 'a'; k < latinLetter; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
