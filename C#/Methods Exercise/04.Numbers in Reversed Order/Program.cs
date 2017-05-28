namespace _04.Numbers_in_Reversed_Order
{
    using System;

   public class NumbersInReversedOrder
    {
       public static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = ReverseNumber(number);

            Console.WriteLine(result);
        }

        public static string ReverseNumber(string number)
        {
            char[] charArray = number.ToCharArray();
            string reverse = string.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reverse += charArray[i];
            }

            return reverse;
        }
    }
}
