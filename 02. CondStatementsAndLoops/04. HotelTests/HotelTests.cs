using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HotelTests
{
    class HotelTests
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * days;
                doublePrice = 65 * days;
                suitePrice = 75 * days;

                if (days > 7)
                {
                    studioPrice = 50 * days * 0.95;
                }
                if (month == "October" && days > 7)
                {
                    studioPrice = 50 * 0.95 * (days - 1);
                }
            }

            if (month == "June" || month == "September")
            {
                studioPrice = 60 * days;
                doublePrice = 72 * days;
                suitePrice = 82 * days;

                if (days > 14)
                {
                    doublePrice = 72 * days * 0.90;
                }
                if (month == "September" && days > 7)
                {
                    studioPrice = 60 * (days - 1);
                }
            }

            if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * days;
                doublePrice = 77 * days;
                suitePrice = 89 * days;

                if (days > 14)
                {
                    suitePrice = 89 * days * 0.85;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
            Console.WriteLine("Double: {0:f2} lv.", doublePrice);
            Console.WriteLine("Suite: {0:f2} lv.", suitePrice);
        }
    }
}
