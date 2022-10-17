using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if(name == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double b = a * a;
                Console.WriteLine($"{b:f3}");
            }
            else if(name == "rectangle")
            {
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                double e = c * d;
                Console.WriteLine($"{e:f3}");
            }
            else if (name == "circle")
            {
                double f = double.Parse(Console.ReadLine());
                double g = Math.PI * f * f;
                Console.WriteLine($"{g:f3}");
            }
            else if (name == "triangle")
            {
                double h = double.Parse(Console.ReadLine());
                double m = double.Parse(Console.ReadLine());
                double n = (h * m) / 2;
                Console.WriteLine($"{n:f3}");

            }
        }
    }
}
