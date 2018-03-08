using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalPrice = 0.0M;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var data = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleCount = decimal.Parse(Console.ReadLine());
                var price = (DateTime.DaysInMonth(data.Year, data.Month) * capsuleCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }

    public struct BigDecimal
    {
        public BigInteger Integer { get; set; }
        public BigInteger Scale { get; set; }

        public BigDecimal(BigInteger integer, BigInteger scale) : this()
        {
            Integer = integer;
            Scale = scale;
            while (Scale > 0 && Integer % 10 == 0)
            {
                Integer /= 10;
                Scale -= 1;
            }
        }

        public static implicit operator BigDecimal(decimal a)
        {
            BigInteger integer = (BigInteger)a;
            BigInteger scale = 0;
            decimal scaleFactor = 1m;
            while ((decimal)integer != a * scaleFactor)
            {
                scale += 1;
                scaleFactor *= 10;
                integer = (BigInteger)(a * scaleFactor);
            }
            return new BigDecimal(integer, scale);
        }

        public static BigDecimal operator *(BigDecimal a, BigDecimal b)
        {
            return new BigDecimal(a.Integer * b.Integer, a.Scale + b.Scale);
        }

        public override string ToString()
        {
            string s = Integer.ToString();
            if (Scale != 0)
            {
                if (Scale > Int32.MaxValue) return "[Undisplayable]";
                int decimalPos = s.Length - (int)Scale;
                s = s.Insert(decimalPos, decimalPos == 0 ? "0." : ".");
            }
            return s;
        }
    }
}
