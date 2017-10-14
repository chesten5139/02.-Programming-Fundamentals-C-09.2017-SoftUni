using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static string NumbersReversedOrder(string input)
        {
            string reversedNumber = null;
            for (int i = input.Length-1; i >=0; i--)
            {
                reversedNumber += input[i];
            }
            return reversedNumber;
        }
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(NumbersReversedOrder(input));
        }
    }
}
