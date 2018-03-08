using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class RootFile
    {
        public string Root { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var files = new List<RootFile>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var pattern = @"(.+?)\\(.+)\\(.+)";
                MatchCollection matches = Regex.Matches(line, pattern);
                var root = matches[0].Groups[1].Value;
                var fileInfo = matches[0].Groups[3].Value.Split(';');
                var fileName = fileInfo[0];
                var fileSize = fileInfo[1];
                if (files.Any(x => x.Root == root && x.FileName == fileName))
                {
                    var currentFile = files.First(x => x.Root == root && x.FileName == fileName);
                    currentFile.FileSize = fileSize;
                }
                else
                {
                    var rootFile = new RootFile();
                    rootFile.Root = root;
                    rootFile.FileName = fileName;
                    rootFile.FileSize = fileSize;
                    files.Add(rootFile);
                }
            }
            try
            {

            }
            catch (Exception)
            {
                
            }
            var command = Console.ReadLine()
                .Split()
                .ToList();
            var extensionSerch = command[0];
            var rootSerch = command[2];
            var filesReport = files.Where(x => x.Root == rootSerch);
            var foundFiles = new Dictionary<string, BigInteger> ();
            foreach (var file in filesReport)
            {
                var patternExtension = @"(.+)\.(.+)";
                MatchCollection matches = Regex.Matches(file.FileName, patternExtension);
                //try
                //{
                    //var currentExtension = matches[0].Groups[2].Value;Path.GetExtension(
                    //var currentExtension = Path.GetExtension(file.FileName);
                    int index = file.FileName.LastIndexOf('.');
                    var currentExtension = file.FileName.Substring(index + 1);
                    if (currentExtension == extensionSerch)
                    {
                        foundFiles.Add(file.FileName, BigInteger.Parse(file.FileSize));//big
                    }
                //}
                //catch (Exception)
                //{
                //    
                //}
                
            }

            if (foundFiles.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in foundFiles.OrderBy(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
        }
    }
}
