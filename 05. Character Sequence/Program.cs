using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int Lenght = name.Length;
            for (int value=0; value<=name.Length-1;value++)
            {
                Console.WriteLine(name[value]);
            }
        }
    }
}
