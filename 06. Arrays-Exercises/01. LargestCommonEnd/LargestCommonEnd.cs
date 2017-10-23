using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            int smallerArrayLength = Math.Min(firstLine.Length, secondLine.Length);
            int leftCounter = CheckArrays(smallerArrayLength, firstLine, secondLine);

            Array.Reverse(firstLine);
            Array.Reverse(secondLine);

            int rightCounter = CheckArrays(smallerArrayLength, firstLine, secondLine);
            Console.WriteLine(leftCounter > rightCounter ? leftCounter : rightCounter);
        }

        static int CheckArrays(int smallerArrayLength, string[] first, string[] second)
        {
            int Counter = 0;
            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (first[i] == second[i])
                {
                    Counter++;
                }
            }
            return Counter;
        }
    }
}