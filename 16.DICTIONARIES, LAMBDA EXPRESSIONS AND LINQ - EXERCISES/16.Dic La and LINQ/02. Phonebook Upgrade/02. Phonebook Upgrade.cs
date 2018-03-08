using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            while (true)
            {
                var command = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                switch (command[0])
                {
                    case "A":
                        phonebook[command[1]] = command[2];
                        break;

                    case "S":
                        if (phonebook.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {command[1]} does not exist.");
                        }

                        break;

                    case "ListAll":
                        foreach (var pair in phonebook)
                        {
                            Console.WriteLine($"{pair.Key} -> {pair.Value}");
                        }
                        break;

                    case "END":
                        return;

                    default:
                        break;
                }
            }
        }
    }
}
