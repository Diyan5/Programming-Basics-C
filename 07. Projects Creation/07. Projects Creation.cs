using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int broiProekti = int.Parse(Console.ReadLine());
            int edinProekt = 3;
            int rezultat = broiProekti * edinProekt;
            Console.WriteLine($"The architect {name} will need {rezultat} hours to complete {broiProekti} project/s.");
        }
    }
}
