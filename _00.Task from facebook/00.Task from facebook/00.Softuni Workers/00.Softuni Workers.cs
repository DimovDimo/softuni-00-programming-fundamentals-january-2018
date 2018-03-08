using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Softuni_Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWorkers = 20;
            decimal totalDaySalary = 20.0M;
            decimal deveoperSalary = 3.0M;
            decimal qaSalary = 1.5M;
            decimal copywriterSalary = 0.5M;
            int countOpportunities = 0;
            List<SoftuniWorkers> softuniWorkers = new List<SoftuniWorkers>();
            Console.WriteLine("All opportunities for the Softuni workers are:");
            for (int develpersCount = 0; develpersCount <= Math.Ceiling(totalDaySalary / deveoperSalary); develpersCount++)
            {
                for (int qaCount = 0; qaCount <= Math.Ceiling(totalDaySalary / qaSalary); qaCount++)
                {
                    for (int copywritersCount = 0; copywritersCount <= Math.Ceiling(totalDaySalary / copywriterSalary); copywritersCount++)
                    {
                        int currentCountWorkers = develpersCount + qaCount + copywritersCount;
                        bool isCountWorkers20 = currentCountWorkers == countWorkers;
                        decimal sumDevelpersSalary = develpersCount * deveoperSalary;
                        decimal sumQaSalary = qaCount * qaSalary;
                        decimal sumCopywriterSalary = copywritersCount * copywriterSalary;
                        decimal currentTotalDaySalary = sumDevelpersSalary + sumQaSalary + sumCopywriterSalary;
                        bool isTotalDaySalary20 = currentTotalDaySalary == totalDaySalary;
                        if (isCountWorkers20 && isTotalDaySalary20)
                        {
                            countOpportunities++;
                            Console.Write($"Opportunity {countOpportunities}) ");
                            Console.Write($"Develpers: {develpersCount}; ");
                            Console.Write($"QA: {qaCount}; ");
                            Console.Write($"Copywriters: {copywritersCount}; ");
                            Console.Write($"Count workers: {currentCountWorkers}; ");
                            Console.Write($"Total day salary: {currentTotalDaySalary:F2}lv");
                            Console.WriteLine();
                            bool areThereOneWorkerFromProfession = (develpersCount >= 1) && 
                                                                  (qaCount >= 1) && 
                                                                  (copywritersCount >= 1);
                            if (areThereOneWorkerFromProfession)
                            {
                                SoftuniWorkers currentSoftuniWorkers = new SoftuniWorkers();
                                currentSoftuniWorkers.Opportunity = countOpportunities;
                                currentSoftuniWorkers.Develpers = develpersCount;
                                currentSoftuniWorkers.QA = qaCount;
                                currentSoftuniWorkers.Copywriters = copywritersCount;
                                currentSoftuniWorkers.CountWorkers = currentCountWorkers;
                                currentSoftuniWorkers.TotalDaySalary = currentTotalDaySalary;
                                softuniWorkers.Add(currentSoftuniWorkers);
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("All opportunities for the Softuni workers if there are one worker or more from a profession:");
            foreach (var currentOpportunity in softuniWorkers)
            {
                Console.Write($"Opportunity {currentOpportunity.Opportunity}) ");
                Console.Write($"Develpers: {currentOpportunity.Develpers}; ");
                Console.Write($"QA: {currentOpportunity.QA}; ");
                Console.Write($"Copywriters: {currentOpportunity.Copywriters}; ");
                Console.Write($"Count workers: {currentOpportunity.CountWorkers}; ");
                Console.Write($"Total day salary: {currentOpportunity.TotalDaySalary:F2}lv");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Decision: Dimo Dimov");
            Console.WriteLine("Softuni user name: D.Dimov_96");
        }
    }
}
