using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingsFlaps = int.Parse(Console.ReadLine());
            var distanceFor1000WingsFlaps = decimal.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());
            var totalDistance = (wingsFlaps / 1000) * distanceFor1000WingsFlaps;
            var flapsTime = wingsFlaps / 100;
            var restTime = (wingsFlaps / endurance) * 5L;//Long
            var totalTime = flapsTime + restTime;
            Console.WriteLine($"{totalDistance:F2} m.");
            Console.WriteLine($"{totalTime:F0} s.");
        }
    }
}
