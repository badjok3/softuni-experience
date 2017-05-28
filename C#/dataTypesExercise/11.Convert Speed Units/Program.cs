using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.convertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float time = (hours + minutes/60.0f + seconds / 3600.0f);

            float kilometersPerHour = (meters / 1000.0f) / time;
            float metersPerSecond = kilometersPerHour/3.6f;
            float milesPerHour = (meters / 1609.0f) / time;

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
