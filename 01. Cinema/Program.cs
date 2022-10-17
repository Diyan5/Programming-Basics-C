using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double income = 0.00;
            switch(projection)
            {
                case "Premiere":
                    income = r * c * 12;
                    break;
                case "Normal":
                    income = r * c * 7.50;
                    break;
                case "Discount":
                    income = r * c * 5;
                    break;
                    
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
