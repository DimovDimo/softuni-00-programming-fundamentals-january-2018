using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Anonym_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                    .Split()
                    .ToList();
            var command = Console.ReadLine();
            while (command != "3:1")
            {
                var commands = command
                            .Split()
                            .ToList();
                var action = commands[0];
                var startIndex = int.Parse(commands[1]);
                var endIndex = int.Parse(commands[2]);
                if (action == "merge")
                {
                    if (startIndex <= words.Count - 1)
                    {
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }

                        if (endIndex > words.Count - 1)
                        {
                            endIndex = words.Count - 1;
                        }

                        var temporalWords = new List<string>();
                        for (int i = 0; i < startIndex; i++)
                        {
                            temporalWords.Add(words[i]);
                        }

                        var wordBuilder = new StringBuilder();
                        for (int i = startIndex; i <= endIndex; i++)
                        {//stringBuilder
                            wordBuilder.Append(words[i]);
                        }

                        temporalWords.Add(wordBuilder.ToString());
                        for (int i = endIndex + 1; i < words.Count; i++)
                        {
                            temporalWords.Add(words[i]);
                        }

                        words = temporalWords;
                    }
                }
                else if (action == "divide")
                {
                    var index = startIndex;
                    var particions = endIndex;
                    if (index >= 0 && index <= words.Count - 1)
                    {
                        if (words[index].Length % particions == 0)
                        {
                            var temporalWords = new List<string>();
                            var word = words[index];
                            var lenghtSubstring = word.Length / particions;
                            for (int i = 0; i < word.Length; i += lenghtSubstring)
                            {
                                temporalWords.Add(word.Substring(i, lenghtSubstring));
                            }

                            words.RemoveAt(index);
                            words.InsertRange(index, temporalWords);
                        }
                        else
                        {
                            if (words[index].Length > particions)
                            {
                                var temporalWords = new List<string>();
                                var word = words[index];
                                var lenghtSubstring = Math.Floor((double)word.Length / particions);
                                var countWords = 1;
                                for (int i = 0; i < word.Length; i += (int)lenghtSubstring)
                                {
                                    if (countWords == particions)
                                    {
                                        temporalWords.Add(word.Substring(i));
                                        break;
                                    }
                                    else
                                    {
                                        temporalWords.Add(word.Substring(i, (int)lenghtSubstring));
                                    }

                                    countWords++;
                                }

                                words.RemoveAt(index);
                                words.InsertRange(index, temporalWords);
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
