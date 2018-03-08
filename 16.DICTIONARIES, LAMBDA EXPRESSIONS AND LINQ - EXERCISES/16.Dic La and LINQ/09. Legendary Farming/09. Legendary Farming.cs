using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToArray();
            var shadowmourneObtained = false;
            var valanyrObtained = false;
            var dragonwrathObtained = false;
            string resorce;
            long quantity = 0;

            var resorcesPrimary = new Dictionary<string, long>();
            resorcesPrimary.Add("fragments", 0);
            resorcesPrimary.Add("shards", 0);
            resorcesPrimary.Add("motes", 0);
            var junk = new Dictionary<string, long>();

            while (shadowmourneObtained == false
                && valanyrObtained == false
                && dragonwrathObtained == false)
            {
                for (int i = 0; i < input.Length; i+=2)
                {
                    resorce = input[i + 1];
                    quantity = int.Parse(input[i]);
                    if (resorcesPrimary.ContainsKey(resorce))
                    {
                        resorcesPrimary[resorce] += quantity;
                    }
                    else if (junk.ContainsKey(resorce) == false)
                    {
                        junk.Add(resorce, quantity);
                    }
                    else
                    {
                        junk[resorce] += quantity;
                    }

                    if (resorcesPrimary["fragments"] >= 250)
                    {
                        valanyrObtained = true;
                        Console.WriteLine("Valanyr obtained!");
                        resorcesPrimary["fragments"] -= 250;
                        break;
                    }
                    else if (resorcesPrimary["shards"] >= 250)
                    {
                        shadowmourneObtained = true;
                        Console.WriteLine("Shadowmourne obtained!");
                        resorcesPrimary["shards"] -= 250;
                        break;
                    }
                    else if (resorcesPrimary["motes"] >= 250)
                    {
                        dragonwrathObtained = true;
                        Console.WriteLine("Dragonwrath obtained!");
                        resorcesPrimary["motes"] -= 250;
                        break;
                    }
                }
                if (shadowmourneObtained == false
                && valanyrObtained == false
                && dragonwrathObtained == false)
                {
                    input = Console.ReadLine().ToLower().Split(' ').ToArray();
                }
            }

            foreach (var resorcePair in resorcesPrimary.OrderByDescending(r => r.Value).ThenBy(r => r.Key))
            {
                Console.WriteLine($"{resorcePair.Key}: {resorcePair.Value}");
            }

            foreach (var resorcePair in junk.OrderBy(r => r.Key))
            {
                Console.WriteLine($"{resorcePair.Key}: {resorcePair.Value}");
            }
        }
    }
}
