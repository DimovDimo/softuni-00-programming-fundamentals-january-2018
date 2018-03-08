using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
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
            if (input[0].Length >= input[1].Length)
            {
                minLenght = input[1];
                maxLenght = input[0];
            }
            else
            {
                minLenght = input[0];
                maxLenght = input[1];
            }

            var sum = 0;
            for (int i = 0; i < maxLenght.Length; i++)
            {
                if (i > minLenght.Length - 1)
                {
                    sum += (int)maxLenght[i];
                }
                else
                {
                    sum += (int)maxLenght[i] * (int)minLenght[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
