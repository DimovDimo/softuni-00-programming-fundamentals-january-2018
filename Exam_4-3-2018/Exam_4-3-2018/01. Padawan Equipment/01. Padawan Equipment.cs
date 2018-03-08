using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfMoney = decimal.Parse(Console.ReadLine());
            var countOfStudents = decimal.Parse(Console.ReadLine());
            var priceOfLightsabers = decimal.Parse(Console.ReadLine());
            var priceOfRobes = decimal.Parse(Console.ReadLine());
            var priceOfBelts = decimal.Parse(Console.ReadLine());
            var freeBelts = (int)countOfStudents / 6;
            var price = priceOfLightsabers * (Math.Ceiling(countOfStudents + (countOfStudents * 0.1M))) + priceOfRobes * countOfStudents + priceOfBelts * (countOfStudents - freeBelts);
            if (price <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv.");
            }
            else
            {
                var neetMoney = price - amountOfMoney;
                Console.WriteLine($"Ivan Cho will need {neetMoney:F2}lv more.");
            }
        }
    }
}
