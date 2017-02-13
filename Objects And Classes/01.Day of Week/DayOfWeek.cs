namespace _01.Day_of_Week
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

   public class DayOfWeek
    {
       public static void Main()
        {
            string date = Console.ReadLine();
            DateTime printDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(printDate.DayOfWeek);
        }
    }
}
