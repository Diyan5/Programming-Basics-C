using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grupi = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 1; i<=grupi;i++)
            {
                int broiZaEdnaGrupa = int.Parse(Console.ReadLine());
                if(broiZaEdnaGrupa<=5)
                {
                    p1 += broiZaEdnaGrupa;
                }
                else if (broiZaEdnaGrupa >= 6 && broiZaEdnaGrupa<=12)
                {
                    p2 += broiZaEdnaGrupa;
                }
                else if (broiZaEdnaGrupa >= 13&& broiZaEdnaGrupa<=25)
                {
                    p3 += broiZaEdnaGrupa;
                }
                else if (broiZaEdnaGrupa >= 26 && broiZaEdnaGrupa<=40)
                {
                    p4 +=broiZaEdnaGrupa;
                }
                else if(broiZaEdnaGrupa>=41)
                {
                    p5 += broiZaEdnaGrupa;
                }
            }
            double a = p1 + p2 + p3 + p4 + p5;
            Console.WriteLine($"{(p1*100/(a)):f2}%");
            Console.WriteLine($"{(p2 * 100 / (a)):f2}%");
            Console.WriteLine($"{(p3 * 100 / (a)):f2}%");
            Console.WriteLine($"{(p4 * 100 / (a)):f2}%");
            Console.WriteLine($"{(p5 * 100 / (a)):f2}%");
        }
    }
}
