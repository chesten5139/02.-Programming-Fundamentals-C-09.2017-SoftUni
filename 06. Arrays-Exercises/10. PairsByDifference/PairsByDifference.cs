using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main()
        {
            int[] userInputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int userInputDifference = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < userInputArray.Length; i++)
            {
                for (int j = 0; j < userInputArray.Length; j++)
                {
                    if (userInputArray[i] - userInputArray[j] == userInputDifference)
                    {
                        counter += 1;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
