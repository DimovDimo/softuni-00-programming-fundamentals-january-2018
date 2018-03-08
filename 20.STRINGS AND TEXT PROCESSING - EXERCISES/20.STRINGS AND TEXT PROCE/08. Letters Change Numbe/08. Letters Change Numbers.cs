using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbe
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var sum = 0.0;
            foreach (var letters in input)
            {
                try
                {
                    var firstLetter = Regex.Split(letters, @"\d+\w")[0];
                    var lastLetter = Regex.Split(letters, @"\w\d+")[1];
                    var number = double.Parse(Regex.Split(letters, @"\D")[1]);
                    var currentResult = 0.0;
                    if (firstLetter == firstLetter.ToUpper())
                    {
                        int position = firstLetter[0] - 64;
                        currentResult = number / position;
                    }
                    else
                    {
                        int position = firstLetter[0] - 96;
                        currentResult = number * position;
                    }

                    if (lastLetter == lastLetter.ToUpper())
                    {
                        int position = lastLetter[0] - 64;
                        currentResult = currentResult - position;
                    }
                    else
                    {
                        int position = lastLetter[0] - 96;
                        currentResult = currentResult + position;
                    }

                    sum += currentResult;
                }
                catch (Exception)
                {
                    Console.WriteLine();
                }
                //var firstLetter = Regex.Split(letters, @"\d+\w")[0];
                //var lastLetter = Regex.Split(letters, @"\w\d+")[1];
                //var number = double.Parse(Regex.Split(letters, @"\D")[1]);
                //var currentResult = 0.0;
                //if (firstLetter == firstLetter.ToUpper())
                //{
                //    int position = firstLetter[0] - 64;
                //    currentResult = number / position;
                //}
                //else
                //{
                //    int position = firstLetter[0] - 96;
                //    currentResult = number * position;
                //}
                //
                //if (lastLetter == lastLetter.ToUpper())
                //{
                //    int position = lastLetter[0] - 64;
                //    currentResult = currentResult - position;
                //}
                //else
                //{
                //    int position = lastLetter[0] - 96;
                //    currentResult = currentResult + position;
                //}
                //
                //sum += currentResult;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
