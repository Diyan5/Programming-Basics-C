using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pileshko = int.Parse(Console.ReadLine());
            int riba = int.Parse(Console.ReadLine());
            int vegetariansko = int.Parse(Console.ReadLine());
            double cenaPileshko = 10.35 ;
            double cenaRiba =12.40 ;
            double cenaVegetariansko = 8.15;
            double obshtaCena = 10.35 * pileshko + 12.40 * riba + 8.15 * vegetariansko;
            double desert = obshtaCena * 0.2;
            double sum = obshtaCena + desert + 2.50;
            Console.WriteLine(sum);
        }
    }
}
