using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var countTeams = int.Parse(Console.ReadLine());
            var teams = new List<Team>();//may be []arr
            var join = Console.ReadLine();
            for (int i = 0; i < countTeams; i++)
            {
                var separatedPrices = join.Split('-').ToList();
                var creator = separatedPrices[0];
                var teamName = separatedPrices[1];
                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    
                }
                else
                {
                    if (teams.Any(x => x.Creator == creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                        
                    }
                    else
                    {
                        var newTeam = new Team();
                        newTeam.Creator = creator;
                        newTeam.Name = teamName;
                        List<string> members = new List<string>();
                        newTeam.Students = members;
                        teams.Add(newTeam);
                        Console.WriteLine($"Team {newTeam.Name} has been created by {newTeam.Creator}!");
                    }
                }
                //if (teams.Any(x => x.Name == teamName) == false)
                //{
                //    var newTeam = new Team();
                //    newTeam.Creator = creator;
                //    newTeam.Name = teamName;
                //    if (teams.Any(x => x.Creator == newTeam.Creator))
                //    {
                //        Console.WriteLine($"{newTeam.Creator} cannot create another team!");
                //    }
                //    else
                //    {
                //        teams.Add(newTeam);
                //        Console.WriteLine($"Team {newTeam.Name} has been created by {newTeam.Creator}!");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine($"Team {teamName} was already created!");
                //}
                join = Console.ReadLine();
            }
            
            while (join != "end of assignment")
            {
                var separatedPrices = join
                    .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var user = separatedPrices[0];
                var teamName = separatedPrices[1];
                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if(teams.Any(x => x.Students.Contains(user))
                    || teams.Any(x => x.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    foreach (var item in teams
                        .Where(x => x.Name == teamName))
                    {
                        item.Students.Add(user);
                    }
                }

                //if (teams.Any(x => x.Name == teamName)) // if it exist
                //{
                //    if (teams.Any(x => x.Creator == user))
                //    {
                //        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                //    }
                //    else
                //    {
                //        var temporalTeam = teams.First(x => x.Name == teamName);
                //        if (temporalTeam.Students == null)
                //        {
                //            var users = new List<string>();
                //            users.Add(user);
                //            temporalTeam.Students = users;
                //        }
                //        else
                //        {
                //            temporalTeam.Students.Add(user);
                //        }
                //    }
                //}
                //else// if it dosen't exist
                //{
                //    Console.WriteLine($"Team {teamName} does not exist!");
                //}

                join = Console.ReadLine();
            }

            //var teamsRun = teams
            //    .Where(x => x.Students != null)
            //    .OrderByDescending(x => x.Students.Count)
            //    .ThenBy(x => x.Name);
            foreach (var team in teams
                .Where(x => x.Students.Count != 0)
                .OrderByDescending(x => x.Students.Count)
                .ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var user in team.Students.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            //var teamsDisband = teams
            //    .Where(x => x.Students == null)
            //    .OrderBy(x => x.Name);
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams
                .Where(x => x.Students.Count == 0)
                .OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
