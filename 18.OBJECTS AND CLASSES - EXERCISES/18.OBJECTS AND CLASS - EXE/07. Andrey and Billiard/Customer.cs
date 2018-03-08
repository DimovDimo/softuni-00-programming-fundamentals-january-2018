using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, decimal> Products { get; set; }
        public Dictionary<string, decimal> Menu { get; set; }
        public decimal Bill
        {
            get
            {
                var bill = 0.0m;
                foreach (var product in Products)
                {
                    bill += Menu[product.Key] * product.Value;
                }

                return bill;
            }
        }
    }
}
