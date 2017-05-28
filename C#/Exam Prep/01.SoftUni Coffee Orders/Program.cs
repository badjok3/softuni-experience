using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());

                var coffePrice = ((DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount) * pricePerCapsule);
                total += coffePrice;
                Console.WriteLine($"The price for the coffee is: ${coffePrice:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
