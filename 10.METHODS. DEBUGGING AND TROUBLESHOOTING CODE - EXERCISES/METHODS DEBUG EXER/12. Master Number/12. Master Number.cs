using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Math.Abs(int.Parse(Console.ReadLine()));
            for (int i = 0; i <= range; i++)
            {
                PrintIfIsItMasterNumber(i);
            }
        }

        static void PrintIfIsItMasterNumber(int number)
        {
            bool isPalindrome = IsPalindrome(number);
            bool sumOfDigitsDivisibleBy7 = SumOfDigitsDivisibleBy7(number);
            bool containsEvenDigit = ContainsEvenDigit(number);
            if (isPalindrome
                && sumOfDigitsDivisibleBy7
                && containsEvenDigit)
            {
                Console.WriteLine(number);
            }
        }

        static bool IsPalindrome(int num)
        {
            var numString = num.ToString();
            for (int i = 0; i < numString.Length / 2; i++)
            {
                if (numString[i] != numString[numString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool SumOfDigitsDivisibleBy7(int num)
        {
            if (GetSumOfDigits(num) % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int GetSumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }
            return sum;
        }

        static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
