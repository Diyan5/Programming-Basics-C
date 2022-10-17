using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string currentPassword = "";
            while(password !=currentPassword )
            {
                currentPassword = Console.ReadLine();
                
            }
            Console.WriteLine($"Welcome {name}!"); 
        }
    }
}
