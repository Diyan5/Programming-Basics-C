using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shirina = double.Parse(Console.ReadLine());
            double duljina = double.Parse(Console.ReadLine());
            double vissochina = double.Parse(Console.ReadLine());
            double cubm = Math.Floor(shirina * duljina * vissochina);
            while(cubm >0)
            {
                string command = Console.ReadLine();
                if(command == "Done")
                {
                    Console.WriteLine($"{cubm} Cubic meters left.");
                    break;
                }
                else
                {
                    int cubmk = int.Parse(command);
                    cubm -= cubmk;
                }
            }
            if(cubm<=0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs (cubm)} Cubic meters more.");
            }
        }
    }
}
