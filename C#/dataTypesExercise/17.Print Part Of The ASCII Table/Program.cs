using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.printPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoint = int.Parse(Console.ReadLine());
            int endingPoint = int.Parse(Console.ReadLine());

            for (int currentSymbol = startingPoint; currentSymbol <= endingPoint; currentSymbol++)
            {
                char symbol = (char)currentSymbol;
                char asciiSymbol = Convert.ToChar(symbol);

                Console.Write("{0} ",asciiSymbol);
            }
        }
    }
}
