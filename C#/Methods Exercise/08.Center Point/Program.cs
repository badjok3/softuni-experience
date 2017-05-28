namespace _08.Center_Point
{
    using System;

   public class ClosestPoint
    {
       public static void Main(string[] args)
        {
            double firstCoordinatesX2 = double.Parse(Console.ReadLine());
            double firstCoordinatesY2 = double.Parse(Console.ReadLine());
            double firstRadius = GetRadius(firstCoordinatesX2, firstCoordinatesY2);

            double secondCoordinatesX2 = double.Parse(Console.ReadLine());
            double secondCoordinatesY2 = double.Parse(Console.ReadLine());
            double secondRadius = GetRadius(secondCoordinatesX2, secondCoordinatesY2);
            
            if (firstRadius <= secondRadius)
            {
                Console.WriteLine($"({firstCoordinatesX2}, {firstCoordinatesY2})");
            }
            else
            {
                Console.WriteLine($"({secondCoordinatesX2}, {secondCoordinatesY2})");
            }
        }

        public static double GetRadius(double x2, double y2)
        {
            int x1 = 0;
            int y1 = 0;

            return Math.Abs((x2 - x1)) + Math.Abs((y2 - y1));
        }
    }
}
