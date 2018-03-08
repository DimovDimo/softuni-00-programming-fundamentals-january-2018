using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (nums.Count > 1)
            {
                bool[] isWin = new bool[nums.Count];
                for (int j = 0; j < isWin.Length; j++)
                {
                    isWin[j] = true;
                }

                for (int i = 0; i < nums.Count; i++)
                {
                    if (isWin[i])
                    {
                        var newNumsTemporal = new List<int>();
                        for (int k = 0; k < nums.Count; k++)
                        {
                            if (isWin[k])
                            {
                                newNumsTemporal.Add(nums[k]);
                            }
                        }

                        if (newNumsTemporal.Count == 1)
                        {
                            return;
                        }

                        var attaker = i;
                        var target = nums[i];
                        if (nums.Count <= target)
                        {
                            target %= nums.Count;
                        }

                        var battle = Math.Abs(attaker - target);
                        if (battle == 0)
                        {
                            Console.WriteLine($"{attaker} performed harakiri");
                            isWin[attaker] = false;
                        }
                        else if (battle % 2 == 0)
                        {
                            Console.WriteLine($"{attaker} x {target} -> {attaker} wins");
                            isWin[target] = false;
                        }
                        else if (battle % 2 != 0)
                        {
                            Console.WriteLine($"{attaker} x {target} -> {target} wins");
                            isWin[attaker] = false;
                        }
                    }
                }

                var newNums = new List<int>();
                for (int i = 0; i < nums.Count; i++)
                {
                    if (isWin[i])
                    {
                        newNums.Add(nums[i]);
                    }
                }

                nums = newNums;
            }
        }
    }
}
