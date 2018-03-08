using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\01. Odd Lines\Input.txt");
            var output = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    output.Add(lines[i]);
                }
            }

            File.WriteAllLines(@"..\..\output.txt", output);
        }
    }
}
