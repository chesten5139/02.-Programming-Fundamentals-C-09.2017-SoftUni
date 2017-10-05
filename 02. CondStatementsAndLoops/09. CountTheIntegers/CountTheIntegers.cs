using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main()
        {
            int counter = 0;
            int inputNumber = 0;
            while(true)
            {
                bool isInt = int.TryParse(Console.ReadLine(), out inputNumber);
                if (!isInt)
                {
                    break;
                }
                counter += 1;
            }

            Console.WriteLine(counter);
        }
    }
}
