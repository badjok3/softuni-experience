using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.hexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexdecimal = Console.ReadLine();
            int decmialNumber = Convert.ToInt32(hexdecimal, 16);

            Console.WriteLine(decmialNumber);
        }
    }
}
