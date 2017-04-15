using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picturesTaken = int.Parse(Console.ReadLine());
            var filterTime = double.Parse(Console.ReadLine());
            var filterFactor = double.Parse(Console.ReadLine()) / 100;
            var filterPerPicture = double.Parse(Console.ReadLine());

            var filtered = Math.Ceiling(picturesTaken * filterFactor) * filterPerPicture;
            var totalPictures = picturesTaken * filterTime;
            var totalSeconds = filtered + totalPictures;
            

            Console.WriteLine(TimeSpan.FromSeconds(totalSeconds).ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
