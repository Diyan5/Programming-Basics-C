using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            if (oddSum == evenSum)
            { 
            Console.WriteLine($"Yes\r\nSum = {evenSum}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(evenSum-oddSum)}");
            }
        }
    }
}
