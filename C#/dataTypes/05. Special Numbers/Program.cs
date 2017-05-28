using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int firstDigit = i / 10;
                int secondDigit = i % 10;
                bool isSpecial = false;
                if (firstDigit+secondDigit == 5 || firstDigit+secondDigit == 7 || firstDigit+secondDigit == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");

            }
        }
    }
}
