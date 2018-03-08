using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfCube = double.Parse(Console.ReadLine());
            var propertiesOfCube = Console.ReadLine().ToLower();
            switch (propertiesOfCube)
            {
                case "volume":
                    PrintVolumeOfCube(sideOfCube);
                    break;
                case "space":
                    PrintSpaceOfCube(sideOfCube);
                    break;
                case "face":
                    PrintFaceOfCube(sideOfCube);
                    break;
                case "area":
                    PrintAreaOfCube(sideOfCube);
                    break;
                default:
                    break;
            }
        }

        static void PrintVolumeOfCube(double sideOfCube)
        {
            var volume = Math.Pow(sideOfCube, 3);
            Console.WriteLine($"{volume:F2}");
        }

        static void PrintAreaOfCube(double sideOfCube)
        {
            var area = Math.Pow(sideOfCube, 2) * 6;
            Console.WriteLine($"{area:F2}");
        }

        static void PrintFaceOfCube(double sideOfCube)
        {
            var face = Math.Sqrt(Math.Pow(sideOfCube, 2) * 2);
            Console.WriteLine($"{face:F2}");
        }

        static void PrintSpaceOfCube(double sideOfCube)
        {
            var space = Math.Sqrt(Math.Pow(sideOfCube, 2) * 3);
            Console.WriteLine($"{space:F2}");
        }
    }
}
