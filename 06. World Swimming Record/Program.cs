using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double metri = double.Parse(Console.ReadLine());
            double vremesec = double.Parse(Console.ReadLine());
            double a = (Math.Floor(metri / 15)) * 12.5;
            double b = metri * vremesec;
            double c = a + b;
            if(record<=c)
            {
               double sum = c - record;
                Console.WriteLine($"No, he failed! He was {sum:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {c:f2} seconds.");
            }

        }
    }
}
