using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            double b = 0.00;
            string c = "";
            switch (a)
            {
                case "+":
                    b = N1 + N2;
                    if (b % 2 == 0)
                    {
                        c = "- even";
                    }
                    else
                    {
                        c = "- odd";
                    }
                    Console.WriteLine($"{N1} + {N2} = {b} {c} ");
                    break;
                case "-":
                    b = N1 - N2;
                    if (b % 2 == 0)
                    {
                        c = "- even";
                    }
                    else
                    {
                        c = "- odd";
                    }
                    Console.WriteLine($"{N1} - {N2} = {b} {c} ");
                    break;
                case "*":
                    b = N1 * N2;
                    if (b % 2 == 0)
                    {
                        c = "- even";
                    }
                    else
                    {
                        c = "- odd";
                    }
                    Console.WriteLine($"{N1} * {N2} = {b} {c} ");
                    break;
                case "/":
                    
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else {
                        b = (double)N1 / N2;
                        Console.WriteLine($"{N1} / {N2} = {b:f2}"); }
                    break;
                case "%":

                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        b = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {b}");
                    }
                    break;
            }
            
        }
    }
}
