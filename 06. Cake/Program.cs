using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shirina = int.Parse(Console.ReadLine());
            int duljina = int.Parse(Console.ReadLine());
            int sum = shirina * duljina;
            while(sum>0)
            {
                string command = Console.ReadLine();
                if(command =="STOP")
                {
                    Console.WriteLine($"{sum} pieces are left.");
                    break;
                }
                else
                {
                    int parcheta = int.Parse(command );
                    sum -= parcheta;
                }
               
            }
            if(sum<=0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs (sum) } pieces more."); 
            }
        }
    }
}
