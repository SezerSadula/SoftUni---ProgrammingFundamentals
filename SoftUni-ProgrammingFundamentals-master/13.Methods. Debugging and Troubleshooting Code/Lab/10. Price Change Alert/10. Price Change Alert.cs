using System;

class PriceChangeAlert
{
    static void Main()
    {
        int prices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());


        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < prices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double priceDiff = PriceDiff(lastPrice, currentPrice);
            bool isSignificantDifference = IsSignificantDifference(priceDiff, threshold);
            string message = GetChangeEffectAsString(currentPrice, lastPrice, priceDiff, isSignificantDifference);

            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    static string GetChangeEffectAsString(double currentPrice, double lastPrice, double priceDiff, bool isSignificantDifference)
    {
        string to = "";

        if (priceDiff == 0)
        {
            to = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100.0d);
        }
        else if (isSignificantDifference && (priceDiff > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100.0d);
        }
        else if (isSignificantDifference && (priceDiff < 0))
        {
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100.0d);
        }

        return to;
    }

    static bool IsSignificantDifference(double priceDiff, double threshold)
    {
        if (Math.Abs(priceDiff) >= threshold)
        {
            return true;
        }

        return false;
    }

    static double PriceDiff(double lastPrice, double currentPrice)
    {
        return (currentPrice - lastPrice) / lastPrice;
    }
}
