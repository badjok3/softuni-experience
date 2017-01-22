using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = Console.ReadLine();
            string world = Console.ReadLine();

            object helloWorld = hello + " " + world;

            Console.WriteLine(helloWorld);
        }
    }
}
