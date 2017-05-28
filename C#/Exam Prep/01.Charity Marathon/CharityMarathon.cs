namespace _01.Charity_Marathon
{
    using System;

   public class CharityMarathon
    {
       public static void Main()
        {
            var marathonDays = decimal.Parse(Console.ReadLine());
            var numberOfRunners = decimal.Parse(Console.ReadLine());
            var averageLaps = decimal.Parse(Console.ReadLine());
            var trackLength = decimal.Parse(Console.ReadLine());
            var trackCapactiy = decimal.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            if (trackCapactiy * marathonDays < numberOfRunners)
            {
                numberOfRunners = trackCapactiy * marathonDays;
            }

            decimal totalKilometers = (numberOfRunners * averageLaps * trackLength) / 1000;
            Console.WriteLine($"Money raised: {totalKilometers * moneyPerKilometer:f2}");
        }
    }
}
