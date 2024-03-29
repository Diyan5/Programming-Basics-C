﻿using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;
            double p5 = 0.00;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
            }
            Console.WriteLine($"{(p1 * 100 / n):f2}%");
            Console.WriteLine($"{(p2 * 100 / n):f2}%");
            Console.WriteLine($"{(p3 * 100 / n):f2}%");
            Console.WriteLine($"{(p4 * 100 / n):f2}%");
            Console.WriteLine($"{(p5 * 100 / n):f2}%");
            
        }
    }
}
