using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] 
            {
                "Invalid Day!",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            var day = int.Parse(Console.ReadLine());
            if (1 <= day && day <= 7)
            {
                Console.WriteLine(week[day]);
            }
            else
            {
                Console.WriteLine(week[0]);
            }
        }
    }
}
