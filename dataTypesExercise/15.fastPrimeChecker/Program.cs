using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.fastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = 0; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;
                for (int primeChecker = 2; primeChecker <= Math.Sqrt(currentNumber); primeChecker++)
                {
                    if (currentNumber % primeChecker == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (currentNumber>1)
                {
                Console.WriteLine($"{currentNumber} -> {isPrime}");

                }
            }


        }
    }
}
