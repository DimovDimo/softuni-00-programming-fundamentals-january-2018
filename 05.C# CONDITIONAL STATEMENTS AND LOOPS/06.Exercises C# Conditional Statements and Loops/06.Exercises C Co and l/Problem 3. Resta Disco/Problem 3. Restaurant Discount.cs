using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Resta_Disco
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var price = 0.0;
            var packagePrice = 0.0;
            var totalPrice = 0.0;
            var discount = 0.0;
            var pricePerPerson = 0.0;
            var hall = "";
            
            if (package == "Normal")
            {
                discount = 0.95;
                packagePrice = 500;
            }
            else if (package == "Gold")
            {
                discount = 0.90;
                packagePrice = 750;
            }
            else if (package == "Platinum")
            {
                discount = 0.85;
                packagePrice = 1000;
            }

            if (groupSize <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                price = 5000;
                hall = "Terrace";
            }
            else if (groupSize <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                totalPrice = price + packagePrice;
                discount = totalPrice * discount;
                pricePerPerson = discount / groupSize;

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
