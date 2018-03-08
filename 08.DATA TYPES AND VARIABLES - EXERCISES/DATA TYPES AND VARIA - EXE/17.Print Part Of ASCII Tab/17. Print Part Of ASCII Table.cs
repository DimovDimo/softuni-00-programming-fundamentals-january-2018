using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Tab
{
    class Program
    {
        static void Main(string[] args)
        {
            var startWith = int.Parse(Console.ReadLine());
            var lastCharacter = int.Parse(Console.ReadLine());
            for (int i = startWith; i <= lastCharacter; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
