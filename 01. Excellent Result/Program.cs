using System;

namespace _01._Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double otlichen = 5.5;
            double segashna = double.Parse(Console.ReadLine());
            bool isCorrect = segashna >= otlichen;
            if(isCorrect)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
