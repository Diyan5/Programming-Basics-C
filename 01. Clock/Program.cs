using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int firstNumber = 0; firstNumber <=23; firstNumber++)
            {
                for(int secondNumber=0;secondNumber <=59;secondNumber++)
                {
                    Console.WriteLine($"{firstNumber }:{secondNumber }"); 
                }
            }
        }
    }
}
