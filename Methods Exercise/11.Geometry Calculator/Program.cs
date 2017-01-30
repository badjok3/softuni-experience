namespace _11.Geometry_Calculator
{
    using System;
    using System.Numerics;

    public class GeometryCalculator
    {
       public static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type=="triangle")
            {
                double result = GetTriangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine($"{result:f2}");
            }

            else if (type=="circle")
            {
                double result = GetCircle(double.Parse(Console.ReadLine()));
                Console.WriteLine($"{result:f2}");
            }

            else if (type=="square")
            {
                double result = GetSquare(double.Parse(Console.ReadLine()));
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                double result = GetRectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine($"{result:f2}");
            }
        }
        
        public static double GetTriangle(double side, double height)
        {
            return (side * height) / 2;
        }

        public static double GetSquare(double side)
        {
            return side * side;
        }
        
        public static double GetRectangle(double width, double height)
        {
            return width * height;
        }

        public static double GetCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
