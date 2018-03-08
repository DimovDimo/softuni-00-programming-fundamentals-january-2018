using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integer_Size
{
    class Program
    {
        static void Main(string[] args)
        {//(sbyte &lt; byte &lt; short &lt; ushort &lt; int &lt; uint &lt; long).
            var number = Console.ReadLine();
            var find = false;
            var sbyteNum = "";
            var byteNum = "";
            var shortNum = "";
            var ushortNum = "";
            var intNum = "";
            var uintNum = "";
            var longNum = "";

            try
            {
                var tempNum = sbyte.Parse(number);
                find = true;
                sbyteNum = "* sbyte";
            }
            catch (Exception)
            { }

            try
            {
                var tempNum = byte.Parse(number);
                find = true;
                byteNum = "* byte";
            }
            catch (Exception)
            { }

            try
            {
                var tempNum = short.Parse(number);
                find = true;
                shortNum = "* short";
            }
            catch (Exception)
            { }

            try
            {
                var tempNum = ushort.Parse(number);
                find = true;
                ushortNum = "* ushort";
            }
            catch (Exception)
            { }

            try
            {
                var tempNum = int.Parse(number);
                find = true;
                intNum = "* int";
            }
            catch (Exception)
            { }

            try
            {
                var tempNum = uint.Parse(number);
                find = true;
                uintNum = "* uint";
            }
            catch (Exception)
            { }

            try
            {
                var tempNum = long.Parse(number);
                find = true;
                longNum = "* long";
            }
            catch (Exception)
            { }

            if (find)
            {
                Console.WriteLine($"{number} can fit in:");
                if (sbyteNum != "")
                {
                    Console.WriteLine(sbyteNum);
                }
                if (byteNum != "")
                {
                    Console.WriteLine(byteNum);
                }
                if (shortNum != "")
                {
                    Console.WriteLine(shortNum);
                }
                if (ushortNum != "")
                {
                    Console.WriteLine(ushortNum);
                }
                if (intNum != "")
                {
                    Console.WriteLine(intNum);
                }
                if (uintNum != "")
                {
                    Console.WriteLine(uintNum);
                }
                if (longNum != "")
                {
                    Console.WriteLine(longNum);
                }
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
