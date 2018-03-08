using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b([A-Za-z][[a-zA-Z0-9_]{2,24})\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count < 2)
            {
                return;
            }

            var userNames = new List<string>();
            foreach (Match match in matches)
            {
                userNames.Add(match.Groups[1].Value);
            }

            var maxSumOfLenght = int.MinValue;
            var firstUser = "";
            var secondUser = "";
            for (int i = 1; i < userNames.Count; i++)
            {
                var currentSum = userNames[i - 1].Length + userNames[i].Length;
                if (currentSum > maxSumOfLenght)
                {
                    maxSumOfLenght = currentSum;
                    firstUser = userNames[i - 1];
                    secondUser = userNames[i];
                }
            }

            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}
