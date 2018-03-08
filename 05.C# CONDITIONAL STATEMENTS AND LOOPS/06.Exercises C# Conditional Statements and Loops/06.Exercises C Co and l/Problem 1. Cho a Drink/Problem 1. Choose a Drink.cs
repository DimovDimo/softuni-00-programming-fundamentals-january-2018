using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Cho_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1. Choose a Drink
            var profesion = Console.ReadLine().ToLower();

            switch (profesion)
            {
                case "athlete": Console.WriteLine("Water"); break;
                case "businessman": 
                case "businesswoman": Console.WriteLine("Coffee"); break;
                case "softuni student": Console.WriteLine("Beer"); break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
