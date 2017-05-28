namespace _01.Hello__Name
{
    using System;

    public class SayHi
    {
        public static void Main(string[] args)
        {
            string yourName = Console.ReadLine();
            string sayHi = SayHello(yourName);

            Console.WriteLine(sayHi);
        }

        public static string SayHello(string name)
        {
            return "Hello, " + name + "!";
        }
    }
}
