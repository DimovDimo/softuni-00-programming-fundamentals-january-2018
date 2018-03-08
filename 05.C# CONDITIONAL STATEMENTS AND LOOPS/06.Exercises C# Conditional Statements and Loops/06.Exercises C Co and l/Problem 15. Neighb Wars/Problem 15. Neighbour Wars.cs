using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Neighb_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoSDamage = int.Parse(Console.ReadLine());
            var goshoSDamage = int.Parse(Console.ReadLine());
            var peshoHealth = 100;
            var goshoHealth = 100;
            var round = 1;

            do
            {
                if (round % 2 == 1)
                {
                    round++;
                    goshoHealth -= peshoSDamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {--round}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    round++;
                    peshoHealth -= goshoSDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {--round}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                if ((round-1) % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            } while (true);
        }
    }
}
