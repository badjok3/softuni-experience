namespace _09.Longer_Line
{
    using System;
    
    public class LongerLine
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstPairLength = LineLength(x1, y1, x2, y2);
            double secondPairLength = LineLength(x3, y3, x4, y4);
            string result = string.Empty;
            if (firstPairLength >= secondPairLength)
            {
                result = CloserToCenter(x1, y1, x2, y2);
                Console.WriteLine(result);
            }
            
            else
            {
                result = CloserToCenter(x3, y3, x4, y4);
                Console.WriteLine(result);
            }
        }
         
        public static string CloserToCenter(double x1, double y1, double x2, double y2)
        {
            string result = string.Empty;

            if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
            {
                result =  $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                result = $"({x2}, {y2})({x1}, {y1})";
            }

            return result;
        }

        public static double LineLength(double x1, double y1, double x2, double y2)
        {
            var xDifference = Math.Abs(x1 - x2);
            var yDiffrence = Math.Abs(y1 - y2);
            var line = Math.Sqrt(Math.Pow(xDifference, 2) + Math.Pow(yDiffrence, 2));
            return line;
        }
    }
}
