using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broiTurniri = int.Parse(Console.ReadLine());
            int nachalenBroiTochki = int.Parse(Console.ReadLine());
            int finaelniTochki = 0;
            double count = 0;
            for(int i=1;i<=broiTurniri; i++)
            {
                string turnir = Console.ReadLine();
                if(turnir=="W")
                 {
                    finaelniTochki += 2000;
                    count++;
                  }
            else if (turnir == "F")
                 {
                    finaelniTochki += 1200;
                }
            else if (turnir == "SF")
                 {
                    finaelniTochki += 720;
                }
             }
            double avarageTochki = finaelniTochki / broiTurniri;
            double sum = finaelniTochki + nachalenBroiTochki;
            double a = (count* 100)/broiTurniri;
            Console.WriteLine($"Final points: {sum}\r\nAverage points: {Math.Floor(avarageTochki)}\r\n{a:f2}%");
        }
    }
}
