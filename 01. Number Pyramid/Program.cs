using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for(int i=1;i<=n; i++)
            {
                for(int a=1;a<=i;a++)
                {
                    if(current >n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if(isBigger )
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
