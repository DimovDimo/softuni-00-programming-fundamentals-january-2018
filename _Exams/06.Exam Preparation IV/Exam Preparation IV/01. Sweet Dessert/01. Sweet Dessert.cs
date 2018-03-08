using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = decimal.Parse(Console.ReadLine());
            var priceBananas = decimal.Parse(Console.ReadLine());
            var priceEggs = decimal.Parse(Console.ReadLine());
            var priceBerries = decimal.Parse(Console.ReadLine());
            var sets = Math.Ceiling(guests/6);
            var price = sets * ((2*priceBananas)+(4*priceEggs)+(0.2M*priceBerries));
            if (price <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {price:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(price - cash):F2}lv more.");
            }
        }
    }
}
