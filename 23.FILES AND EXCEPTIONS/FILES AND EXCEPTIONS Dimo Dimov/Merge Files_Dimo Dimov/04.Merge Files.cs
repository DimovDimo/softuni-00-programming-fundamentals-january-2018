using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFile = File.ReadAllLines(@"..\..\04. Merge Files\FileOne.txt")
                .Select(int.Parse)
                .ToList();
            var secondFile = File.ReadAllLines(@"..\..\04. Merge Files\FileTwo.txt")
                .Select(int.Parse)
                .ToList();
            var output = new List<int>();
            output.AddRange(firstFile);
            output.AddRange(secondFile);
            File.WriteAllLines(@"..\..\output.txt", output
                .OrderBy(x => x)
                .Select(x => x.ToString()));
        }
    }
}
