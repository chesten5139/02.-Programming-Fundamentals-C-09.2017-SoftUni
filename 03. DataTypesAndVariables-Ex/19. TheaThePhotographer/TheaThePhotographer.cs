using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            long picturesTaken = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long percentage = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long amountFiltered = (long)Math.Ceiling(picturesTaken * percentage / 100d);
            long filterAllPics = picturesTaken * filterTime;
            long uploadAllPics = amountFiltered * uploadTime;
            long totalTime = filterAllPics + uploadAllPics;

            TimeSpan projectTime = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                projectTime.Days,
                projectTime.Hours,
                projectTime.Minutes,
                projectTime.Seconds);
        }
    }
}
