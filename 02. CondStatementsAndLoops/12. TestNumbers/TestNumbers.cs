using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumBoundary = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalSum = 0;

            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    totalSum += (i * j) * 3;

                    counter += 1;

                    if (totalSum >= sumBoundary)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", totalSum, sumBoundary);
                        break;
                    }

                }
                if (totalSum >= sumBoundary)
                {
                    break;
                }
                Console.WriteLine();
            }
            if (totalSum < sumBoundary)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", totalSum);
            }
        }
    }
}
