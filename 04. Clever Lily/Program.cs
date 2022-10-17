using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vuzrast = int.Parse(Console.ReadLine());
            double cenaPeralnq = double.Parse(Console.ReadLine());
            int cenaZaIgrachka = int.Parse(Console.ReadLine());
            
            int odd = 0;
            double spesteniPari = 0;
            for(int i=1;i<=vuzrast;i++)
            {
                if(i%2==0)
                {
                    spesteniPari += (i * 5);
                    spesteniPari--;
                }
                else
                {
                    odd++;
                }
                
                
            }
            spesteniPari += (odd * cenaZaIgrachka);
            if(spesteniPari>=cenaPeralnq)
            {
                Console.WriteLine($"Yes! {(spesteniPari-cenaPeralnq):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(cenaPeralnq-spesteniPari):f2}");
            }
        }
    }
}
