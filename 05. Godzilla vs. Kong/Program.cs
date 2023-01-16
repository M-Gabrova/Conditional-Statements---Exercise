using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());
            double dekor = budget * 0.10;
            double clothessum = clothes*people;
            
            if (people > 150)
            {
                clothessum -= clothessum * 0.10;
            }
            double sum = clothessum + dekor ;
           
            if (sum >budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {sum - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - sum:f2} leva left.");
            }
        }
    }
}
