using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var salesArr = new Sale[rows];
            for (int i = 0; i < rows; i++)
            {
                salesArr[i] = Sale.ReadSale(Console.ReadLine());
            }

            Sale.PrintSalesReportByTown(salesArr);
        }
    }
}
