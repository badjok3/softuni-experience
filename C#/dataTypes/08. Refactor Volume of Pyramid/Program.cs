using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.refractorVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = (width*height*length) /3;
            Console.WriteLine($"Pyramid Volume: {volume:F2}");

        }
    }
}
