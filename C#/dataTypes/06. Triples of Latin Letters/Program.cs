using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.triplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int firstChar = 0; firstChar < number; firstChar++)
            {
                for (int secondChar = 0; secondChar < number; secondChar++)
                {
                    for (int thirdChar = 0; thirdChar < number; thirdChar++)
                    {
                        Console.WriteLine($"{(char)('a' + firstChar)}{(char)('a' + secondChar)}{((char)('a' + thirdChar))} ");
                    }
                }
            }
        }
    }
}
