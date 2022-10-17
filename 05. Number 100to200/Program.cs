using System;

namespace _05._Number_100to200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
//            под 100 отпечатайте: "Less than 100"

//· между 100 и 200 отпечатайте: "Between 100 and 200"

//· над 200 отпечатайте: "Greater than 200
         if( a < 100)
            {
                Console.WriteLine("Less than 100");
            }
         else if ( a >=100 && a<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
     else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
