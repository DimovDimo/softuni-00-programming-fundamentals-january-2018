using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anony_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var seckey = int.Parse(Console.ReadLine());
            var sites = new List<string>();
            decimal totalLost = 0.0M;
            for (int i = 0; i < n; i++)
            {
                var splited = Console.ReadLine()
                    .Split()
                    .ToList();
                var siteName = splited[0];
                var siteVisits = decimal.Parse(splited[1]);
                var siteCommercialPricePerVisit = decimal.Parse(splited[2]);
                sites.Add(siteName);
                totalLost += siteVisits * siteCommercialPricePerVisit;
            }
            
            BigInteger secToken = BigInteger.Pow(seckey, n);
            foreach (var site in sites)
            {
                Console.WriteLine(site);
            }

            Console.WriteLine($"Total Loss: {totalLost:F20}");
            Console.WriteLine($"Security Token: {secToken}");
        }
    }
}
