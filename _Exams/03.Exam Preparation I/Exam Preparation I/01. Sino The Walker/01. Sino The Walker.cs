using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan start = TimeSpan.Parse(Console.ReadLine());
            var steps = BigInteger.Parse(Console.ReadLine());// or long
            var secondsForStep = BigInteger.Parse(Console.ReadLine());// or long
            var totalSeconds = (long)start.TotalSeconds + steps * secondsForStep;
            //TimeSpan interval = TimeSpan.FromSeconds(totalSeconds);
            //var span = start.Add(interval);
            ////Console.WriteLine($"Time Arrival: {span.ToString()}");
            //Console.WriteLine($"Time Arrival: {span.Hours.ToString("D2")}:{span.Minutes.ToString("D2")}:{span.Seconds.ToString("D2")}");
            var seconds = totalSeconds % 60;
            var minutes = ((totalSeconds - seconds) / 60) % 60;
            var hours = ((totalSeconds - seconds - minutes) / 3600) % 24;
            Console.WriteLine($"Time Arrival: {hours.ToString("D2")}:{minutes.ToString("D2")}:{seconds.ToString("D2")}");
        }
    }
}
