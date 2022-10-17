using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleImjury = int.Parse(Console.ReadLine());
            string nameofPresentation = Console.ReadLine();
            double averageScoreForAllPresentation = 0;
            int counter = 0;
            while(nameofPresentation !="Finish")
            {
                double averageScore = 0;
                for(int i=0;i<peopleImjury;i++ )
                {
                    double currentscore = double.Parse(Console.ReadLine());
                    averageScore += currentscore;
                    averageScoreForAllPresentation += currentscore;
                    counter++;
                }
                double averageScorePerPresentation = averageScore / peopleImjury;
                Console.WriteLine($"{nameofPresentation } - {averageScorePerPresentation:f2}.");
                nameofPresentation = Console.ReadLine(); 
            }
            double assement = averageScoreForAllPresentation / counter;
            Console.WriteLine($"Student's final assessment is {assement:f2}."); 
        }
    }
}
