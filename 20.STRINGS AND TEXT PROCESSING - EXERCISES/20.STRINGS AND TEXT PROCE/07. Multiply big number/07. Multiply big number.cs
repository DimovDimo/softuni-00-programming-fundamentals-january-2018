using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }
            //if (num1.Length > num2.Length)
            //{
            //    num2 = num2.PadLeft(num1.Length, '0');
            //}
            //else
            //{
            //    num1 = num1.PadLeft(num2.Length, '0');
            //}

            int multiply = 0;
            int reminder = 0;
            var resultStringBuilder = new StringBuilder();
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                var firstNum = int.Parse(num1[i].ToString());
                var secondNum = num2;
                multiply = firstNum * secondNum + reminder;
                resultStringBuilder.Append(multiply % 10);
                if (multiply > 9)
                {
                    reminder = multiply / 10;
                }
                else
                {
                    reminder = 0;
                }
            }

            if (reminder > 0)
            {
                resultStringBuilder.Append(reminder);
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
