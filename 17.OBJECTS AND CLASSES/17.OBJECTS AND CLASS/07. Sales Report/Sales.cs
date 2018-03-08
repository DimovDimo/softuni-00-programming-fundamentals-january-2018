using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        static public Sale ReadSale(string input)
        {
            var separated = input
                .Split(' ')
                .ToArray();
            
            return new Sale
            {
                Town = separated[0],
                Product = separated[1],
                Price = decimal.Parse(separated[2]),
                Quantity = decimal.Parse(separated[3])
            };
        }

        static public void PrintSalesReportByTown(Sale[] sales)
        {
            var reportSales = new SortedDictionary<string, decimal>();
            for (int i = 0; i < sales.Length; i++)
            {
                var currentTown = sales[i].Town;
                if (reportSales.ContainsKey(currentTown) == false)
                {
                    reportSales.Add(currentTown, 0.0m);
                }

                reportSales[currentTown] += sales[i].Price * sales[i].Quantity;
            }

            foreach (var report in reportSales)
            {
                Console.WriteLine($"{report.Key} -> {report.Value:F2}");
            }
        }
    }
}
