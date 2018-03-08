using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameProdukt = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());

            var energy = (volume / 100.0) * energyContentPer100ml;
            var sugarContent = (volume / 100.0) * sugarContentPer100ml;

            Console.WriteLine($"{volume}ml {nameProdukt}:");
            Console.WriteLine($"{energy}kcal, {sugarContent}g sugars");
        }
    }
}
