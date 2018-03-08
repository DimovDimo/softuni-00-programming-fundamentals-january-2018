using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Budd
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var patternP = @"(?<=<p>)(.*?)(?=<\/p>)";
            MatchCollection matches = Regex.Matches(input, patternP);
            var texts = new StringBuilder();
            foreach (Match match in matches)
            {
                texts.Append(match.Groups[1].Value);
            }

            //string input = "This is   text with   far  too   much   " +
            //         "whitespace.";
            //string pattern = "\\s+";
            //string replacement = " ";
            //Regex rgx = new Regex(pattern);
            //string result = rgx.Replace(input, replacement);
            string patternOnlySmallLettersAndDigits = @"[^a-z0-9]";
            string replacement = " ";
            Regex rgxOnlySmallLettersAndDigits = new Regex(patternOnlySmallLettersAndDigits);
            string lettersAndDigitsResult = rgxOnlySmallLettersAndDigits.Replace(texts.ToString(), replacement);

            string patternSPlus = "\\s+";
            string replacementSpace = " ";
            Regex rgx = new Regex(patternSPlus);
            string resultText = rgx.Replace(lettersAndDigitsResult, replacementSpace);
            //Console.WriteLine(resultText);
            string output = ConVertAlphabet(resultText);
            Console.WriteLine(output);
        }

        static string ConVertAlphabet(string text)
        {
            var charText = text.ToCharArray();
            for (int i = 0; i < charText.Length; i++)
            {
                //a b c d e f g h i j k l m n o p q r s t u v w x y z
                //n o p q r s t u v w x y z a b c d e f g h i j k l m
                switch (charText[i])
                {
                    case 'a': charText[i] = 'n'; break;
                    case 'b': charText[i] = 'o'; break;
                    case 'c': charText[i] = 'p'; break;
                    case 'd': charText[i] = 'q'; break;
                    case 'e': charText[i] = 'r'; break;
                    case 'f': charText[i] = 's'; break;
                    case 'g': charText[i] = 't'; break;
                    case 'h': charText[i] = 'u'; break;
                    case 'i': charText[i] = 'v'; break;
                    case 'j': charText[i] = 'w'; break;
                    case 'k': charText[i] = 'x'; break;
                    case 'l': charText[i] = 'y'; break;
                    case 'm': charText[i] = 'z'; break;
                    //a b c d e f g h i j k l m n o p q r s t u v w x y z
                    //n o p q r s t u v w x y z a b c d e f g h i j k l m
                    case 'n': charText[i] = 'a'; break;
                    case 'o': charText[i] = 'b'; break;
                    case 'p': charText[i] = 'c'; break;
                    case 'q': charText[i] = 'd'; break;
                    case 'r': charText[i] = 'e'; break;
                    case 's': charText[i] = 'f'; break;
                    case 't': charText[i] = 'g'; break;
                    case 'u': charText[i] = 'h'; break;
                    case 'v': charText[i] = 'i'; break;
                    case 'w': charText[i] = 'j'; break;
                    case 'x': charText[i] = 'k'; break;
                    case 'y': charText[i] = 'l'; break;
                    case 'z': charText[i] = 'm'; break;
                    default:
                        break;
                }
            }

            return string.Join("", charText);
        }

        static string ConvertFromAToM(string text)
        {
            var charText = text.ToCharArray();
            for (int i = 0; i < charText.Length; i++)
            {
                if ((int)charText[i] >= 97 &&
                    (int)charText[i] <= 109)
                {
                    charText[i] = (char)((int)charText[i] + 13);
                }
            }

            return string.Join("", charText);
        }

        static string ConvertFromNToZ(string text)
        {
            var charText = text.ToCharArray();
            for (int i = 0; i < charText.Length; i++)
            {
                if ((int)charText[i] >= 110 &&
                    (int)charText[i] <= 122)
                {
                    charText[i] = (char)((int)charText[i] - 13);
                }
            }

            return string.Join("", charText);
        }
    }
}
