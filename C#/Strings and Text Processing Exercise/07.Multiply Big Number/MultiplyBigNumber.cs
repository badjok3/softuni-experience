namespace _07.Multiply_Big_Number
{
    using System;
    using System.Linq;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main()
        {

            var number = Console.ReadLine().TrimStart(new[] { '0' }).ToCharArray();
            var multiplier = int.Parse(Console.ReadLine());
            var aboveLimit = 0;
            var result = new StringBuilder();

            for (int i = 0; i < number.Length; i++)
            {

                var currentSum = int.Parse(number[number.Length - 1 - i].ToString()) * multiplier + aboveLimit;
                if (currentSum > 9)
                {
                    aboveLimit = currentSum / 10;
                    if (i < number.Length - 1)
                    {
                        result.Append(currentSum % 10);
                    }

                    else
                    {
                        result.Append(currentSum % 10);
                        var twoDigit = currentSum / 10;
                        result.Append(twoDigit % 10);
                        result.Append(twoDigit / 10);
                    }
                }

                else
                {
                    aboveLimit = 0;
                    result.Append(currentSum);
                }

            }

            var output = string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                output += result[result.Length - 1 - i];
            }

            Console.WriteLine(output.TrimStart(new[] { '0' }));
        }
    }
}