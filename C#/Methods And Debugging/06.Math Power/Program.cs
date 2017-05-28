namespace _06.Math_Power
{
    using System;

    public class MathPower
    {
        public static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(Power(baseNum, pow));
        }

        public static double Power(double baseNumber, int power)
        {
            double result = 1;

            for (double i = 0; i < power; i++)
            {
                result *= baseNumber;
            }

            return result;
        }
    }
}
