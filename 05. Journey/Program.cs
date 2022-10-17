using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double vacation = 0.00;
            string destination = "";
            string a = "";
            switch(season)
            {
                case "summer":
                    a = "Camp";
                    if(budjet<=100)
                    {
                        vacation = budjet * 0.3;
                        destination = "Bulgaria";
                        
                    }
                    else if(budjet<=1000)
                    {
                        vacation = budjet * 0.4;
                        destination = "Balkans";
                    }
                    else if (budjet>1000)
                    {
                        vacation = budjet * 0.9;
                        destination = "Europe";
                        a = "Hotel";
                    }
                    break;
                case "winter":
                    a = "Hotel";
                    if (budjet <= 100)
                    {
                        vacation = budjet * 0.7;
                        destination = "Bulgaria";
                    }
                    else if (budjet <= 1000)
                    {
                        vacation = budjet * 0.8;
                        destination = "Balkans";
                    }
                    else if (budjet > 1000)
                    {
                        vacation = budjet * 0.9;
                        destination = "Europe";
                    }
                    break;

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{a} - {vacation:f2}");
        }
    }
}
