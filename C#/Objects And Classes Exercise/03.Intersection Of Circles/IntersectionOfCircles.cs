namespace _03.Intersection_Of_Circles
{
    using System;
    using System.Linq;

    public class IntersectionOfCircles
    {
        public static void Main()
        {
            var firstCircleParameters = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var secondCircleParameters = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Circle firstCircle = new Circle
            {
                CenterX = firstCircleParameters[0],
                CenterY = firstCircleParameters[1],
                Radius = firstCircleParameters[2]
            };

            Circle secondCircle = new Circle
            {
                CenterX = secondCircleParameters[0],
                CenterY = secondCircleParameters[1],
                Radius = secondCircleParameters[2]
            };

            if (Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            double distanceBetweenCircles = Math.Abs((c1.CenterX + c1.CenterY) - (c2.CenterX + c2.CenterY));
            if (distanceBetweenCircles <= c2.Radius + c1.Radius)
            {
                return true;
            }

            return false;
        }
    }
}
