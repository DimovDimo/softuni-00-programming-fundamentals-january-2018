using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Roli
    {
        public string ID { get; set; }
        public string EventName { get; set; }
        public List<string> Participants { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rolisEvents = new List<Roli>();
            var line = Console.ReadLine();
            while (line != "Time for Code")
            {
                if (Regex.IsMatch(line, @"(.+) #(.+)"))
                {
                    var splited = line
                    .Split(new string[] { " #", " @", " ", "\t", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                    var id = splited[0];
                    var eventName = splited[1];
                    var participants = splited.Skip(2).ToList();
                    if (rolisEvents.Any(x => x.ID == id) == false)
                    {
                        var emptyEvents = new List<string>();
                        var currentRoli = new Roli();
                        currentRoli.ID = id;
                        currentRoli.EventName = eventName;
                        currentRoli.Participants = participants;
                        rolisEvents.Add(currentRoli);
                    }
                    else if (rolisEvents.Any(x => x.EventName == eventName) == true)
                    {
                        var roliTemp = rolisEvents.First(x => x.ID == id);
                        roliTemp.Participants.AddRange(participants);
                        var roliTempDistinct = roliTemp.Participants.Distinct().ToList();
                        roliTemp.Participants = roliTempDistinct;
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var eventOfRoli in rolisEvents
                .OrderByDescending(x => x.Participants.Count())
                .OrderBy(x => x.EventName))// alphab
            {
                Console.WriteLine($"{eventOfRoli.EventName} - {eventOfRoli.Participants.Count()}");
                foreach (var participant in eventOfRoli.Participants
                    .OrderBy(x => x))
                {
                    Console.WriteLine("@" + participant);
                }
            }
        }
    }
}
