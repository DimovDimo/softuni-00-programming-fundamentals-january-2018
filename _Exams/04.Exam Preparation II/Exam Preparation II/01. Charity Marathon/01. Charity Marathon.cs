using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = decimal.Parse(Console.ReadLine());
            var runners = decimal.Parse(Console.ReadLine());
            var lapsPerRunner = decimal.Parse(Console.ReadLine());
            var lenghtOfTheTrack = decimal.Parse(Console.ReadLine());
            var capacityOfTheTrack = decimal.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());
            var maxRunners = capacityOfTheTrack * days;
            if (maxRunners < runners)
            {
                runners = maxRunners;
            }

            var totalMeters = runners * lapsPerRunner * lenghtOfTheTrack;
            var totalKm = totalMeters / 1000;
            var moneyRaised = totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
