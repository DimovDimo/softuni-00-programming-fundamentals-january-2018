﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calo_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var totalCaloriesAmount = 0;

            for (int i = 0; i < rows; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese": totalCaloriesAmount += 500; break;
                    case "tomato sauce": totalCaloriesAmount += 150; break;
                    case "salami": totalCaloriesAmount += 600; break;
                    case "pepper": totalCaloriesAmount += 50; break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
