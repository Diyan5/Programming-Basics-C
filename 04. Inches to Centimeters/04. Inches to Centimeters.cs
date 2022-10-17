using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double inch = 2.54;
            double izhod = a * inch;
            Console.WriteLine(izhod);

        }
    }
}
