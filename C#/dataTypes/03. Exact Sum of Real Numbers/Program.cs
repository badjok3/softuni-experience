using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());

            decimal result = 0;

            for (int i = 0; i < totalNumbers; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                result += currentNumber;
            }

            Console.WriteLine(result);
        }
    }
}
