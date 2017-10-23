using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            var firstInput = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var secondInput = Console.ReadLine().Split().Select(char.Parse).ToArray();

            var shorterArray = Math.Min(firstInput.Length, secondInput.Length);
            var first = false;
            var second = false;

            for (int i = 0; i < shorterArray; i++)
            {
                if (firstInput[i] < secondInput[i])
                {
                    first = true;
                    break;
                }
                else if (firstInput[i] > secondInput[i])
                {
                    second = true;
                    break;
                }
            }
            if (first == true)
            {
                Console.WriteLine(string.Join("", firstInput));
                Console.WriteLine(string.Join("", secondInput));
            }
            else if (second == true)
            {
                Console.WriteLine(string.Join("", secondInput));
                Console.WriteLine(string.Join("", firstInput));
            }
            else if (firstInput.Length < secondInput.Length)
            {
                Console.WriteLine(string.Join("", firstInput));
                Console.WriteLine(string.Join("", secondInput));
            }
            else
            {
                Console.WriteLine(string.Join("", secondInput));
                Console.WriteLine(string.Join("", firstInput));
            }
        }
    }
}
