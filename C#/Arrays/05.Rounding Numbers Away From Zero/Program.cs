namespace _05.Rounding_Numbers_Away_From_Zero
{
    using System;

   public class RoundingNumbers
    {
       public static void Main(string[] args)
        {
            string values = Console.ReadLine();
            AwayFromZero(values);
        }

        public static double[] AwayFromZero(string values)
        {
            string[] parameters = values.Split(' ');
            double[] awayFromZero = new double[parameters.Length];
            double result = 0;
            for (int i = 0; i <= awayFromZero.Length-1; i++)
            {
                awayFromZero[i] = double.Parse(parameters[i]);
               
                    result = Math.Round(awayFromZero[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{parameters[i]} => {result}");
            }

            return awayFromZero;
        }
    }
}
