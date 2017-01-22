using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.thePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesTaken = int.Parse(Console.ReadLine());
            int secondsToFilter = int.Parse(Console.ReadLine());
            double goodPicturesPercent = double.Parse(Console.ReadLine()) / 100;
            int uploadTimePerPicture = int.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(picturesTaken * goodPicturesPercent);
            double timeForFilter = picturesTaken * secondsToFilter;
            double totalSeconds = (filteredPictures * uploadTimePerPicture) + timeForFilter;
            
            double minutes = 0;
            while (totalSeconds >= 60)
            {
                totalSeconds -= 60;
                minutes++;
            }

            double hours = 0;
            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }

            double days = 0;
            while (hours >= 24)
            {
                hours -= 24;
                days++;
            }

            Console.Write($"{days}:");
            if (hours <= 9)
            {
                Console.Write($"0{hours}:");
            }
            else
            {
                Console.Write($"{hours}:");
            }
            if (minutes <= 9)
            {
                Console.Write($"0{minutes}:");
            }
            else
            {
                Console.Write($"{minutes}:");
            }
            if (totalSeconds <= 9)
            {
                Console.Write($"0{totalSeconds}");
            }
            else
            {
                Console.Write($"{totalSeconds}");
            }

        }
    }
}
