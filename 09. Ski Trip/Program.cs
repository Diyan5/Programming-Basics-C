using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string pomeshtenie = Console.ReadLine();
            string ocenka = Console.ReadLine();
            double a = 0.00;
            switch(pomeshtenie)
            {
                case "room for one person":
                    a = (days - 1) * 18;
                    break;
                case "apartment":
                    
                    if (days < 10)
                    {
                        double b = (days - 1) * 25;
                        a = b - (b * 0.3);
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        double b = (days - 1) * 25;
                        a = b - (b * 0.35);
                    }
                    else if(days>15)
                    {
                        double b = (days - 1) * 25;
                        a = b - (b * 0.5);
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        double b = (days - 1) * 35;
                        a = b - (b * 0.1);
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        double b = (days - 1) * 35;
                        a = b - (b * 0.15);
                    }
                    else if (days > 15)
                    {
                        double b = (days - 1) * 35;
                        a = b - (b * 0.2);
                    }
                    break;
            }
            switch(ocenka)
            {
                case "positive":
                    a = a + (a * 0.25);
                    break;
                case "negative":
                    a = a - (a * 0.1);
                    break;
            }
            Console.WriteLine($"{a:f2}");
        }
    }
}
