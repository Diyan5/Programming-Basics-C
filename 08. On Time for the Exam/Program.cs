using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int houronExam = int.Parse(Console.ReadLine());
            int minonExam = int.Parse(Console.ReadLine());
            int arrivalonExam = int.Parse(Console.ReadLine());
            int minArrivalonExam = int.Parse(Console.ReadLine());
            int examSuminMinutes = houronExam * 60 + minonExam;
            int arriveSuminMinutes = arrivalonExam * 60 +minArrivalonExam;
            if(arriveSuminMinutes>examSuminMinutes)
            {
                Console.WriteLine("Late");
                if(arriveSuminMinutes - examSuminMinutes<60)
                {
                    Console.WriteLine($"{arriveSuminMinutes - examSuminMinutes} minutes after the start");
                }
                else
                {
                    int hours = (arriveSuminMinutes - examSuminMinutes) / 60;
                    int minutes = (arriveSuminMinutes - examSuminMinutes) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
            }
            else if(arriveSuminMinutes == examSuminMinutes ||  examSuminMinutes - arriveSuminMinutes<=30)
            {
                Console.WriteLine("On time");
                if(arriveSuminMinutes- examSuminMinutes !=0)
                {
                   
                    Console.WriteLine($"{examSuminMinutes-arriveSuminMinutes} minutes before the start");
                }
            }
            else if( examSuminMinutes - arriveSuminMinutes > 30)
            {
                Console.WriteLine("Early");
                if(Math.Abs(examSuminMinutes - arriveSuminMinutes) <60)
                {
                    Console.WriteLine($"{examSuminMinutes - arriveSuminMinutes:D2} minutes before the start");
                }
                else
                {
                    
                    int hours = (examSuminMinutes - arriveSuminMinutes) / 60;
                    int minutes = (examSuminMinutes - arriveSuminMinutes) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
            }
        }
    }
}
