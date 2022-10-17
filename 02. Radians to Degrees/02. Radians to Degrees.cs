using System;


namespace _02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double gradus = radian * 180 / Math.PI;
            Console.WriteLine(gradus);
        }
    }
}
