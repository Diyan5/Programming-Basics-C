using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broiTabove = int.Parse(Console.ReadLine());
            double zaplata = double.Parse(Console.ReadLine());
            for(int i=1;i<=broiTabove;i++)
            {
                string name = Console.ReadLine();
                if (name == "Facebook")
                {
                    zaplata -= 150;
                }
                else if(name=="Instagram")
                {
                    zaplata -= 100;
                }
                else if(name=="Reddit")
                {
                    zaplata -= 50;
                }
            }
            if(zaplata<=0)
            {
                Console.WriteLine($"You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(zaplata)}");
            }
        }
    }
}
