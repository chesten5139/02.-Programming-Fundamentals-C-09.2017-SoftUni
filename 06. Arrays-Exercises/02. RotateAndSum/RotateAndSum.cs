using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotate = int.Parse(Console.ReadLine());
            int[] sumResult = new int[array.Length];

            for (int i = 0; i < rotate; i++)
            {
                int lastElement = array[array.Length - 1];

                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastElement;

                for (int k = 0; k < array.Length; k++)
                {
                    sumResult[k] += array[k];
                }
            }
            Console.WriteLine(string.Join(" ", sumResult));
        }
    }
}
