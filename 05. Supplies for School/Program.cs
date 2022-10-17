using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int himikali = int.Parse(Console.ReadLine());
            int markeri = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            int procent = int.Parse(Console.ReadLine());
            double paketHimikali = 5.80;
            double paketMarkeri = 7.20;
            double paketPreparati = 1.20;
            double sum = himikali * paketHimikali + markeri * paketMarkeri + preparat * paketPreparati;
            double krai = sum - (sum * procent / 100);
            Console.WriteLine(krai);
        }
    }
}
