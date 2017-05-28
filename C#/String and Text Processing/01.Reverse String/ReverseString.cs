namespace _01.Reverse_String
{
    using System;

    public class ReverseString
    {
       public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            var result = string.Empty;

            for (int i = text.Length - 1; i > -1; i--)
            {
                result += (text[i]);
            }

            Console.WriteLine(result);
        }
    }
}
