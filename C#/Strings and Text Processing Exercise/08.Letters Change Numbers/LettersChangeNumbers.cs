namespace _08.Letters_Change_Numbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new decimal();

            for (int i = 0; i < line.Length; i++)
            {
                var parameters = line[i].ToCharArray();
                var digits = string.Empty;
                var firstChar = parameters[0];
                var lastChar = parameters[parameters.Length - 1];

                foreach (var symbol in parameters)
                {
                    if (Char.IsDigit(symbol))
                    {
                        digits += symbol;
                    }
                }

                var firstNumber = new decimal();
                var number = decimal.Parse(digits);
                if (firstChar.ToString().ToUpper() == firstChar.ToString())
                {
                    firstNumber = number / (firstChar - 'A' + 1);
                }

                else
                {
                    firstNumber = number * (firstChar - 'a' + 1);
                }

                if (lastChar.ToString().ToUpper() == lastChar.ToString())
                {
                    firstNumber -= (lastChar - 'A' + 1);
                }

                else
                {
                    firstNumber += (lastChar - 'a' + 1);
                }

                result += firstNumber;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
