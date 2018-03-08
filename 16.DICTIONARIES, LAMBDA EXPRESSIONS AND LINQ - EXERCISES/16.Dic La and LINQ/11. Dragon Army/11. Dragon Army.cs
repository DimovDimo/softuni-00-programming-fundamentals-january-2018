using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, Dictionary<string, List<double>>>();
            var countOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfDragons; i++)
            {
                var separated = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var type = separated[0];
                var name = separated[1];
                var damage = 45.0;
                var health = 250.0;
                var armor = 10.0;
                if (separated[2] != "null")
                {
                    damage = double.Parse(separated[2]);
                }

                if (separated[3] != "null")
                {
                    health = double.Parse(separated[3]);
                }

                if (separated[4] != "null")
                {
                    armor = double.Parse(separated[4]);
                }

                if (dragons.ContainsKey(type) == false)
                {
                    var empty = new Dictionary<string, List<double>>();
                    dragons.Add(type, empty);
                }

                if (dragons[type].ContainsKey(name) == false)
                {
                    var empty = new List<double>();
                    dragons[type].Add(name, empty);
                }

                var damageHealthArmor = new List<double>();
                damageHealthArmor.Add(damage);
                damageHealthArmor.Add(health);
                damageHealthArmor.Add(armor);
                dragons[type][name] = damageHealthArmor;
            }

            foreach (var dragon in dragons)
            {
                var aveDanagane = dragon.Value.Values.Select(x => x[0]).Average();
                var aveHealth = dragon.Value.Values.Select(x => x[1]).Average();
                var aveArmor = dragon.Value.Values.Select(x => x[2]).Average();
                Console.WriteLine($"{dragon.Key}::({aveDanagane:F2}/{aveHealth:F2}/{aveArmor:F2})");
                foreach (var name in dragon.Value.OrderBy(x => x.Key))
                {
                    var damage = name.Value[0];
                    var health = name.Value[1];
                    var armor = name.Value[2];
                    Console.WriteLine($"-{name.Key} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
