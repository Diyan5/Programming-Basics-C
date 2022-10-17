using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int wordLenght = word.Length;
            int sum = 0;
            for(int value =0;value<=wordLenght-1;value++)
            {
                char letter = word[value];
//                буква a e i o u

//             стойност 1 2 3 4 5
                switch (letter)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
