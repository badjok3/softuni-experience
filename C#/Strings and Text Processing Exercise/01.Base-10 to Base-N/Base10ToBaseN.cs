namespace _01.Base_10_to_Base_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Base10ToBaseN
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            var result = new StringBuilder();
            var firstnumber = line[0];
            var secondNumber = line[1];
            
            while (secondNumber > 0)
            {
                var baseNum = secondNumber % firstnumber;
                result.Append(baseNum);
                secondNumber = secondNumber / firstnumber;
            }

            char[] res = result.ToString().ToCharArray();
            var output = string.Empty;

            for (int i = res.Length - 1; i > -1; i--)
            {
                output += res[i];
            }

            Console.WriteLine(output);
        }
    }
}
