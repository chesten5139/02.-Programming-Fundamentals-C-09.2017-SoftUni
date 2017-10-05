using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            double inputMiles = double.Parse(Console.ReadLine());
            double toKilometers = inputMiles * 1.60934;

            Console.WriteLine("{0:f2}",toKilometers);

        }
    }
}
