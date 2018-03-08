using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int numberMost = 0;
            int countNumberMost = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                int crentCountOfNumber = 0;
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[i] == firstArr[j])
                    {
                        crentCountOfNumber++;
                    }
                }

                if (countNumberMost < crentCountOfNumber)
                {
                    numberMost = firstArr[i];
                    countNumberMost = crentCountOfNumber;
                }
            }

            Console.WriteLine(numberMost);
        }
    }
}
