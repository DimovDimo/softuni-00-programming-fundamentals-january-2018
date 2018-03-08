using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"([A-Za-z]+)(.+)(\1)";
            var text = Console.ReadLine();
            var words = Console.ReadLine()
                    .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            MatchCollection matches = Regex.Matches(text, pattern);
            for (int i = 0; i < matches.Count; i++)
            {
                //Console.WriteLine(matches[i].Groups[0].Value);
                var replasement = matches[i].Groups[0].Value;
                //text = Regex.Replace(text, pattern, words[0]);
                //text = Regex.Replace(text, matches[i].Groups[2].Value, words[i]);
                var targetReplase = matches[i].Groups[1].Value + words[i] + matches[i].Groups[1].Value;
                var regex = new Regex(Regex.Escape(replasement));
                text = regex.Replace(text, targetReplase, 1);
                //Console.WriteLine(text);
            }

            Console.WriteLine(text);
        }
    }
}
