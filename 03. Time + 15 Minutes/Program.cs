using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chas = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
             min = min + 15;
            if (min >= 60)
            {
                min = min - 60;
                chas += 1;
            }
            if(chas==24)
            {
                chas = 0;
            }
            if(min<10)
            {
                Console.WriteLine($"{chas}:0{min}");
            }
            else
            {
                Console.WriteLine($"{chas}:{min}");
            }
        }
    }
}
