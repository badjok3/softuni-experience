using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.refractorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= startingNumber; currentNumber++)
            {
                bool isSpecial = false;


                int firstDigit = currentNumber % 10;
                int secondDigit = currentNumber / 10;
                int total = firstDigit + secondDigit;

                if ((total == 5) || (total == 7) || (total == 11))
                    isSpecial = true;

                Console.WriteLine($"{currentNumber} -> {isSpecial}");

            }

        }
    }
}
