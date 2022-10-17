using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ekskurziq = double.Parse(Console.ReadLine());
            int brp = int.Parse(Console.ReadLine());
            int brk= int.Parse(Console.ReadLine());
            int brm = int.Parse(Console.ReadLine());
            int brmm = int.Parse(Console.ReadLine());
            int brkk = int.Parse(Console.ReadLine());
            int broi = brp + brk + brm + brmm + brkk;
            double total = brp * 2.60 + brk * 3 + brm * 4.10 + brmm * 8.20 + brkk * 2;
            if (broi >= 50)
            {
                double krainaCena = total - (total * 0.25);
                double naem = krainaCena * 0.1;
                double pechalba = krainaCena - naem;
                double a = pechalba - ekskurziq;
                if(pechalba>=ekskurziq)
                {
                    Console.WriteLine($"Yes! {a:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {-a:f2} lv needed.");
                }
            }
            else
            {
                double naem = total * 0.1;
                double sum2 = total - naem;
                double b = sum2 - ekskurziq;
                if (sum2 >= ekskurziq)
                {
                    Console.WriteLine($"Yes! {b:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {-b:f2} lv needed.");
                }
            }
        }
    }
}
