using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var pattern10Times = @"(@{10}|#{10}|\${10}|\^{10})";
            var pattern6Times = @"(?=.*)((@{6}|#{6}|\${6}|\^{6}))(.*)(\2)(?=.*)";
            var pattern6TimesOrMore = @"(?=.*)((@{6,9}|#{6,9}|\${6,9}|\^{6,9}))(.*?)((@{6,9}|#{6,9}|\${6,9}|\^{6,9}))(?=.*)";//*
            var patternForHalf = @"(?=.*)((@{6,9}|#{6,9}|\${6,9}|\^{6,9}))(.*?)";
            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    if (Regex.IsMatch(ticket.Substring(0, 10), pattern10Times) || Regex.IsMatch(ticket.Substring(11), pattern10Times))
                    {
                        MatchCollection jacpotMatches = Regex.Matches(ticket, pattern10Times);
                        var jacpotSymbol = jacpotMatches[0].Groups[1].Value[0];
                        //var jacpotSymbolCount = 0;
                        //foreach (var currentChar in ticket.ToCharArray())
                        //{
                        //    if (currentChar == jacpotSymbol)
                        //    {
                        //        jacpotSymbolCount++;
                        //    }
                        //}

                        Console.WriteLine($"ticket \"{ticket}\" - {10}{jacpotSymbol} Jackpot!");// or more than 10
                    }
                    else if (Regex.IsMatch(ticket, pattern6TimesOrMore))
                    {
                        var leftHalf = ticket.Substring(0, 10);
                        var rightHalf = ticket.Substring(11);
                        MatchCollection leftMatches = Regex.Matches(leftHalf, patternForHalf);
                        MatchCollection rightMatches = Regex.Matches(rightHalf, patternForHalf);
                        if (leftMatches.Count != 0 && rightMatches.Count != 0)
                        {
                            var winSymbol = leftMatches[0].Groups[2].Value[0];
                            var countSymbols = leftMatches[0].Groups[2].Value.Length;
                            if (leftMatches[0].Groups[2].Value.Length >= rightMatches[0].Groups[2].Value.Length)
                            {
                                countSymbols = leftMatches[0].Groups[2].Value.Length;
                            }
                            else
                            {
                                countSymbols = rightMatches[0].Groups[2].Value.Length;
                            }

                            Console.WriteLine($"ticket \"{ticket}\" - {countSymbols}{winSymbol}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                        //MatchCollection winMatches = Regex.Matches(ticket, pattern6TimesOrMore);
                        //var firstMatch = winMatches[0].Groups[2].Value;
                        //var secondMatch = winMatches[0].Groups[5].Value;
                        //if (firstMatch[0] == secondMatch[0])
                        //{
                        //    var winSymbol = firstMatch[0];
                        //    var countSymbols = Math.Max(firstMatch.Length, secondMatch.Length);
                        //    Console.WriteLine($"ticket \"{ticket}\" - {firstMatch.Length}{winSymbol}");
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"ticket \"{ticket}\" - no match");
                        //}
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
