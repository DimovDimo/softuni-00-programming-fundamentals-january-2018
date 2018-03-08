using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var mounth = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());
            var studio = 0.0;
            var doubleRoom = 0.0;
            var suite = 0.0;

            if (mounth == "May" || mounth == "October")
            {
                studio = 50;
                doubleRoom = 65;
                suite = 75;
                if (nightsCount > 7)
                {
                    studio *= 0.95;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                studio = 60;
                doubleRoom = 72;
                suite = 82;
                if (nightsCount > 14)
                {
                    doubleRoom *= 0.90;
                }
            }
            else if (mounth == "July" || mounth == "August" || mounth == "December")
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;
                if (nightsCount > 14)
                {
                    suite *= 0.85;
                }
            }

            var studioPrice = studio * nightsCount;
            doubleRoom *= nightsCount;
            suite *= nightsCount;

            if ((mounth == "October" || mounth == "September") && nightsCount > 7)
            {
                studioPrice -= studio;
            }

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doubleRoom:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");
        }
    }
}
