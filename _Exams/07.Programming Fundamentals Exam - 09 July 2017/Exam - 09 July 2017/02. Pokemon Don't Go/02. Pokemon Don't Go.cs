using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var removed = new List<int>();
            while (nums.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                var currentRemoved = -7777;
                if (index < 0)
                {
                    removed.Add(nums[0]);
                    currentRemoved = nums[0];
                    nums[0] = nums[nums.Count - 1];
                }
                else if (index > nums.Count - 1)
                {
                    removed.Add(nums[nums.Count - 1]);
                    currentRemoved = nums[nums.Count - 1];
                    nums.RemoveAt(nums.Count - 1);
                    if (nums.Count > 0)
                    {
                        nums.Add(nums[0]);
                    }
                }
                else
                {
                    removed.Add(nums[index]);
                    currentRemoved = nums[index];
                    nums.RemoveAt(index);
                }

                for (int i = 0; i < nums.Count; i++)
                {
                    if (currentRemoved >= nums[i])
                    {
                        nums[i] += currentRemoved;
                    }
                    else
                    {
                        nums[i] -= currentRemoved;
                    }
                }
            }

            Console.WriteLine(removed.Sum());
        }
    }
}
