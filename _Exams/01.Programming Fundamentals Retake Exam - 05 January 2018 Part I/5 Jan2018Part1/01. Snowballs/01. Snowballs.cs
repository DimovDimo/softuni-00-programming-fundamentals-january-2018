using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _01.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger snowballValueMax = -1;
            var snowballSnowMax = 0.0;
            var snowballTimeMax = 0.0;
            var snowballQualityMax = 0.0;
            for (int i = 0; i < n; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());
                var snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValueMax < snowballValue)
                {
                    snowballValueMax = snowballValue;
                    snowballSnowMax = snowballSnow;
                    snowballTimeMax = snowballTime;
                    snowballQualityMax = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowMax:F0} : {snowballTimeMax:F0} = {snowballValueMax} ({snowballQualityMax:F0})");
        }
    }
}
