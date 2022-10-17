using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dpSuma = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double lihva = dpSuma * procent / 100;
            double mesec = lihva / 12;
            double krai = dpSuma + srok * mesec;
            Console.WriteLine(krai);
        }
    }
}
