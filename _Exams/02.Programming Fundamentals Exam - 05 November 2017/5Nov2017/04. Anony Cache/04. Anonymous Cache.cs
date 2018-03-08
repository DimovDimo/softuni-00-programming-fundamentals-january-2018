using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Anony_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSets = new Dictionary<string, Dictionary<string, long>>();
            var unBaseDataSets = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();
            while (input != "thetinggoesskrra")
            {
                var splited = input
                                .Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
                if (splited.Count == 1)
                {
                    var emptyDict = new Dictionary<string, long>();
                    dataSets.Add(splited[0], emptyDict);
                }
                else
                {
                    var dataKey = splited[0];// sum or replace?
                    var dataSize = long.Parse(splited[1]);
                    var unBaseDataSet = splited[2];
                    if (unBaseDataSets.ContainsKey(unBaseDataSet) == false)
                    {
                        var emptyDict = new Dictionary<string, long>();
                        unBaseDataSets.Add(unBaseDataSet, emptyDict);
                    }

                    if (unBaseDataSets[unBaseDataSet].ContainsKey(dataKey) == false)
                    {
                        unBaseDataSets[unBaseDataSet].Add(dataKey, dataSize);
                    }

                    // sum or replace?
                }

                input = Console.ReadLine();
            }
            try
            {
                var outputDataSets = new Dictionary<string, Dictionary<string, long>>();
                foreach (var dataSet in dataSets)
                {
                    if (unBaseDataSets.ContainsKey(dataSet.Key))
                    {
                        outputDataSets.Add(dataSet.Key, unBaseDataSets[dataSet.Key]);
                        //outputDataSets[dataSet.Key] = unBaseDataSets[dataSet.Key];
                    }
                }

                long maxSum = outputDataSets.Max(x => x.Value.Values.Sum());
                var largestDataSet = outputDataSets
                    .First(x => x.Value.Values.Sum() == maxSum);
                Console.WriteLine($"Data Set: {largestDataSet.Key}, Total Size: {maxSum}");
                foreach (var data in largestDataSet.Value)
                {
                    Console.WriteLine($"$.{data.Key}");
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
