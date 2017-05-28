using System;
namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = decimal.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berryPrice = decimal.Parse(Console.ReadLine());
            
            while (guests % 6 != 0)
            {
                guests ++;
            }

            var sets = guests / 6;
            var totalCost = (sets * (2 * bananaPrice)) + (sets * (4 * eggPrice)) + (sets * (0.2m * berryPrice));

            if (totalCost <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:f2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(cash - totalCost):f2}lv more.");
            }
        }
    }
}
