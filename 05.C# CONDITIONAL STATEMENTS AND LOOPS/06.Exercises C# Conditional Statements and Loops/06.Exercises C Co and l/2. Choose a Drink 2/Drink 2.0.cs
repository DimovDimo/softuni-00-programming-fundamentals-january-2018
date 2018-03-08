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
            //Problem 2. Choose a Drink 2.0
            var profession = Console.ReadLine();
            var countDrinks = int.Parse(Console.ReadLine());
            var waterPrice = 0.70;
            var coffePrice = 1.00;
            var beerPrice = 1.70;
            var teaPrice = 1.20;
            var totalPrice = 0.0;

            switch (profession)
            {
                case "Athlete": totalPrice= countDrinks*waterPrice; break;
                case "Businessman":
                case "Businesswoman": totalPrice = countDrinks *coffePrice; break;
                case "SoftUni Student": totalPrice = countDrinks *beerPrice; break;
                default:
                    totalPrice = countDrinks *teaPrice;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
