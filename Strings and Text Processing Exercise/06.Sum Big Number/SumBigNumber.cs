namespace _06.Sum_Big_Number
{
    using System;
    using System.Text;

    public class SumBigNumber
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart(new[] { '0' }).ToCharArray();
            var secondNumber = Console.ReadLine().TrimStart(new[] { '0' }).ToCharArray();
            var aboveLimit = 0;
            var result = new StringBuilder();

            for (int i = 0; i < Math.Max(firstNumber.Length, secondNumber.Length); i++)
            {
                if (i < Math.Min(firstNumber.Length, secondNumber.Length))
                {
                    var currentSum = int.Parse(firstNumber[firstNumber.Length - 1 - i].ToString()) + int.Parse(secondNumber[secondNumber.Length - 1 - i].ToString()) + aboveLimit;
                    if (currentSum > 9)
                    {
                        aboveLimit = 1;
                        if (i < Math.Max(firstNumber.Length, secondNumber.Length) - 1)
                        {
                            result.Append(currentSum - 10);
                        }

                        else
                        {
                            result.Append(currentSum % 10);
                            result.Append(currentSum / 10);
                        }
                    }

                    else
                    {
                        aboveLimit = 0;
                        result.Append(currentSum);
                    }

                   
                }

                else if (firstNumber.Length >= secondNumber.Length)
                {
                    var currentSum = int.Parse(firstNumber[firstNumber.Length - 1 - i].ToString()) + aboveLimit;
                    if (currentSum > 9)
                    {
                        aboveLimit = 1;
                        if (i < Math.Max(firstNumber.Length, secondNumber.Length) - 1)
                        {
                            result.Append(currentSum - 10);
                        }

                        else
                        {
                            result.Append(currentSum % 10);
                            result.Append(currentSum / 10);
                        }
                    }
                    else
                    {
                        aboveLimit = 0;
                        result.Append(currentSum);
                    }

                   
                }

                else
                {
                    var currentSum = int.Parse(secondNumber[secondNumber.Length - 1 - i].ToString()) + aboveLimit;
                    if (currentSum > 9)
                    {
                        aboveLimit = 1;
                        if (i < Math.Max(firstNumber.Length, secondNumber.Length) - 1)
                        {
                            result.Append(currentSum - 10);
                        }

                        else
                        {
                            result.Append(currentSum % 10);
                            result.Append(currentSum / 10);
                        }
                    }
                    else
                    {
                        aboveLimit = 0;
                        result.Append(currentSum);
                    }

                    
                }
            }

            var output = string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                output += result[result.Length - 1 - i];
            }

            Console.WriteLine(output);
        }
    }
}
