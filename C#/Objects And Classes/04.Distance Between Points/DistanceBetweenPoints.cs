namespace _04.Distance_Between_Points
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPair = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point p1 = new Point
            {
                X = firstPair[0],
                Y = firstPair[1]
            };
            var secondPair = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point p2 = new Point
            {
                X = secondPair[0],
                Y = secondPair[1]
            };

            Console.WriteLine("{0:f3}", CalcDistance(p1, p2));
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var result = Math.Pow(a, 2) + Math.Pow(b, 2);

            return Math.Sqrt(result);
        }
    }
}
