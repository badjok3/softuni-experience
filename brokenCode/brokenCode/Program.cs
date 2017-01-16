using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {

        var startdate = Console.ReadLine();
        var enddate = Console.ReadLine();

        var startDate = DateTime.ParseExact(startdate,
            "dd.MM.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(enddate,
            "dd.MM.yyyy", CultureInfo.InvariantCulture);

        var holidaysCount = 0;


        for (var date = startDate; date <= endDate; date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        }
        Console.WriteLine(holidaysCount);
    }
}
