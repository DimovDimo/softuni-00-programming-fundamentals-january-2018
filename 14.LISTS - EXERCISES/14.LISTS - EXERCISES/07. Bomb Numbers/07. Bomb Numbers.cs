using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse) // long or double
                .ToList();
            var bombAndPower = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse) // long or double
                .ToList();

            bool isBomb = IsBomb(numbers, bombAndPower);
            while (isBomb)
            {
                numbers = OneDetonate(numbers, bombAndPower);
                isBomb = IsBomb(numbers, bombAndPower);
            }

            var sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }

        static List<int> OneDetonate(List<int> numbers, List<int> bombAndPower)
        {
            var startRange = -1;
            var endRange = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombAndPower[0])
                {
                    startRange = i - bombAndPower[1];
                    endRange = i + bombAndPower[1];
                    break;
                }
            }

            var remainingElements = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < startRange || endRange < i)
                {
                    remainingElements.Add(numbers[i]);
                }
            }

            return remainingElements;
        }

        static bool IsBomb(List<int> numbers, List<int> bombAndPower)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombAndPower[0])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
