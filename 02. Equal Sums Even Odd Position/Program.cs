using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for(int i=start;i<= end;i++ )
            {
                string number = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for(int j=0;j<=number.Length; j++ )
                {
                    int currentDigit = int.Parse(number[j].ToString());
                    if(j%2==0)
                    {
                        oddSum += currentDigit; 
                    }
                    else
                    {
                        evenSum += currentDigit; 
                    }
                }
                if(oddSum ==evenSum )
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
