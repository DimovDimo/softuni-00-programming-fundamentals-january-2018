using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var miner = new Dictionary<string, int>();
            while (true)
            {
                //{resource} –> {quantity}
                var resource = Console.ReadLine();
                if (resource == "stop")
                {
                    foreach (var pair in miner)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }

                    return;
                }

                var quantity = int.Parse(Console.ReadLine());
                if (!miner.ContainsKey(resource))
                {
                    miner[resource] = quantity;
                }
                else
                {
                    miner[resource] += quantity;
                }
            }
        }
    }
}
