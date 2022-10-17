using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();
            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;
            while (nameOfMovie !="Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int counter = 0;
                while(freePlaces >counter)
                {
                    string typeOfTicket = Console.ReadLine();
                    if(typeOfTicket =="End")
                    {
                        break;
                    }
                    if(typeOfTicket =="student")
                    {
                        studentCounter++; 
                    }
                    else if(typeOfTicket =="standard")
                    {
                        standardCounter++; 
                    }
                    else if(typeOfTicket =="kid")
                    {
                        kidCounter++;
                    }
                    counter++;
                }
                double averagePlaces = counter * 100.0 / freePlaces;
                Console.WriteLine($"{nameOfMovie } - {averagePlaces:f2}% full.");
                nameOfMovie = Console.ReadLine(); 
            }
            int alltickets = studentCounter + standardCounter + kidCounter;
            double percentStudentTickets = (double) studentCounter / alltickets * 100;

            double perentStandartTickets = (double) standardCounter /alltickets * 100;
            
            double percentkidtickets = (double) kidCounter /alltickets * 100;
            Console.WriteLine($"Total tickets: {alltickets}");
            Console.WriteLine($"{percentStudentTickets :f2}% student tickets.");
            Console.WriteLine($"{perentStandartTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentkidtickets:f2}% kids tickets.");

        }
    }
}
