using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flavour = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());
            double sum = 0.00;
            double otstupka = 0.00;
          
            switch(flavour)
            {
                case "Roses":
                    sum = count * 5;
                    if(count>80)
                    {
                        otstupka = sum * 0.1;
                        sum = sum - otstupka;
                    }
                    break;
                case "Dahlias":
                    sum = count * 3.80;
                    if (count > 90)
                    {
                        
                        otstupka = sum * 0.15;
                        sum = sum - otstupka;
                    }
                    break;
                case "Tulips":
                    sum = count * 2.80;
                    if (count > 80)
                    {
                        
                        otstupka = sum * 0.15;
                        sum = sum - otstupka;
                    }
                    break;
                case "Narcissus":
                    sum = count * 3;
                    if(count<120)
                    {
                        
                        otstupka = sum * 0.15;
                        sum = sum + otstupka;
                    }
                    break;
                case "Gladiolus":
                    sum = count * 2.5;
                    if (count < 80)
                    {
                 
                        otstupka = sum * 0.2;
                        sum = sum + otstupka;
                    }
                    break;
            }
            if(budjet>=sum)
            {
                double a = budjet - sum;
                Console.WriteLine($"Hey, you have a great garden with {count} {flavour} and {a:f2} leva left.");
            }
            else
            {
                double a = sum - budjet;
                Console.WriteLine($"Not enough money, you need {a:f2} leva more.");

            }
        }
    }
}
