using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.erectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeight = double.Parse(Console.ReadLine());

            double rectanglePerimeter = 2 * (rectangleHeight + rectangleWidth);
            double rectangleArea = rectangleWidth * rectangleHeight;
            double diagonalSetup = Math.Pow(rectangleHeight, 2) + Math.Pow(rectangleWidth, 2);
            double rectangleDiagonal = Math.Sqrt(diagonalSetup);

            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonal);

        }
    }
}
