namespace _02.Base_N_to_Base_10
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Numerics;

   public class BaseNToBase10
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            var number = BigInteger.Parse(input[1]);
            var baseNumber = int.Parse(input[0]);

            var result = ConvertFromBaseNToDecimal(number, baseNumber);
            Console.WriteLine(result);
        }

        public static BigInteger ConvertFromBaseNToDecimal(BigInteger number, int baseNumber)
        {
            var numberAsString = number.ToString();
            BigInteger sum = 0;
            for (int power = 0; power < numberAsString.Length; power++)
            {
                var num = int.Parse(numberAsString[numberAsString.Length - 1 - power].ToString());
                sum += num * BigInteger.Pow(baseNumber, power);
            }

            return sum;
        }
    }
}
