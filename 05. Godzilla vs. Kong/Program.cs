using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bfilm = double.Parse(Console.ReadLine());
            int bstatisti = int.Parse(Console.ReadLine());
            double cenazaStilist = double.Parse(Console.ReadLine());
            double sumazaObleklo = bstatisti * cenazaStilist;
            double sumazaDekor = bfilm * 0.1;
            if (bstatisti > 150)
            {
                sumazaObleklo = sumazaObleklo - (sumazaObleklo * 0.1);
            }
            double sum = sumazaDekor + sumazaObleklo;
            double krai = bfilm - sum;
            if(krai >=0)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {krai:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {-krai:f2} leva more.");
            }
        }

    }
}
