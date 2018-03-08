using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var zones = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var checkpoints = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            foreach (var driver in drivers)
            {
                var driverValue = (double)driver[0];
                var reachedIndex = -1;
                for (int i = 0; i < zones.Count; i++)
                {
                    if (checkpoints.Any(x => x == i))
                    {
                        driverValue += zones[i];
                    }
                    else
                    {
                        driverValue -= zones[i];
                    }

                    if (driverValue <= 0)// == 0
                    {
                        //Console.WriteLine($"{driver} - reached {i}");
                        reachedIndex = i;
                        break;
                    }
                }

                if (driverValue <= 0)// == 0
                {
                    Console.WriteLine($"{driver} - reached {reachedIndex}");
                }
                else
                {
                    Console.WriteLine($"{driver} - fuel left {driverValue:F2}");
                }
            }
        }
    }
}
