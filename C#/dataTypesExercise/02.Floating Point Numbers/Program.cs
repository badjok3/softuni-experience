using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.floatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal firstNumber = decimal.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            decimal thirdNumber = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0}", firstNumber);
            Console.WriteLine("{0}", secondNumber);
            Console.WriteLine("{0}", thirdNumber);

        }
    }
}
