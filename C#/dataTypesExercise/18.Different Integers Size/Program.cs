using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.differentIntSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger givenNumber = BigInteger.Parse(Console.ReadLine());

            if (givenNumber <= long.MaxValue)
            {

                Console.WriteLine($"{givenNumber} can fit in:");
                if (givenNumber <= sbyte.MaxValue && givenNumber >= sbyte.MinValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (givenNumber <= byte.MaxValue && givenNumber >= byte.MinValue)
                {
                    Console.WriteLine("* byte");
                }
                if (givenNumber <= short.MaxValue && givenNumber >= short.MinValue)
                {
                    Console.WriteLine("* short");
                }
                if (givenNumber <= ushort.MaxValue && givenNumber >= ushort.MinValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (givenNumber <= int.MaxValue && givenNumber >= int.MinValue)
                {
                    Console.WriteLine("* int");
                }
                if (givenNumber <= uint.MaxValue && givenNumber >= uint.MinValue)
                {
                    Console.WriteLine("* uint");
                }
                if (givenNumber <= long.MaxValue && givenNumber >= long.MinValue)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine($"{givenNumber} can't fit in any type");
            }

        }
    }
}