using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var directories = Directory.GetFiles(@"..\..\05. Folder Size\TestFolder");
            //var fileSize = new List<double>();
            var sum = 0.0;
            foreach (var directory in directories)
            {
                var fileInfo = new FileInfo(directory);
                //fileSize.Add((double)fileInfo.Length / 1024 / 1024);
                sum += (double)fileInfo.Length / 1024 / 1024;
            }

            File.WriteAllText(@"..\..\output.txt", sum.ToString());
            //File.WriteAllLines(@"..\..\output.txt", fileSize
            //    .Select(x => x.ToString()));
        }
    }
}
