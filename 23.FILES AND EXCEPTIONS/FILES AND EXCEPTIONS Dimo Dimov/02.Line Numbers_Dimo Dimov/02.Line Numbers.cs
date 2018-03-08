using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\02. Line Numbers\Input.txt");
            var output = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                output.Add($"{i + 1}. {lines[i]}");
            }

            File.WriteAllLines(@"..\..\output.txt", output);
        }
    }
}
