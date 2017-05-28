using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.boolVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string trueOrFalse = Console.ReadLine();
            bool result = Convert.ToBoolean(trueOrFalse);

            if (result)
            {
            Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
