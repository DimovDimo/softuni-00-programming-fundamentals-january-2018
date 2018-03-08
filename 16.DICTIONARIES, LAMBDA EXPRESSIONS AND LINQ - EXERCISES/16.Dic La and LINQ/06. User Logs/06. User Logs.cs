using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    foreach (var userPair in users)
                    {
                        Console.WriteLine($"{userPair.Key}:");
                        var ipsList = new List<string>();
                        foreach (var ipPair in userPair.Value)
                        {
                            ipsList.Add($"{ipPair.Key} => {ipPair.Value}");
                        }

                        Console.Write(string.Join(", ", ipsList));
                        Console.Write(".");
                        Console.WriteLine();
                    }

                    return;
                }

                var separated = input
                .Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                var ip = separated[1];
                var user = separated[5];
                if (users.ContainsKey(user) == false)
                {
                    var emptyDic = new Dictionary<string, int>();
                    users.Add(user, emptyDic);
                }

                if (users[user].ContainsKey(ip) == false)
                {
                    users[user].Add(ip, 0);
                }

                users[user][ip]++;
            }
        }
    }
}
