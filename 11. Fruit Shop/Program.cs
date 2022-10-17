using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());
            double totalSum = 0;
//            плод banana apple orange grapefruit kiwi pineapple grapes

            // цена 2.50 1.20 0.85 1.45 2.70 5.50 3.85
            switch (day)
            {
                case "Monday":
                    switch(fruit)
                    {
                        case "banana":
                            totalSum = 2.50 * quality;
                            break;
                        case "apple":
                            totalSum = 1.20 * quality;
                            break;
                        case "orange":
                            totalSum = 0.85 * quality;
                            break;
                        case "grapefruit":
                            totalSum = 1.45 * quality;
                            break;
                        case "kiwi":
                            totalSum = 2.70 * quality;
                            break;
                        case "pineapple":
                            totalSum = 5.50 * quality;
                            break;
                        case "grapes":
                            totalSum = 3.85 * quality;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Tuesday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = 2.50 * quality;
                            break;
                        case "apple":
                            totalSum = 1.20 * quality;
                            break;
                        case "orange":
                            totalSum = 0.85 * quality;
                            break;
                        case "grapefruit":
                            totalSum = 1.45 * quality;
                            break;
                        case "kiwi":
                            totalSum = 2.70 * quality;
                            break;
                        case "pineapple":
                            totalSum = 5.50 * quality;
                            break;
                        case "grapes":
                            totalSum = 3.85 * quality;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Wednesday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = 2.50 * quality;
                            break;
                        case "apple":
                            totalSum = 1.20 * quality;
                            break;
                        case "orange":
                            totalSum = 0.85 * quality;
                            break;
                        case "grapefruit":
                            totalSum = 1.45 * quality;
                            break;
                        case "kiwi":
                            totalSum = 2.70 * quality;
                            break;
                        case "pineapple":
                            totalSum = 5.50 * quality;
                            break;
                        case "grapes":
                            totalSum = 3.85 * quality;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Thursday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = 2.50 * quality;
                            break;
                        case "apple":
                            totalSum = 1.20 * quality;
                            break;
                        case "orange":
                            totalSum = 0.85 * quality;
                            break;
                        case "grapefruit":
                            totalSum = 1.45 * quality;
                            break;
                        case "kiwi":
                            totalSum = 2.70 * quality;
                            break;
                        case "pineapple":
                            totalSum = 5.50 * quality;
                            break;
                        case "grapes":
                            totalSum = 3.85 * quality;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = 2.50 * quality;
                            break;
                        case "apple":
                            totalSum = 1.20 * quality;
                            break;
                        case "orange":
                            totalSum = 0.85 * quality;
                            break;
                        case "grapefruit":
                            totalSum = 1.45 * quality;
                            break;
                        case "kiwi":
                            totalSum = 2.70 * quality;
                            break;
                        case "pineapple":
                            totalSum = 5.50 * quality;
                            break;
                        case "grapes":
                            totalSum = 3.85 * quality;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = 2.70 * quality;
                            break;
                        case "apple":
                            totalSum = 1.25 * quality;
                            break;
                        case "orange":
                            totalSum = 0.90 * quality;
                            break;
                        case "grapefruit":
                            totalSum = 1.60 * quality;
                            break;
                        case "kiwi":
                            totalSum = 3.00 * quality;
                            break;
                        case "pineapple":
                            totalSum = 5.60 * quality;
                            break;
                        case "grapes":
                            totalSum = 4.20 * quality;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = 2.70 * quality;
                            break;
                        case "apple":
                            totalSum = 1.25 * quality;
                            break;
                        case "orange":
                            totalSum = 0.90 * quality;
                            break;
                        case "grapefruit":
                            totalSum = 1.60 * quality;
                            break;
                        case "kiwi":
                            totalSum = 3.00 * quality;
                            break;
                        case "pineapple":
                            totalSum = 5.60 * quality;
                            break;
                        case "grapes":
                            totalSum = 4.20 * quality;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (totalSum > 0)
            {
                Console.WriteLine($"{totalSum:f2}");
            }
        }
    }
}
