using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var average = array.Average();
            var result = array.Where(t => t > average).OrderByDescending(x=> x).Take(5).ToArray();
            if (result.Count() > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
