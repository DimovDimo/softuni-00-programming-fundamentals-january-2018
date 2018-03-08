using System;

class PriceChangeAlert
{
    static void Main()
    {
        int total = int.Parse(Console.ReadLine());
        double limit = double.Parse(Console.ReadLine());
        double previos = double.Parse(Console.ReadLine());

        for (int i = 0; i < total - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = CalculateDiffeens(previos, currentPrice);
            bool isSignificantDifference = IsSignificantDifference(difference, limit);
            string message = GetPercentageDifference(currentPrice, previos, difference, isSignificantDifference);
            Console.WriteLine(message);
            previos = currentPrice;
        }
    }

    private static string GetPercentageDifference(
        double currentPrice, 
        double previos, 
        double difference, 
        bool isSignificantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previos, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previos, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previos, currentPrice, difference * 100);
        }
            
        return message;
    }

    private static bool IsSignificantDifference(double limit, double isSignificantDifference)
    {
        if (Math.Abs(limit) >= Math.Abs(isSignificantDifference))
        {
            return true;
        }

        return false;
    }

    private static double CalculateDiffeens(double previos, double currentPrice)
    {
        return (currentPrice - previos) / previos;
    }
}
