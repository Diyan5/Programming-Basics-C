using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());
            double totalSum = 0;
//            град / продукт coffee water beer sweets peanuts

                     //Sofia 0.50 0.80 1.20 1.45 1.60

                     //Plovdiv 0.40 0.70 1.15 1.30 1.50

                     //Varna 0.45 0.70 1.10 1.35 1.55
            switch (town)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            totalSum = 0.50 * quality;
                            break;
                        case "water":
                            totalSum = 0.80 * quality;
                            break;
                        case "beer":
                            totalSum = 1.20 * quality;
                            break;
                        case "sweets":
                            totalSum = 1.45 * quality;
                            break;
                        case "peanuts":
                            totalSum = 1.60 * quality;
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            totalSum = 0.40 * quality;
                            break;
                        case "water":
                            totalSum = 0.70 * quality;
                            break;
                        case "beer":
                            totalSum = 1.15 * quality;
                            break;
                        case "sweets":
                            totalSum = 1.30 * quality;
                            break;
                        case "peanuts":
                            totalSum = 1.50 * quality;
                            break;
                    }

                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            totalSum = 0.45 * quality;
                            break;
                        case "water":
                            totalSum = 0.70 * quality;
                            break;
                        case "beer":
                            totalSum = 1.10 * quality;
                            break;
                        case "sweets":
                            totalSum = 1.35 * quality;
                            break;
                        case "peanuts":
                            totalSum = 1.65 * quality;
                            break;
                    }
                    break;
            }
            Console.WriteLine(totalSum);
        }
    }
}
