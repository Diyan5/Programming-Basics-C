using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double obem = duljina * shirina * visochina;
            double obemLitri = obem * 0.001;
            double prostranstvo = procent * 0.01;
            double sum = obemLitri * (1 - prostranstvo);
            Console.WriteLine(sum);
        }
    }
}
