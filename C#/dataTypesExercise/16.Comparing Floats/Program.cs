using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.comparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal differenceAllowed = 0.000001m;
            bool isEqual = false;

            if (Math.Abs(firstNumber-secondNumber) < differenceAllowed)
            {
                isEqual = true;
            }

            Console.WriteLine(isEqual);
        }
    }
}
