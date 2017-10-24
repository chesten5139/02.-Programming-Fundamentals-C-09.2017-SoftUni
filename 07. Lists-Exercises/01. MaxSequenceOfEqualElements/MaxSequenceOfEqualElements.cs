using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            List<int> userInput =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int currentStart = 0;
            int currentLentgh = 0;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 0; i < userInput.Count; i++)
            {
                currentStart = i;

                for (int j = i; j < userInput.Count; j++)
                {

                    if (userInput[i]==userInput[j])
                    {
                        currentLentgh += 1;

                        if (currentLentgh>bestLength)
                        {
                            bestLength = currentLentgh;
                            bestStart = currentStart;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                currentLentgh = 0;
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(userInput[bestStart+i] + " ");
            }
        }
    }
}
