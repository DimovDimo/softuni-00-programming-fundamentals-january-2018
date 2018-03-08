using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        long sizeOfArray = long.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string line = command.Trim(' ');
            string[] commandFirst = command.Split(ArgumentsDelimiter);

            long[] args = new long[2];

            if (commandFirst[0].Equals("add") ||
                commandFirst[0].Equals("subtract") ||
                commandFirst[0].Equals("multiply"))
            {
                string[] stringParams = line.Split(ArgumentsDelimiter);
                args[0] = long.Parse(stringParams[1]);
                args[1] = long.Parse(stringParams[2]);
                string action = stringParams[0];

                array = PerformAction(array, action, args);
            }
            else
            {
                string action = line;
                array = PerformAction(array, action, args);
            }

            PrlongArray(array);
            Console.Write('\n');

            command = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] arr, string action, long[] args)
    {
        long[] array = arr.Clone() as long[];
        long pos = args[0] - 1;
        long value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                array = ArrayShiftLeft(array);
                break;
            case "rshift":
                array = ArrayShiftRight(array);
                break;
        }

        return array;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        var lastItem = array[array.Length - 1];
        for (long i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = lastItem;
        return array;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        var firstItem = array[0];
        for (long i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = firstItem;
        return array;
    }

    private static void PrlongArray(long[] array)
    {
        for (long i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
