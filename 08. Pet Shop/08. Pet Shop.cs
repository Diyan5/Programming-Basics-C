using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            double a = 2.50;
            int cats = int.Parse(Console.ReadLine());
            int b = 4;
            double cena = dogs * 2.50 + cats * 4;
            Console.WriteLine($"{cena} lv."
            );
        }
    }
}
