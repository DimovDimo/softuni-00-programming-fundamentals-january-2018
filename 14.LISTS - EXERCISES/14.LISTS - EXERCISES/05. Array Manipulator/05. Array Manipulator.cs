using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse) // long or double
                .ToList();
            while (true)
            {
                var command = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                switch (command[0]) // ToLower()
                {
                    case "add":
                        var index = int.Parse(command[1]);
                        var element = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        var indexForAddMany = int.Parse(command[1]);
                        var elementsForAddMany = GetElementsForAddMany(command);
                        numbers.InsertRange(indexForAddMany, elementsForAddMany);
                        break;
                    case "contains":
                        var elementContains = int.Parse(command[1]);
                        PrintIndexOfElementContains(numbers, elementContains);
                        break;
                    case "remove":
                        var indexForRemove = int.Parse(command[1]);
                        numbers.RemoveAt(indexForRemove);
                        break;
                    case "shift":
                        var position = int.Parse(command[1]);
                        numbers = ShiftWithPositionToLeft(numbers, position);
                        break;
                    case "sumPairs":
                        numbers = SumPairs(numbers);
                        break;
                    case "print":
                        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                        Console.WriteLine();
                        return; // RETURN
                    default:
                        break;
                }
            }
        }

        static void PrintIndexOfElementContains(List<int> numbers, int elementContains)
        {
            var isontains = numbers.IndexOf(elementContains);
            Console.WriteLine(isontains);
        }

        //static List<int> ShiftToLeft(List<int> numbers, int position)
        //{
        //    var shifted = new List<int>();
        //    var firstElement = numbers[0];
        //    for (int i = 1; i < numbers.Count; i++)
        //    {
        //        shifted.Add(numbers[i]);
        //    }
        //
        //    shifted.Add(firstElement);
        //    return shifted;
        //}

        static List<int> ShiftWithPositionToLeft(List<int> numbers, int position)
        {
            //for (int i = 0; i < position; i++)
            //{
            //    numbers = ShiftToLeft(numbers, position);
            //}
            position = position % numbers.Count;
            var result = numbers.GetRange(position, numbers.Count - position);
            result.AddRange(numbers.GetRange(0, position));
            return result;

            //return numbers;
        }

        static List<int> SumPairs(List<int> numbers)
        {
            var sumPairs = new List<int>();
            var counter = 0;
            for (int i = 0; i < numbers.Count; i += 2)
            {
                counter++;
                if (counter <= numbers.Count / 2)
                {
                    sumPairs.Add(numbers[i] + numbers[i + 1]);
                }
                else
                {
                    sumPairs.Add(numbers[i]);
                }
                //sumPairs.Add(numbers[i] + numbers[i - 1]);
            }

            //if (numbers.Count % 2 != 0)
            //{
            //    sumPairs.Add(numbers.Count - 1);
            //}

            return sumPairs;
        }

        static List<int> GetElementsForAddMany(List<string> command)
        {
            var elements = new List<int>();
            for (int i = 2; i < command.Count; i++)
            {
                elements.Add(int.Parse(command[i]));
            }

            return elements;
        }
    }
}
