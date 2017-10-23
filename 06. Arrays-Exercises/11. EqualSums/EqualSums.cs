using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main()
        {
            int[] userInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFoundEqualSums = false;

            for (int i = 0; i < userInput.Length; i++)
            {
                int[] leftSide = userInput.Take(i).ToArray();
                int[] rightSide = userInput.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    isFoundEqualSums = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!isFoundEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
