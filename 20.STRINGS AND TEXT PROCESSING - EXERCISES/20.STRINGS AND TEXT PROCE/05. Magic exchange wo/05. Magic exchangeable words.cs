using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchange_wo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();
            string minLenght = "";
            string maxLenght = "";
            if (input[0].Length > input[1].Length)
            {
                minLenght = input[1];
                maxLenght = input[0];
            }
            else
            {
                minLenght = input[0];
                maxLenght = input[1];
            }

            //First -----------------------------
            //Console.WriteLine(AreExchangeable(minLenght, maxLenght)
            //    .ToString()
            //    .ToLower());

            int lenght1 = minLenght
                .ToCharArray()
                .Distinct()
                .Count();
            int lenght2 = maxLenght
                .ToCharArray()
                .Distinct()
                .Count();
            bool areExchangeable = lenght1 == lenght2;
            Console.WriteLine(areExchangeable
                .ToString()
                .ToLower());
        }

        private static bool AreExchangeable(string minLenght, string maxLenght)
        {
            var chars = new Dictionary<char, char>();
            for (int i = 0; i < minLenght.Length; i++)
            {
                if (chars.ContainsKey(minLenght[i]) == false)
                {
                    chars.Add(minLenght[i], maxLenght[i]);
                }
                else
                {
                    if (maxLenght[i] != chars[minLenght[i]])
                    {
                        return false;
                    }
                }
            }

            if (minLenght.Length < maxLenght.Length)
            {
                for (int i = minLenght.Length; i < maxLenght.Length; i++)
                {
                    if (chars.ContainsKey(maxLenght[i]) == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
