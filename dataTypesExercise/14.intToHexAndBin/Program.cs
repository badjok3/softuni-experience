using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.intToHexAndBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            string hexdecimal = Convert.ToString(integer, 16).ToUpper();
            string binary = Convert.ToString(integer, 2).ToUpper();

            Console.WriteLine(hexdecimal);
            Console.WriteLine(binary);
        }
    }
}
