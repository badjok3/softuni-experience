namespace _03.Last_Digit_In_English
{
    using System;

    public class LastDigitInEnglish
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long lastDigit = GetLastDigit(number);

            switch (lastDigit)
            {
                case 1:
                    {
                        Console.WriteLine("one");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("two");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("three");
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("four");
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("five");
                        break;
                    }

                case 6:
                    {
                        Console.WriteLine("six");
                        break;
                    }

                case 7:
                    {
                        Console.WriteLine("seven");
                        break;
                    }

                case 8:
                    {
                        Console.WriteLine("eight");
                        break;
                    }

                case 9:
                    {
                        Console.WriteLine("nine");
                        break;
                    }

                case 0:
                    {
                        Console.WriteLine("zero");
                        break;
                    }
            }
        }

        public static long GetLastDigit(long number)
        {
            long result = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                result = digit;
            }

            return result;

        }
    }
}
