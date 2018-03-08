using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Magic_Let
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char invalidChar = char.Parse(Console.ReadLine());

            for (int i = firstChar; i <= secondChar; i++)
            {
                for (int j = firstChar; j <= secondChar; j++)
                {
                    for (int p = firstChar; p <= secondChar; p++)
                    {
                        if ((char)i != (char)invalidChar && (char)j != (char)invalidChar && (char)p != (char)invalidChar)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)p} ");
                        }
                    }
                }
            }
        }
    }
}
