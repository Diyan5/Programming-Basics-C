using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            
            int counter = 0;
            bool isBookFounf = false;
            string nextBookName = Console.ReadLine();
            
            while(nextBookName  != "No More Books")
            {
                 
                if (favouriteBook == nextBookName )
                {
                    isBookFounf = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
                
            }
            if (isBookFounf)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!\r\nYou checked {counter} books.");
            }
        }
                
    }
}
