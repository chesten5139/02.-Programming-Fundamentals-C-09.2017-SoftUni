using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var officialHollidays = new[]
            {
                "01 01","03 03","01 05","06 05","24 05","06 09","22 09","01 11","24 12","25 12","26 12"
            }
            .Select(d => DateTime.ParseExact(d, "dd MM", CultureInfo.InvariantCulture)).ToArray();

            var workingDaysCount = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                var isWeekend = currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday;
                var isHoliday = officialHollidays.Any(d => d.Day == currentDate.Day && d.Month == currentDate.Month);
                var isWorkingDay = !(isWeekend || isHoliday);

                if (isWorkingDay)
                {
                    workingDaysCount++;
                }
            }
            Console.WriteLine(workingDaysCount);
        }
    }
}
