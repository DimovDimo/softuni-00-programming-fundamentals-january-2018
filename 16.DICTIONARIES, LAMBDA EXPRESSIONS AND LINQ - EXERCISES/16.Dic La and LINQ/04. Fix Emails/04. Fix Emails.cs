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
            var emails = new Dictionary<string, string>();
            while (true)
            {
                //{name} – > {email} 
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    foreach (var pair in emails)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }

                    return;
                }

                var email = Console.ReadLine();
                var spliteredEmail = email
                    .Split('.')
                    .ToList();
                if (spliteredEmail[spliteredEmail.Count - 1] != "us"
                    && spliteredEmail[spliteredEmail.Count - 1] != "uk")
                {
                    emails[name] = email;
                }
            }
        }
    }
}
