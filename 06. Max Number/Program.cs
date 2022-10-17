using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string name = Console.ReadLine();

            while (name != "Stop")
            {
                int n = int.Parse(name);
                if (n > maxNumber)
                {
                    maxNumber = n;
                }
                name = Console.ReadLine();

            }
            Console.WriteLine(maxNumber);
        }
    }
}
