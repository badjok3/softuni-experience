namespace _09.Index_Of_Letters
{
    using System;
    using System.Linq;

   public class IndexOfLetters
    {
       public static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            GetIndex(letter);
        }

        public static void GetIndex(string letters)
        {
            var characters = letters.ToCharArray();
            
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine($"{characters[i]} -> {characters[i] - 'a'}");
            }
        }
    }
}
