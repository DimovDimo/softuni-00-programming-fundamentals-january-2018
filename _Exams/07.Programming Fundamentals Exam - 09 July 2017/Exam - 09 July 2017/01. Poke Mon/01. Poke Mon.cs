using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nMax = n;
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var targets = 0.0;
            var half = n / 2.0;
            while (n < m == false)
            {
                n -= m;
                targets++;

                if (n == half && y > 0)
                {
                    n /= y;
                }
            }

            //if (half % m == 0)
            //{
            //    if (y > 0)
            //    {
            //        targets = half / m;
            //        var divided = (int)(half / y);
            //        if (divided > m)
            //        {
            //            targets = divided / m;
            //            divided %= m;
            //            n = (int)divided;
            //        }
            //        else
            //        {
            //            n = (int)divided;
            //        }
            //    }
            //    else
            //    {
            //        targets = n / m;
            //        n %= m;
            //    }
            //}
            //else
            //{
            //    targets = n / m;
            //    n %= m;
            //}

            ////try
            ////{
            //while (n < m == false)
            //{
            //    if (n == nMax / 2)
            //    {
            //        try
            //        {
            //            n /= y;
            //        }
            //        catch (Exception)
            //        {
            //
            //        }
            //
            //    }
            //    else
            //    {
            //        n -= m;
            //        targets++;
            //    }
            //}
            //}
            //catch (Exception)
            //{
            //    
            //}


            Console.WriteLine(n);
            Console.WriteLine(targets);
        }
    }
}
