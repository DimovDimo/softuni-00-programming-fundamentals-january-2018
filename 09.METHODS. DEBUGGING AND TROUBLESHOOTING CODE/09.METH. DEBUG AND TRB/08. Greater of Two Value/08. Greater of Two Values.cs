using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Value
{
    class Program
    {
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            if ((int)first > (int)second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else if (first.CompareTo(second) < 0)
            {
                return second;
            }
            return "";
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(width, height));
            }
            else if (type == "char")
            {
                char width = char.Parse(Console.ReadLine());
                char height = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(width, height));
            }
            else if(type == "string")
            {
                string width = Console.ReadLine();
                string height = Console.ReadLine();
                Console.WriteLine(GetMax(width, height));
            }
        }
    }
}
