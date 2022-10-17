using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int epizod = int.Parse(Console.ReadLine());
            int pochivka = int.Parse(Console.ReadLine());
            double obqd = pochivka * 0.125;
            double otdih = pochivka * 0.25;
            double a = pochivka - obqd - otdih;
            if(a>=epizod)
            {
                double b = a - epizod;
                Console.WriteLine($"You have enough time to watch {text} and left with {Math.Ceiling(b)} minutes free time.");
            }
            else
            {
                double b = epizod - a;
                Console.WriteLine($"You don't have enough time to watch {text}, you need {Math.Ceiling(b)} more minutes.");
            }
        }
    }
}
