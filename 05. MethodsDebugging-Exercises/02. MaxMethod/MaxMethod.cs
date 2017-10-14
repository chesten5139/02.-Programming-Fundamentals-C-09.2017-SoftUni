using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static int GetMax(int a, int b)
        {
            int biggerOfTwo = 0;
            if (a >= b)
            {
                biggerOfTwo = a;
            }
            else if (a <= b)
            {
                biggerOfTwo = b;
            }

            return biggerOfTwo;
        }

        static void Main()
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());
            int biggerOfThree = GetMax(GetMax(firstInput, secondInput), thirdInput);

            Console.WriteLine(biggerOfThree);
        }
    }
}
