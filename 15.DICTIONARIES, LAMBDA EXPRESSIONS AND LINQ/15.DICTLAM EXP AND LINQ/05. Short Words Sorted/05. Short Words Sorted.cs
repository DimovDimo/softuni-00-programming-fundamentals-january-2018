using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split('.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ')
                .Where(w => w != "")
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(a => a)
                .ToList();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
