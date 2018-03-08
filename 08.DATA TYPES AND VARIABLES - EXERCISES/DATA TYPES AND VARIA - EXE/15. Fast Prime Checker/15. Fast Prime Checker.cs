using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int reange = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= reange; currentNumber++)
            {
                bool isItAPrimeNumbe = true;
                for (int currentDivisibleNum = 2; currentDivisibleNum <= Math.Sqrt(currentNumber); currentDivisibleNum++)
                {
                    if (currentNumber % currentDivisibleNum == 0)
                    {
                        isItAPrimeNumbe = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isItAPrimeNumbe}");
            }
        }
    }
}
