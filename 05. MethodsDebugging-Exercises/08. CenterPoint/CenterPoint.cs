using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class CenterPoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (DistanceBetweenPoints(x1, y1)>=DistanceBetweenPoints(x2, y2))
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }

        static double DistanceBetweenPoints(double x1, double y1)
        {
            double diagonal = Math.Sqrt(x1 * x1) + Math.Sqrt(y1 * y1);
            return diagonal;
        }
    }
}
