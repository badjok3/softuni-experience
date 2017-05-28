namespace _10.Cube_Properties
{
    using System;

    public class CubeProperties
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if (type=="volume")
            {
                double result = GetVolume(number);
                Console.WriteLine($"{result:f2}");
            }
            else if (type=="area")
            {
                double result = GetArea(number);
                Console.WriteLine($"{result:f2}");
            }
            else if (type=="space")
            {
                double result = GetSpace(number);
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                double result = GetFace(number);
                Console.WriteLine($"{result:f2}");
            }
        }

        public static double GetFace(double number)
        {
            return Math.Sqrt((2 * number * number));
        }

        public static double GetSpace(double number)
        {
            return Math.Sqrt((3 * number * number));
        }

        public static double GetVolume(double number)
        {
            return number * number * number;
        }

        public static double GetArea(double number)
        {
            return 6 * number * number;
        }
    }
}
