using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
            double studio = 0.00;
            double apartament = 0.00;
            switch(month)
//                За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.

//· За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.

//· За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.

////· За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
            {
                case "May":
                case "October":
                    studio = 50 * night;
                    apartament = 65 * night;
                    if(night>7 && night<=14)
                    {
                        studio = studio - (studio * 0.05);
                    }
                    else if(night>14)
                    {
                        studio = studio - (studio * 0.3);
                    }
                    if(night>14)
                    {
                        apartament = apartament - (apartament * 0.1);
                    }
                    break;
                case "June":
                case "September":
                    studio = 75.20 * night;
                    apartament = 68.70 * night;
                    if (night > 14)
                    {
                        studio = studio - (studio * 0.2);
                    }
                    if (night > 14)
                    {
                        apartament = apartament - (apartament * 0.1);
                    }
                    break;
                case "July":
                case "August":
                    studio = 76 * night;
                    apartament = 77 * night;
                    if (night > 14)
                    {
                        apartament = apartament - (apartament * 0.1);
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {apartament:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
