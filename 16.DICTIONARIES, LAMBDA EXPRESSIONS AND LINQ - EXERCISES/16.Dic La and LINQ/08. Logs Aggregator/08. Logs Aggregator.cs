using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logsAggregator = new SortedDictionary<string, SortedDictionary<string, long>>();
            var usersCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < usersCount; i++)
            {
                var separated = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var ip = separated[0];
                var user = separated[1];
                var duration = separated[2];
                if (logsAggregator.ContainsKey(user) == false)
                {
                    var emptyDic = new SortedDictionary<string, long>();
                    logsAggregator.Add(user, emptyDic);
                }

                if (logsAggregator[user].ContainsKey(ip) == false)
                {
                    logsAggregator[user].Add(ip, 0);
                }

                logsAggregator[user][ip] += int.Parse(duration);
            }

            foreach (var logsAggregatorPair in logsAggregator)
            {
                var ips = new List<string>();
                foreach (var ip in logsAggregatorPair.Value.Keys)
                {
                    ips.Add(ip);
                }

                Console.WriteLine($"{logsAggregatorPair.Key}: {logsAggregatorPair.Value.Values.Sum()} [{string.Join(", ", logsAggregatorPair.Value.Keys)}]");
            }
        }
    }
}
