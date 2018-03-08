using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToList();
            var hornets = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToList();
            var winBeehives = new List<long>();
            var isNewLoop = true;
            var counter = 0;

            beehives.Reverse();
            hornets.Reverse();
            while (isNewLoop)
            {
                try
                {
                    if (hornets.Sum() > beehives[beehives.Count - 1])
                    {
                        beehives.RemoveAt(beehives.Count - 1);
                    }
                    else
                    {
                        var diferents = beehives[beehives.Count - 1] - hornets.Sum();
                        if (diferents > 0)
                        {
                            winBeehives.Add(diferents);
                        }

                        beehives.RemoveAt(beehives.Count - 1);
                        hornets.RemoveAt(hornets.Count - 1);
                    }

                    counter++;
                    if (beehives.Count == 0 || hornets.Count == 0 || counter >= 3000)
                    {
                        isNewLoop = false;
                    }
                }
                catch (Exception)
                {
                    isNewLoop = false;
                }

            }

            beehives.Reverse();
            hornets.Reverse();

            //while (isNewLoop)
            //{
            //    try
            //    {
            //        if (hornets.Sum() > beehives[0])
            //        {
            //            beehives.RemoveAt(0);
            //        }
            //        else
            //        {
            //            var diferents = beehives[0] - hornets.Sum();
            //            if (diferents > 0)
            //            {
            //                winBeehives.Add(diferents);
            //            }
            //
            //            beehives.RemoveAt(0);
            //            hornets.RemoveAt(0);
            //        }
            //
            //        counter++;
            //        if (beehives.Count == 0 || hornets.Count == 0 || counter >= 3000)
            //        {
            //            isNewLoop = false;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        isNewLoop = false;
            //    }
            //    
            //}

            winBeehives.AddRange(beehives);
            if (winBeehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", winBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
