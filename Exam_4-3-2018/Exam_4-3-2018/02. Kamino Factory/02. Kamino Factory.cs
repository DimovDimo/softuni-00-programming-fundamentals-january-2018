using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var DNALenght = int.Parse(Console.ReadLine());
            var DNAs = new List<string>();//time
            var inputDNA = Console.ReadLine();
            while (inputDNA != "Clone them!")
            {
                var splited = inputDNA
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                //if (splited.Count == DNALenght)//I don't know
                //{
                //    DNAs.Add(string.Join("", splited));
                //}
                DNAs.Add(string.Join("", splited));

                inputDNA = Console.ReadLine();
            }

            var workingDNAs = new List<string>();
            foreach (var DNA in DNAs)
            {
                var splited = DNA
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (string.Join("", splited).Length == DNALenght)//I don't know
                {
                    workingDNAs.Add(string.Join("", splited));
                }
            }

            var bestDNAs = new List<string>();//time
            var bestLenght = 0;
            foreach (var DNA in workingDNAs)
            {
                MatchCollection matchesDNA = Regex.Matches(DNA, @"(1+)");
                var bestLenghtCurrnet = 0;
                foreach (Match item in matchesDNA)
                {
                    if (item.Groups[1].Value.Length > bestLenghtCurrnet)
                    {
                        bestLenghtCurrnet = item.Groups[1].Value.Length;
                    }
                }

                if (bestLenght <= bestLenghtCurrnet)
                {
                    bestLenght = bestLenghtCurrnet;
                    bestDNAs.Add(DNA);
                }
            }

            var moreBestDNAs = new List<string>();//empty
            foreach (var DNA in bestDNAs)
            {
                MatchCollection matchesDNA = Regex.Matches(DNA, @"(1+)");
                var bestLenghtCurrnet = 0;
                foreach (Match item in matchesDNA)
                {
                    if (item.Groups[1].Value.Length > bestLenghtCurrnet)
                    {
                        bestLenghtCurrnet = item.Groups[1].Value.Length;
                    }
                }

                if (bestLenght == bestLenghtCurrnet)
                {
                    moreBestDNAs.Add(DNA);
                }
            }

            if (moreBestDNAs.Count == 1)
            {//3 times
                //try
                //{
                //    string[] areYouHere = new string[1];
                //    var a = areYouHere[10000];
                //}
                //catch (Exception)
                //{
                //
                //    throw;
                //}
                

                for (int i = 0; i < DNAs.Count; i++)
                {
                    if (DNAs[i] == moreBestDNAs[0])
                    {
                        MatchCollection matchesDNA = Regex.Matches(DNAs[i], @"(1+)");
                        var maxLengh = int.MinValue;
                        foreach (Match currentDNA in matchesDNA)
                        {
                            if (maxLengh < currentDNA.Value.Length)
                            {
                                maxLengh = currentDNA.Value.Length;
                            }
                        }
                
                        Console.WriteLine($"Best DNA sample {i + 1} with sum: {maxLengh}.");
                        Console.WriteLine(string.Join(" ", DNAs[i].ToCharArray()));
                        return;
                    }
                }
            }
            else
            {
                var leftMoreBestDNAs = new List<string>();
                var mostLeftIndex = int.MaxValue;
                foreach (var DNA in moreBestDNAs)
                {
                    var currentIndex = DNA.IndexOf(new string('1', bestLenght));
                    if (mostLeftIndex > currentIndex)
                    {
                        mostLeftIndex = currentIndex;
                    }
                }

                foreach (var DNA in moreBestDNAs)
                {
                    var currentIndex = DNA.IndexOf(new string('1', bestLenght));
                    if (mostLeftIndex == currentIndex)
                    {
                        leftMoreBestDNAs.Add(DNA);
                    }
                }

                if (leftMoreBestDNAs.Count == 1)
                {//2 times
                    //try
                    //{
                    //    string[] areYouHere = new string[1];
                    //    var a = areYouHere[10000];
                    //}
                    //catch (Exception)
                    //{
                    //
                    //    throw;
                    //}
                    for (int i = 0; i < DNAs.Count; i++)
                    {
                        if (DNAs[i] == leftMoreBestDNAs[0])
                        {
                            MatchCollection matchesDNA = Regex.Matches(DNAs[i], @"(1+)");
                            var maxLengh = int.MinValue;
                            foreach (Match currentDNA in matchesDNA)
                            {
                                if (maxLengh < currentDNA.Value.Length)
                                {
                                    maxLengh = currentDNA.Value.Length;
                                }
                            }

                            Console.WriteLine($"Best DNA sample {i + 1} with sum: {maxLengh}.");
                            Console.WriteLine(string.Join(" ", DNAs[i].ToCharArray()));
                            return;
                        }
                    }
                }
                else
                {//5 times
                    //try
                    //{
                    //    string[] areYouHere = new string[1];
                    //    var a = areYouHere[10000];
                    //}
                    //catch (Exception)
                    //{
                    //
                    //    throw;
                    //}
                }
            }

            //var bestDNAs = new List<string>();//time
            //var bestLenght = 0;
            //foreach (var DNA in workingDNAs)
            //{
            //    MatchCollection matchesDNA = Regex.Matches(DNA, @"(1+)");
            //    var bestLenghtCurrnet = 0;
            //    foreach (Match item in matchesDNA)
            //    {
            //        if (item.Groups[1].Value.Length > bestLenghtCurrnet)
            //        {
            //            bestLenghtCurrnet = item.Groups[1].Value.Length;
            //        }
            //    }
            //
            //    if (bestLenght <= bestLenghtCurrnet)
            //    {
            //        bestLenght = bestLenghtCurrnet;
            //        bestDNAs.Add(DNA);
            //    }
            //}
            //
            //var moreBestDNAs = new List<string>();//empty
            //foreach (var DNA in bestDNAs)
            //{
            //    MatchCollection matchesDNA = Regex.Matches(DNA, @"(1+)");
            //    var bestLenghtCurrnet = 0;
            //    foreach (Match item in matchesDNA)
            //    {
            //        if (item.Groups[1].Value.Length > bestLenghtCurrnet)
            //        {
            //            bestLenghtCurrnet = item.Groups[1].Value.Length;
            //        }
            //    }
            //
            //    if (bestLenght == bestLenghtCurrnet)
            //    {
            //        moreBestDNAs.Add(DNA);
            //    }
            //}
            //// if only one
            //if (moreBestDNAs.Count == 1)
            //{
            //    for (int i = 0; i < DNAs.Count; i++)
            //    {
            //        if (DNAs[i] == moreBestDNAs[0])
            //        {
            //            MatchCollection matchesDNA = Regex.Matches(DNAs[i], @"(1+)");
            //            var maxLengh = int.MinValue;
            //            foreach (Match currentDNA in matchesDNA)
            //            {
            //                if (maxLengh < currentDNA.Value.Length)
            //                {
            //                    maxLengh = currentDNA.Value.Length;
            //                }
            //            }
            //
            //            Console.WriteLine($"Best DNA sample {i + 1} with sum: {maxLengh}.");
            //            Console.WriteLine(string.Join(" ", DNAs[i].ToCharArray()));
            //            return;
            //        }
            //    }
            //}
            //
            //var leftMoreBestDNAs = new List<string>();
            //var mostLeftIndex = int.MaxValue;
            //foreach (var DNA in moreBestDNAs)
            //{
            //    var currentIndex = DNA.IndexOf(new string('1', bestLenght));
            //    if (mostLeftIndex > currentIndex)
            //    {
            //        mostLeftIndex = currentIndex;
            //    }
            //}
            //
            //foreach (var DNA in moreBestDNAs)
            //{
            //    var currentIndex = DNA.IndexOf(new string('1', bestLenght));
            //    if (mostLeftIndex == currentIndex)
            //    {
            //        leftMoreBestDNAs.Add(DNA);
            //    }
            //}
            //
            //var bestSum = int.MinValue;
            //foreach (var DNA in moreBestDNAs)
            //{
            //    var currentSum = DNA.ToCharArray().Select(x => int.Parse(x.ToString())).ToList().Sum();
            //    if (bestSum < currentSum)
            //    {
            //        bestSum = currentSum;
            //    }
            //}
            //
            //var finalyBestDNA = "";
            //foreach (var DNA in moreBestDNAs)
            //{
            //    var currentSum = DNA.ToCharArray().Select(x => int.Parse(x.ToString())).ToList().Sum();
            //    if (bestSum == currentSum)
            //    {
            //        finalyBestDNA = DNA;
            //        break;
            //    }
            //}
            //
            //for (int i = 0; i < DNAs.Count; i++)
            //{
            //    if (DNAs[i] == finalyBestDNA)
            //    {
            //        Console.WriteLine($"Best DNA sample {i + 1} with sum: {bestSum}.");
            //        Console.WriteLine(string.Join(" ", finalyBestDNA.ToCharArray()));
            //    }
            //}
            //
            ////if (leftMoreBestDNAs.Count >= 1)
            ////{
            ////    for (int i = 0; i < DNAs.Count; i++)
            ////    {
            ////        if (DNAs[i] == leftMoreBestDNAs[0])
            ////        {
            ////            MatchCollection matchesDNA = Regex.Matches(DNAs[i], @"(1+)");
            ////            var maxLengh = int.MinValue;
            ////            foreach (Match currentDNA in matchesDNA)
            ////            {
            ////                if (maxLengh < currentDNA.Value.Length)
            ////                {
            ////                    maxLengh = currentDNA.Value.Length;
            ////                }
            ////            }
            ////
            ////            Console.WriteLine($"Best DNA sample {i + 1} with sum: {maxLengh}.");
            ////            Console.WriteLine(string.Join(" ", DNAs[i].ToCharArray()));
            ////        }
            ////    }
            ////}
            ////else
            ////{
            ////    var bestSum = int.MinValue;
            ////    foreach (var DNA in moreBestDNAs)
            ////    {
            ////        var currentSum = DNA.ToCharArray().Select(x => int.Parse(x.ToString())).ToList().Sum();
            ////        if (bestSum < currentSum)
            ////        {
            ////            bestSum = currentSum;
            ////        }
            ////    }
            ////
            ////    var finalyBestDNA = "";
            ////    foreach (var DNA in moreBestDNAs)
            ////    {
            ////        var currentSum = DNA.ToCharArray().Select(x => int.Parse(x.ToString())).ToList().Sum();
            ////        if (bestSum == currentSum)
            ////        {
            ////            finalyBestDNA = DNA;
            ////            break;
            ////        }
            ////    }
            ////
            ////    for (int i = 0; i < DNAs.Count; i++)
            ////    {
            ////        if (DNAs[i] == finalyBestDNA)
            ////        {
            ////            Console.WriteLine($"Best DNA sample {i + 1} with sum: {bestSum}.");
            ////            Console.WriteLine(string.Join(" ", finalyBestDNA.ToCharArray()));
            ////        }
            ////    }
            ////}
        }
    }
}
