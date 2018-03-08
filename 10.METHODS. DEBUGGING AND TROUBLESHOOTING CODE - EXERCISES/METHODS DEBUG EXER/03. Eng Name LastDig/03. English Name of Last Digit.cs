using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eng_Name_LastDig
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(GetNameOfLastDigit(number%10).ToLower());
        }

        static string GetNameOfLastDigit(long digit)
        {
            switch (digit)
            {
                case 0:
                    return "Zero";
                    break;
                case 1:
                    return "One";
                    break;
                case 2:
                    return "Two";
                    break;
                case 3:
                    return "Three";
                    break;
                case 4:
                    return "Four";
                    break;
                case 5:
                    return "Five";
                    break;
                case 6:
                    return "Six";
                    break;
                case 7:
                    return "Seven";
                    break;
                case 8:
                    return "Eight";
                    break;
                case 9:
                    return "Nine";
                    break;
                default:
                    return "";
                    break;
            }
        }
    }
}
