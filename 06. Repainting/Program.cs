using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.Необходимо количество найлон(в кв.м.) -цяло число в интервала[1... 100]

            //2.Необходимо количество боя(в литри) -цяло число в интервала[1…100]

            //3.Количество разредител(в литри) - цяло число в интервала[1…30]

            //4.Часовете, за които майсторите ще свършат работата -цяло число в интервала[1…9]
            int nailon= int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razreditel= int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());
            double cenaNailon = 1.50;
            double cenaBoq = 14.50;
            int cenaRazreditel = 5;
            //Сума за найлон: (10 + 2) * 1.50 = 18 лв.
            //Сума за боя: (11 + 10 %) * 14.50 = 175.45 лв.
            //Сума за разредител: 4 * 5.00 = 20.00 лв.
            //Сума за торбички: 0.40 лв.
            double vsichko = (nailon + 2) * 1.50 + (boq + boq *0.10 ) * 14.50 + razreditel * 5 + 0.4;
            double maistori = ((vsichko * 30) / 100) * chasove;
            double sum = vsichko + maistori;
            Console.WriteLine(sum);
        }
    }
}
