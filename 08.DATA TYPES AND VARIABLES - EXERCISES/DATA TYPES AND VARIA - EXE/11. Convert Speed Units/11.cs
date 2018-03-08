using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            int totalSeconds = seconds + minutes * 60 + hours * 60 * 60;

            var speed = (float)distanceInMeters / totalSeconds;
            Console.WriteLine($"{speed:F6}");
            var speedKilometersPerHour = speed * 3.6;
            Console.WriteLine($"{speedKilometersPerHour:F6}");

            var totalHours = seconds / 3600.0f + minutes / 60.0f + hours;
            var speedMilesPerHour = (distanceInMeters / 1609.0f) / totalHours;
            Console.WriteLine($"{speedMilesPerHour:F6}");

            
        }
    }
}
