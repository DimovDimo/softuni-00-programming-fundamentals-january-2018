using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
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
                    case "Delete":
                        var target = int.Parse(command[1]);
                        numbers = RemoveAllTargetElementsFromList(numbers, target);
                        break;
                    case "Insert":
                        var element = int.Parse(command[1]);
                        var index = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;
                    case "Odd":
                        foreach (var item in numbers)
                        {
                            if (item % 2 != 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        return;
                    case "Even":
                        foreach (var item in numbers)
                        {
                            if (item % 2 == 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        return;
                    default:
                        break;
                }
            }
        }

        static List<int> RemoveAllTargetElementsFromList(List<int> list, int target)
        {
            var result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != target)
                {
                    result.Add(list[i]);
                }
            }

            return result;
        }
    }
}
