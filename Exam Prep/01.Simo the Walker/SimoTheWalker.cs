namespace _01.Simo_the_Walker
{
    using System;
    using System.Globalization;

    public class SimoTheWalker
    {
       public static void Main()
        {
            var leaveTime = DateTime.ParseExact(Console.ReadLine(), "H:m:s", CultureInfo.InvariantCulture);
            var stepsTaken = int.Parse(Console.ReadLine()) % 86400;
            var eachStepTime = int.Parse(Console.ReadLine()) % 86400;

            var timeTaken = stepsTaken * eachStepTime;
            leaveTime = leaveTime.AddSeconds(timeTaken);

            Console.WriteLine($"Time Arrival: {leaveTime.ToString("HH:mm:ss")}");
        }
    }
}
