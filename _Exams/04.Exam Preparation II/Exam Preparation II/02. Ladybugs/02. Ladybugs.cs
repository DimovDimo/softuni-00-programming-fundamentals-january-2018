using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtSize = long.Parse(Console.ReadLine());
            var possitions = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            var land = new long[lenghtSize];
            foreach (var possition in possitions)
            {
                if (possition >= 0 &&
                    possition <= lenghtSize - 1)
                {
                    land[possition] = 1;
                }
            }

            var command = Console.ReadLine();
            while (command != "end")
            {
                var splited = command
                    .Split()
                    .ToList();
                var startIndex = long.Parse(splited[0]);
                var direction = splited[1];
                if (direction == "right")
                {
                    var endIndex = long.Parse(splited[2]);// == 0
                    if (endIndex > 0)
                    {
                        land = Right(splited, land, startIndex, endIndex, lenghtSize, direction);
                    }
                    else if (endIndex < 0)
                    {
                        land = Left(splited, land, startIndex, endIndex, lenghtSize, direction);
                    }

                }
                else if (direction == "left")
                {
                    var endIndex = long.Parse(splited[2]);// == 0
                    if (endIndex > 0)
                    {
                        land = Left(splited, land, startIndex, endIndex, lenghtSize, direction);
                    }
                    else if (endIndex < 0)
                    {
                        land = Right(splited, land, startIndex, endIndex, lenghtSize, direction);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", land));
        }

        static long[] Right(List<string> splited, long[] land, long startIndex, long endIndex, long lenghtSize, string direction)
        {
            endIndex = startIndex + long.Parse(splited[2]);
            var flyLenght = long.Parse(splited[2]);
            if (startIndex >= 0 &&
                startIndex <= lenghtSize - 1 &&
                endIndex >= 0 &&
                endIndex <= lenghtSize - 1)
            {
                if (direction == "right")
                {
                    if (land[startIndex] != 0)
                    {
                        land[startIndex] = 0; // fly
                        var isLanded = false;
                        do
                        {
                            if (endIndex >= 0 &&
                                endIndex <= lenghtSize - 1)
                            {
                                if (land[endIndex] == 0)
                                {
                                    land[endIndex] = 1; // landed
                                    isLanded = true;
                                }
                                else
                                {
                                    endIndex += flyLenght;
                                }
                            }
                            else
                            {
                                isLanded = true; //but out of land
                            }

                        } while (isLanded != true);
                    }
                }
                //else if (direction == "left")
                //{
                //
                //}
            }
            else if (startIndex >= 0 &&
                     startIndex <= lenghtSize - 1)
            {
                land[startIndex] = 0; // fly out
            }

            return land;
        }

        static long[] Left(List<string> splited, long[] land, long startIndex, long endIndex, long lenghtSize, string direction)
        {
            endIndex = startIndex - long.Parse(splited[2]);
            var flyLenght = long.Parse(splited[2]);
            if (startIndex >= 0 &&
                startIndex <= lenghtSize - 1 &&
                endIndex >= 0 &&
                endIndex <= lenghtSize - 1)
            {
                if (direction == "right")
                {
                    if (land[startIndex] != 0)
                    {
                        land[startIndex] = 0; // fly
                        var isLanded = false;
                        do
                        {
                            if (endIndex >= 0 &&
                                endIndex <= lenghtSize - 1)
                            {
                                if (land[endIndex] == 0)
                                {
                                    land[endIndex] = 1; // landed
                                    isLanded = true;
                                }
                                else
                                {
                                    endIndex -= flyLenght;
                                }
                            }
                            else
                            {
                                isLanded = true; //but out of land
                            }

                        } while (isLanded != true);
                    }
                }
                else if (direction == "left")
                {

                }
            }
            else if (startIndex >= 0 &&
                     startIndex <= lenghtSize - 1)
            {
                land[startIndex] = 0; // fly out
            }

            return land;
        }
    }
}





