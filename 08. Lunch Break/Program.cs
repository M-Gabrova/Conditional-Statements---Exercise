using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = (Console.ReadLine());
            int episode = int.Parse(Console.ReadLine());
            int lunchbreak = int.Parse(Console.ReadLine());
            double timeForSeries = (double)lunchbreak*5.00/8.00;
 
            if (timeForSeries >= episode)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeForSeries-episode)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(episode-timeForSeries)} more minutes." );
            }
        }
    }
}
