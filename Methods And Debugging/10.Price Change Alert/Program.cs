namespace _10.Price_Change_Alert
{
    using System;

    public class PriceChangeAlert
    {
        public static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentStockPrice = double.Parse(Console.ReadLine());
                double currentDifference = GetPercentage(lastPrice, currentStockPrice);
                bool significantDifference = hasSignificantDifference(currentDifference, significanceThreshold);
                string message = GetDifference(currentStockPrice, lastPrice, currentDifference, significantDifference);
                Console.WriteLine(message);

                lastPrice = currentStockPrice;
            }
        }

        private static string GetDifference(double currentStockPrice, double lastPrice, double difference, bool hasSignificantDifference)
        {
            string typeOfChange = string.Empty;
            if (difference == 0)
            {
                typeOfChange = string.Format("NO CHANGE: {0}", currentStockPrice);
            }
            else if (!hasSignificantDifference)
            {
                typeOfChange = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentStockPrice, difference);
            }
            else if (hasSignificantDifference && (difference > 0))
            {
                typeOfChange = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentStockPrice, difference);
            }
            else if (hasSignificantDifference && (difference < 0))
            {
                typeOfChange = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentStockPrice, difference);
            }

            return typeOfChange;
        }

        private static bool hasSignificantDifference(double significanceThreshold, double difference)
        {
            if (Math.Abs(significanceThreshold + difference) >= 10)
            {
                return true;
            }

            return false;
        }

        private static double GetPercentage(double lastPrice, double currentStockPrice)
        {
            double result = (currentStockPrice - lastPrice) / (lastPrice / 100);
            return result;
        }
    }
}
