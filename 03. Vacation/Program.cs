using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double totalMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;
            while(true)
            {
                string command = Console.ReadLine();
                double currentMoney =double.Parse(Console.ReadLine());
                daysCounter++;
                if(command =="spend")
                {
                    spendingCounter++;
                    totalMoney -= currentMoney;
                    if(totalMoney <0)
                    {
                        totalMoney = 0;
                    }
                    if(spendingCounter ==5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(daysCounter);
                        break;
                    }
                    
                }
                else if (command == "save")
                {
                    spendingCounter = 0;
                    totalMoney += currentMoney;
                    if(totalMoney >=tripPrice )
                    {
                        Console.WriteLine($"You saved the money for {daysCounter } days.");
                        break;
                    }
                }
            }
           
        }
    }
}
