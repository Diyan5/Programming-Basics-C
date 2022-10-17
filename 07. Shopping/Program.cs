using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int videokarti = int.Parse(Console.ReadLine());
            int procesor = int.Parse(Console.ReadLine());
            int ramPamet = int.Parse(Console.ReadLine());
            //            Видеокарта – 250 лв./ бр.

            //· Процесор – 35 % от цената на закупените видеокарти/ бр.

            //· Рам памет – 10 % от цената на закупените видеокарти/ бр.
                double a = videokarti * 250;
            double b = a* 0.35;
                double k = b * procesor;
            double c = a * 0.1;
                double m = c * ramPamet;
            double d = a + k + m;
            if ( videokarti>procesor)
            {
             d = (a + k + m) - ((a + k + m) * 0.15);
            }
                
          if(budjet>=d)
            {
                double e = budjet - d;
                Console.WriteLine($"You have {e:f2} leva left!");
            }
          else
            {
                double e = d - budjet;
                Console.WriteLine($"Not enough money! You need {e:f2} leva more!");

            }

        }
    }
}
