using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int minimum = Math.Min(firstInput, secondInput);
            int maximum = Math.Max(firstInput, secondInput);

            for (; minimum <= maximum ; minimum++)
            {
                Console.WriteLine(minimum);
            }

        }
    }
}
