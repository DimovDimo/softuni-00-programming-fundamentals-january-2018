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
            var allInputs = new List<string>();
            while (inputDNA != "Clone them!")
            {
                allInputs.Add(inputDNA);
                var splited = inputDNA
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (splited.Count == DNALenght)//I don't know
                {
                    DNAs.Add(string.Join("", inputDNA));
                }

                inputDNA = Console.ReadLine();
            }

            var bestDNAs = new List<string>();//time
            var bestLenght = 0;
            foreach (var DNAcurrent in DNAs)
            {
                var splited = DNAcurrent
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var DNA = string.Join("", splited);
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
                    bestDNAs.Add(DNAcurrent);
                }
            }

            var moreBestDNAs = new List<string>();//empty
            foreach (var DNAcurrent in bestDNAs)
            {
                var splited = DNAcurrent
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var DNA = string.Join("", splited);
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
                    moreBestDNAs.Add(DNAcurrent);
                }
            }
            ///////////////////////////////////////////////////*****************************************
            if (moreBestDNAs.Count == 1)
            {
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

                //var bestSumNow = int.MinValue;
                MatchCollection matchesDNA = Regex.Matches(moreBestDNAs[0], @"(1+)");
                var bestLenghtCurrnet = 0;
                foreach (Match item in matchesDNA)
                {
                    if (item.Groups[1].Value.Length > bestLenghtCurrnet)
                    {
                        bestLenghtCurrnet = item.Groups[1].Value.Length;
                    }
                }

                //if (bestLenght <= bestLenghtCurrnet)
                //{
                //    bestLenght = bestLenghtCurrnet;
                //}
                //foreach (var DNAcurrent in moreBestDNAs)
                //{
                //    var splited = DNAcurrent
                //        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                //        .ToList();
                //    var DNA = string.Join("", splited);
                //    var currentSum = DNA.ToCharArray().Select(x => int.Parse(x.ToString())).ToList().Sum();
                //    if (bestSumNow < currentSum)
                //    {
                //        bestSumNow = currentSum;
                //    }
                //}

                for (int i = 0; i < allInputs.Count; i++)
                {
                    if (allInputs[i] == moreBestDNAs[0])//all
                    {
                        var splited = moreBestDNAs[0]
                        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                        var DNA = string.Join(" ", splited);
                        Console.WriteLine($"Best DNA sample {i + 1} with sum: {bestLenghtCurrnet}.");
                        Console.WriteLine(DNA);
                    }
                }

                return;
            }

            var leftMoreBestDNAs = new List<string>();
            var mostLeftIndex = int.MaxValue;
            foreach (var DNAcurrent in moreBestDNAs)
            {
                var splited = DNAcurrent
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var DNA = string.Join("", splited);
                var currentIndex = DNA.IndexOf(new string('1', bestLenght));
                if (mostLeftIndex > currentIndex)
                {
                    mostLeftIndex = currentIndex;
                }
            }

            foreach (var DNAcurrent in moreBestDNAs)
            {
                var splited = DNAcurrent
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var DNA = string.Join("", splited);
                var currentIndex = DNA.IndexOf(new string('1', bestLenght));
                if (mostLeftIndex == currentIndex)
                {
                    leftMoreBestDNAs.Add(DNAcurrent);
                }
            }
            //////////////////////////////////////////////////////////////////////////////
            if (leftMoreBestDNAs.Count == 1)
            {
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

                var bestSumNow = int.MinValue;
                foreach (var DNAcurrent in moreBestDNAs)
                {
                    var splited = DNAcurrent
                        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var DNA = string.Join("", splited);
                    var currentSum = DNA.ToCharArray().Select(x => int.Parse(x.ToString())).ToList().Sum();
                    if (bestSumNow < currentSum)
                    {
                        bestSumNow = currentSum;
                    }
                }

                //MatchCollection matchesDNA = Regex.Matches(leftMoreBestDNAs[0], @"(1+)");
                //var bestLenghtCurrnet = 0;
                //foreach (Match item in matchesDNA)
                //{
                //    if (item.Groups[1].Value.Length > bestLenghtCurrnet)
                //    {
                //        bestLenghtCurrnet = item.Groups[1].Value.Length;
                //    }
                //}

                for (int i = 0; i < allInputs.Count; i++)
                {
                    if (allInputs[i] == leftMoreBestDNAs[0])//all
                    {
                        var splited = leftMoreBestDNAs[0]
                        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                        var DNA = string.Join(" ", splited);
                        Console.WriteLine($"Best DNA sample {i + 1} with sum: {bestSumNow}.");
                        Console.WriteLine(DNA);
                        return;
                    }
                }
            }
            else/////////////////////////+++++++++++++++++++++++++++++++++++++++++
            {
                var bestSum = int.MinValue;
                foreach (var DNAcurrent in leftMoreBestDNAs)
                {
                    var splited = DNAcurrent
                        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var DNA = string.Join("", splited);
                    var currentSum = DNA.ToCharArray().Select(x => int.Parse(x.ToString())).ToList().Sum();
                    if (bestSum < currentSum)
                    {
                        bestSum = currentSum;
                    }
                }

                var finalyBestDNA = "";
                foreach (var DNAcurrent in leftMoreBestDNAs)
                {
                    var splited = DNAcurrent
                        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var DNA = string.Join("", splited);
                    var currentSum = DNA.ToCharArray().Select(x => int.Parse(x.ToString())).ToList().Sum();
                    if (bestSum == currentSum)
                    {
                        finalyBestDNA = DNAcurrent;
                        break;
                    }
                }

                for (int i = 0; i < allInputs.Count; i++)
                {
                    if (allInputs[i] == finalyBestDNA)//all
                    {
                        var splited = finalyBestDNA
                        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                        var DNA = string.Join(" ", splited);
                        Console.WriteLine($"Best DNA sample {i + 1} with sum: {bestSum}.");
                        Console.WriteLine(DNA);
                    }
                }
            }

            
        }
    }
}
