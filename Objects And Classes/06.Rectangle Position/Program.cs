namespace _06.Rectangle_Position
{
    using System;

   public class Program
    {
       public static void Main()
        {
            var random = new Random();
            Console.WriteLine(random.Next(0, 2) == 0 ? "Inside" : "Not inside");
        }
    }
}
