namespace _01.Count_Working_Days
{
    using System;
    using System.Linq;
    using System.Globalization;

    public class CountWorkingDays
    {
        public static void Main()
        {
            var firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);



            var workingDays = 0;
            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                DateTime currentDate = i;

                var holidays = new DateTime[]
                {
                new DateTime(currentDate.Year, 01, 01),
                new DateTime(currentDate.Year, 03, 03),
                new DateTime(currentDate.Year, 05, 01),
                new DateTime(currentDate.Year, 05, 06),
                new DateTime(currentDate.Year, 05, 24),
                new DateTime(currentDate.Year, 09, 06),
                new DateTime(currentDate.Year, 09, 22),
                new DateTime(currentDate.Year, 11, 1),
                new DateTime(currentDate.Year, 12, 24),
                new DateTime(currentDate.Year, 12, 25),
                new DateTime(currentDate.Year, 12, 26)
                };

                if (i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday && !holidays.Contains(i))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
