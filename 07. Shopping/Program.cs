using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetPeter = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            int cardPrice = videoCard*250;
            double processorPrice = cardPrice*0.35*processor;
            double ramSum = cardPrice*0.10*ram;
            double sum = cardPrice + processorPrice + ramSum;

            if (videoCard > processor)
            {
                sum -= sum * 0.15;
            }
            if (budgetPeter >= sum)
            {
                Console.WriteLine($"You have {budgetPeter-sum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum-budgetPeter:f2} leva more!");
            }
        }
    }
}
