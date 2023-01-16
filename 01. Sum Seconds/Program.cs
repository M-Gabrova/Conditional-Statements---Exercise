using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int sumseconds = one + two + three;  
            int minutes = sumseconds / 60;
            int seconds = sumseconds%60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else 
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
          
    }
}
