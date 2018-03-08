using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var sides = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {//name user
                if (Regex.IsMatch(input, @"(.+) \| (.+)"))
                {
                    try
                    {
                        MatchCollection matches = Regex.Matches(input, @"(.+) \| (.+)");
                        var forceSide = matches[0].Groups[1].Value;
                        var forceUser = matches[0].Groups[2].Value;
                        var isThereUser = false;//class
                        var isThereUserSiteName = "$$$$$";
                        foreach (var side in sides)
                        {
                            if (side.Value.Any(x => x == forceUser))
                            {
                                isThereUser = true;
                                isThereUserSiteName = side.Key;
                                break;
                            }
                        }

                        if (isThereUser == false)
                        {
                            try
                            {
                                var emptyUsers = new List<string>();
                                sides.Add(forceSide, emptyUsers);
                            }
                            catch (Exception)
                            {

                            }

                        }

                        //if (sides.ContainsKey(forceSide) == false)
                        //{
                        //    var emptyUsers = new List<string>();
                        //    sides.Add(forceSide, emptyUsers);
                        //}

                        if (sides[forceSide].Any(x => x == forceUser) == false)
                        {
                            sides[forceSide].Add(forceUser);
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                    
                }
                else if (Regex.IsMatch(input, @"(.+) -> (.+)"))
                {
                    MatchCollection matches = Regex.Matches(input, @"(.+) -> (.+)");
                    var forceUser = matches[0].Groups[1].Value;
                    var forceSide = matches[0].Groups[2].Value;
                    if (sides.ContainsKey(forceSide) == false)
                    {
                        var emptyUsers = new List<string>();
                        sides.Add(forceSide, emptyUsers);
                    }

                    var isThereUser = false;//class
                    var isThereUserSiteName = "$$$$$";
                    foreach (var side in sides)
                    {
                        if (side.Value.Any(x => x == forceUser))
                        {
                            isThereUser = true;
                            isThereUserSiteName = side.Key;
                            break;
                        }
                    }

                    if (isThereUser)
                    {
                        sides[isThereUserSiteName].Remove(forceUser);
                        sides[forceSide].Add(forceUser);
                    }
                    else
                    {
                        sides[forceSide].Add(forceUser);
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

                input = Console.ReadLine();
            }

            var fullSides = sides.Where(x => x.Value.Count > 0);
            foreach (var side in fullSides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
