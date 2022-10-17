using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine()); 
            double totalRating = 0;
            double avglRating = 0;
            int grade = 1;
            int fails = 0;
            while(grade<=12)
            {
                
                if(rating <4)
                {
                    fails++;
                   
                }
                if (fails==2)
                {
                    grade--;
                    Console.WriteLine($"{nameOfStudent} has been excluded at {grade} grade");
                    break;
                }
                totalRating += rating;
                avglRating = totalRating / grade;
                grade++;
               if(grade>12)
                {
                    Console.WriteLine($"{nameOfStudent} graduated. Average grade: {avglRating:f2}");
                    break;
                }
                rating = double.Parse(Console.ReadLine());
            }
            

            

        }

    }
}
