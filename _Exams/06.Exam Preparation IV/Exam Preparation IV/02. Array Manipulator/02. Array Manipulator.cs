using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)//or other
                .ToList();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var splited = line
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var command = splited[0];
                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(splited[1]);//long
                        if (index < 0 || index >= nums.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            var currentNums = new List<double>();
                            currentNums.AddRange(nums.Skip(index + 1));
                            currentNums.AddRange(nums.Take(index + 1));
                            nums = currentNums;
                        }

                        break;
                    case "max":// 0 is even or odd
                        var typeMax = splited[1];
                        var currentMax = "";
                        var maxIndex = -1;
                        if (typeMax == "even")
                        {
                            var currentMaxValue = nums[0];
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] >= currentMaxValue && nums[i] % 2 == 0)
                                {
                                    currentMaxValue = nums[i];
                                    maxIndex = i;
                                }
                            }
                        }
                        else if (typeMax == "odd")
                        {
                            var currentMaxValue = nums[0];
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] >= currentMaxValue && nums[i] % 2 != 0)
                                {
                                    currentMaxValue = nums[i];
                                    maxIndex = i;
                                }
                            }
                        }

                        if (maxIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(maxIndex);
                        }
                        
                        break;
                    case "min":
                        var typeMin = splited[1];
                        var currentMin = "";
                        var minIndex = -1;
                        if (typeMin == "even")
                        {
                            var currentMinValue = nums[0];
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] <= currentMinValue && nums[i] % 2 == 0)
                                {
                                    currentMinValue = nums[i];
                                    minIndex = i;
                                }
                            }
                        }
                        else if (typeMin == "odd")
                        {
                            var currentMinValue = nums[0];
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] <= currentMinValue && nums[i] % 2 != 0)
                                {
                                    currentMinValue = nums[i];
                                    minIndex = i;
                                }
                            }
                        }

                        if (minIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(minIndex);
                        }

                        break;
                    case "first":
                        var countFirst = int.Parse(splited[1]);//long
                                                //= only or > or >=
                        if (countFirst <= 0 || countFirst > nums.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            var currentNumsFirst = new List<double>();
                            var typeFirst = splited[2];
                            if (typeFirst == "even")//index 0
                            {// 0??
                                currentNumsFirst = nums.Where(x => x % 2 == 0).Take(countFirst).ToList();
                            }
                            else if (typeFirst == "odd")
                            {
                                currentNumsFirst = nums.Where(x => x % 2 != 0).Take(countFirst).ToList();
                            }

                            Console.WriteLine($"[{string.Join(", ", currentNumsFirst)}]");
                        }

                        break;
                    case "last":
                        var countLast = int.Parse(splited[1]);//long
                                              //= only or > or >=
                        if (countLast <= 0 || countLast > nums.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            var currentNumsLast = new List<double>();
                            var typeLast = splited[2];
                            nums.Reverse();
                            if (typeLast == "even")//index 0
                            {// 0??
                                currentNumsLast = nums.Where(x => x % 2 == 0).Take(countLast).ToList();
                            }
                            else if (typeLast == "odd")
                            {
                                currentNumsLast = nums.Where(x => x % 2 != 0).Take(countLast).ToList();
                            }

                            currentNumsLast.Reverse();
                            Console.WriteLine($"[{string.Join(", ", currentNumsLast)}]");
                            nums.Reverse();
                        }

                        break;
                    default:
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
