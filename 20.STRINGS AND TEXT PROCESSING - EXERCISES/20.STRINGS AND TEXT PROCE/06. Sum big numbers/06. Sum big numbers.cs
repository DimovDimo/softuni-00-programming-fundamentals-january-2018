using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();
            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            int sum = 0;
            int reminder = 0;
            var resultStringBuilder = new StringBuilder();
            for (int i = num2.Length-1; i >= 0; i--)
            {
                var firstNum = int.Parse(num1[i].ToString());
                var secondNum = int.Parse(num2[i].ToString());
                sum = firstNum + secondNum + reminder;
                resultStringBuilder.Append(sum % 10);
                if (sum > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
            }

            if (reminder == 1)
            {
                sum = reminder;
                resultStringBuilder.Append(sum);
            }

            Console.WriteLine(resultStringBuilder
                .ToString()
                .TrimEnd('0')
                .ToCharArray()
                .Reverse()
                .ToArray());
        }
    }
}
