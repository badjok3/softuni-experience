using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalPictures = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var procentGoodPictures = long.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            var usefulPictures = (long)Math.Ceiling((totalPictures) * ((double)procentGoodPictures / 100));

            var filteredSeconds = totalPictures * filterTime;
            var uploadSeconds = usefulPictures * uploadTime;

            var totalSeconds = filteredSeconds + uploadSeconds;

            Console.WriteLine(TimeSpan.FromSeconds(totalSeconds).ToString(@"d\:hh\:mm\:ss"));
        }
    }
}