using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double tochki = double.Parse(Console.ReadLine());
            int broiOcenqvashti = int.Parse(Console.ReadLine());
            for(int i=1;i<=broiOcenqvashti; i++)
            {
                string ocenqwashtiq = Console.ReadLine();
                double tochkiOcenqwashtiq = double.Parse(Console.ReadLine());
                int nameOcenqwashtiq = ocenqwashtiq.Length;
                tochki += ((nameOcenqwashtiq * tochkiOcenqwashtiq) / 2);
                if(tochki>=1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {(tochki):f1}!");
                    break;
                }
            }
            if(tochki<1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {(1250.5-tochki):f1} more!");
            }
        }
    }
}
