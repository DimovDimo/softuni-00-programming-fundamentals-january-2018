using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Snowwhite
{
    class Snowwhite
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var snowwhites = new List<Snowwhite>();
            var input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                var splited = input
                    .Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var dwarfName = splited[0];
                var dwarfHatColor = splited[1];
                var dwarfPhysics = int.Parse(splited[2]);


                if (snowwhites.Any(x => x.Name == dwarfName))
                {

                    if (snowwhites.Any(x => x.Color == dwarfHatColor))
                    {
                        try
                        {
                            var snowwhitePh = snowwhites.First(x => x.Name == dwarfName && x.Color == dwarfHatColor);
                            if (snowwhitePh.Physics < dwarfPhysics)
                            {
                                snowwhitePh.Physics = dwarfPhysics;
                            }
                        }
                        catch (Exception)
                        {

                        }

                    }
                    else
                    {
                        var currentSnowwhite = new Snowwhite();
                        currentSnowwhite.Name = dwarfName;
                        currentSnowwhite.Color = dwarfHatColor;
                        currentSnowwhite.Physics = dwarfPhysics;
                        snowwhites.Add(currentSnowwhite);
                    }


                }
                else
                {
                    var currentSnowwhite = new Snowwhite();
                    currentSnowwhite.Name = dwarfName;
                    currentSnowwhite.Color = dwarfHatColor;
                    currentSnowwhite.Physics = dwarfPhysics;
                    snowwhites.Add(currentSnowwhite);
                }

                input = Console.ReadLine();
            }

            try
            {
                var orderByPhysics = snowwhites.OrderByDescending(x => x.Physics)
                    .ThenByDescending(x => x.Color.Count())
                    .ThenByDescending(x => x.Color);
                var totalColorCount = new Dictionary<string, int>();
                foreach (var item in orderByPhysics)
                {
                    if (totalColorCount.ContainsKey(item.Color) == false)
                    {
                        var count = orderByPhysics.Where(x => x.Color == item.Color).Count();
                        totalColorCount.Add(item.Color, count);
                    }
                }



                foreach (var dwarf in orderByPhysics)
                //.ThenByDescending(x => x.Color))
                {
                    Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
