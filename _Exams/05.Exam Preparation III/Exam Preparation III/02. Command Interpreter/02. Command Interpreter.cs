using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var seties = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var splited = line
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var command = splited[0];
                var isInvalid = false;
                if (command == "reverse")
                {
                    var start = int.Parse(splited[2]);
                    var count = int.Parse(splited[4]);
                    if (IsValid(start, count, seties))
                    {
                        seties = ResercePart(seties, start, count);
                    }
                    else
                    {
                        isInvalid = true;
                    }
                }
                else if (command == "sort")
                {
                    var start = int.Parse(splited[2]);
                    var count = int.Parse(splited[4]);
                    if (IsValid(start, count, seties))
                    {
                        seties = SortPart(seties, start, count);
                    }
                    else
                    {
                        isInvalid = true;
                    }
                }
                else if (command == "rollLeft")
                {
                    int count = int.Parse(splited[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        count = count % seties.Count;
                        for (int i = 0; i < count; i++)
                        {
                            seties.Insert(seties.Count, seties[0]);
                            seties.RemoveAt(0);
                        }
                    }
                }
                else if (command == "rollRight")
                {
                    int count = int.Parse(splited[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        count = count % seties.Count;
                        for (int i = 0; i < count; i++)
                        {
                            seties.Insert(0, seties[seties.Count - 1]);
                            seties.RemoveAt(seties.Count - 1);
                        }
                    }
                }

                if (isInvalid)
                {
                    Console.WriteLine("Invalid input parameters.");
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", seties) + "]");
        }

        private static List<string> SortPart(List<string> seties, int start, int count)
        {
            var currList = seties.Skip(start).Take(count).OrderBy(str => str).ToList();
            seties.RemoveRange(start, count);
            seties.InsertRange(start, currList);
            return seties;
        }

        private static List<string> ResercePart(List<string> seties, int start, int count)
        {
            var currList = seties.Skip(start).Take(count).Reverse().ToList();
            seties.RemoveRange(start, count);
            seties.InsertRange(start, currList);
            return seties;
        }
        //time
        private static List<string> RollRight(List<string> seties)
        {
            var last = seties[seties.Count - 1];
            var right = new List<string>();
            right.Add(last);
            right.AddRange(seties.Take(seties.Count - 1));
            return right;
        }

        static bool IsValid(int start, int count, List<string> seties)
        {
            if (start < 0 || start >= seties.Count || (start + count) > seties.Count || count < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static List<string> RollLeft(List<string> seties, int count)
        {
            for (int i = 0; i < count % seties.Count; i++)
            {
                string element = seties[0];
                seties.RemoveAt(0);
                seties.Add(element);
            }

            return seties;
        }
    }
}
