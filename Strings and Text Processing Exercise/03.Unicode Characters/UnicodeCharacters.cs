namespace _03.Unicode_Characters
{
    using System;
    using System.Text;

   public class UnicodeCharacters
    {
       public static void Main()
        {
            var line = Console.ReadLine().ToCharArray();

            foreach (var symbol in line)
            {
                Console.Write($"\\u{((int)symbol).ToString("x4")}");
            }
        }
    }
}
