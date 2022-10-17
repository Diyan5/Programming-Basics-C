using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxvalue = int.MinValue;
            for(int i=1;i<=n;i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number>maxvalue)
                {
                    maxvalue = number;
                }
                sum += number;
            }
            if(maxvalue * 2 ==sum)
            {
                Console.WriteLine($"Yes\r\nSum = {maxvalue}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(sum-2*maxvalue)}");
            }
        }
    }
}
