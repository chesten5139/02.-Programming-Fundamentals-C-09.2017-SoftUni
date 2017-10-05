using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int min = Math.Min(n, m);
            int max = Math.Max(n, m);
            int lastCombinationN = 0;
            int lastCombinationM = 0;
            int counter = 0;


            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    counter += 1;
                    if ((i+j)== magicalNumber)
                    {
                        lastCombinationN = i;
                        lastCombinationM = j;
                    }
                }
            }

            if (lastCombinationN != 0)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", lastCombinationN,lastCombinationM, magicalNumber);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter,magicalNumber);
            }

        }
    }
}
