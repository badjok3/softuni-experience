using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.employeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalId = long.Parse(Console.ReadLine());
            long employeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalId);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
