using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.exchangeVarValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstVariable = int.Parse(Console.ReadLine());
            var secondVariable = int.Parse(Console.ReadLine());
            var transferVariable = 0;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", firstVariable);
            Console.WriteLine("b = {0}", secondVariable);

            transferVariable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = transferVariable;

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", firstVariable);
            Console.WriteLine("b = {0}", secondVariable);
        }
    }
}
