using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesCount = (int)Math.Ceiling((double)numberOfPeople / elevatorCapacity);

            Console.WriteLine($"{coursesCount}");
        }
    }
}
