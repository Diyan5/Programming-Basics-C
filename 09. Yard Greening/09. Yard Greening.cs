using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kvm = double.Parse(Console.ReadLine());
            double edinKvm = 7.61;
            double cena = kvm * edinKvm;
            double otstupka = cena * 0.18;
            double krainaCena = cena - otstupka;
            Console.WriteLine($"The final price is: {krainaCena} lv.");
            Console.WriteLine($"The discount is: {otstupka} lv.");

        }
    }
}
