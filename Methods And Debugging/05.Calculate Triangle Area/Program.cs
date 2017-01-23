namespace _05.Calculate_Triangle_Area
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, height);

            Console.WriteLine(area);
        }

        public static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;

        }
    }
}
