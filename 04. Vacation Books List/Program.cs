using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broiStranici = int.Parse(Console.ReadLine());
            int chas = int.Parse(Console.ReadLine());
            int broiDni = int.Parse(Console.ReadLine());
            int sum = broiStranici / chas;
            int krai = sum / broiDni;
            Console.WriteLine(krai);

        }
    }
}
