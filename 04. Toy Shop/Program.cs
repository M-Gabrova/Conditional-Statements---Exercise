using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int toy1 = int.Parse(Console.ReadLine());
            int toy2 = int.Parse(Console.ReadLine());
            int toy3 = int.Parse(Console.ReadLine());
            int toy4 = int.Parse(Console.ReadLine());
            int toy5 = int.Parse(Console.ReadLine());
            int sumtoys = toy1+ toy2+toy3+toy4+toy5;
            double sumtoyprice = toy1 * 2.6 +toy2 * 3 +toy3 * 4.1 +toy4 * 8.2 +toy5 * 2;
            if (sumtoys >= 50)
            {
                sumtoyprice -= sumtoyprice*0.25;
            }
            sumtoyprice -= sumtoyprice * 0.10;
                       
            if (sumtoyprice >= trip)
            {
                Console.WriteLine($"Yes! {sumtoyprice-trip:f2} lv left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! {trip-sumtoyprice:f2} lv needed.");
            }
        }
    }
}
