namespace _07.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
       public static void Main()
        {
            var numberOfCities = int.Parse(Console.ReadLine());
            var result = new List<Sales>();

            for (int i = 0; i < numberOfCities; i++)
            {
                var currentCity = Console.ReadLine().Split(' ');
                var currentSale = new Sales();
                currentSale.Town = currentCity[0];
                if (result.Any(x=> x.Town == currentSale.Town))
                {
                    currentSale = result.First(x => x.Town == currentSale.Town);
                    currentSale.Sum += double.Parse(currentCity[2]) * double.Parse(currentCity[3]);
                }

                else
                {
                    currentSale.Sum = double.Parse(currentCity[2]) * double.Parse(currentCity[3]);
                    result.Add(currentSale);
                }

            }

            foreach (var sale in result.OrderBy(x=> x.Town))
            {
                Console.WriteLine($"{sale.Town} -> {sale.Sum:f2}");
            }
        }
    }
}
