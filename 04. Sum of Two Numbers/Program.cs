using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int endNuumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            bool hasMagicNumberBeenFound = false;
            for(int firstNumber=startingNumber;firstNumber<=endNuumber ;firstNumber++)
            {
                for(int secondnumber=startingNumber;secondnumber<=endNuumber;secondnumber++)
                {
                    combination++;
                    if(firstNumber +secondnumber ==magicNumber )
                    {
                        hasMagicNumberBeenFound = true;
                        Console.WriteLine($"Combination N:{combination } ({firstNumber } + {secondnumber } = {magicNumber})");
                        break;
                    }
                }
                if(hasMagicNumberBeenFound )
                {
                    break;
                }
            }
            if(!hasMagicNumberBeenFound)
            {
                Console.WriteLine($"{combination } combinations - neither equals {magicNumber }");
            }
        }
    }
}
