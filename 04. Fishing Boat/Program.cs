using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int ribari = int.Parse(Console.ReadLine());
            double naem = 0.00;
            switch(season)
            {
                case "Spring":
                    naem = 3000;
                    if(ribari<=6)
                    {
                        naem = naem - (naem * 0.1);
                    }
                    else if (ribari>=7 && ribari<=11)
                    {
                        naem = naem - (naem * 0.15);
                    }
                    else if(ribari>12)
                    {
                        naem = naem - (naem * 0.25);
                    }
                    if(ribari %2 == 0)
                    {
                        naem = naem - (naem * 0.05);
                    }
                    break;
                case "Summer":
                    naem = 4200;
                    if (ribari <= 6)
                    {
                        naem = naem - (naem * 0.1);
                    }
                    else if (ribari >= 7 && ribari <= 11)
                    {
                        naem = naem - (naem * 0.15);
                    }
                    else if (ribari > 12)
                    {
                        naem = naem - (naem * 0.25);
                    }
                    if (ribari % 2 == 0)
                    {
                        naem = naem - (naem * 0.05);
                    }
                    break;
                case "Autumn":
                    naem = 4200;
                    if (ribari <= 6)
                    {
                        naem = naem - (naem * 0.1);
                    }
                    else if (ribari >= 7 && ribari <= 11)
                    {
                        naem = naem - (naem * 0.15);
                    }
                    else if (ribari > 12)
                    {
                        naem = naem - (naem * 0.25);
                    }

                    break;
                case "Winter":
                    naem = 2600;
                    if (ribari <= 6)
                    {
                        naem = naem - (naem * 0.1);
                    }
                    else if (ribari >= 7 && ribari <= 11)
                    {
                        naem = naem - (naem * 0.15);
                    }
                    else if (ribari > 12)
                    {
                        naem = naem - (naem * 0.25);
                    }
                    if (ribari % 2 == 0)
                    {
                        naem = naem - (naem * 0.05);
                    }
                    break;
            }
            if(budjet>=naem)
            {
                double a = budjet - naem;
                Console.WriteLine($"Yes! You have {a:f2} leva left.");
            }
            else
            {
                double a = naem - budjet;
                Console.WriteLine($"Not enough money! You need {a:f2} leva.");
            }
        }
    }
}
