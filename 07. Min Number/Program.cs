using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();
            while(input!="Stop")
            {
                int currentNumber = int.Parse(input);
                if (currentNumber < minNumber) 
                {
                    minNumber=currentNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
