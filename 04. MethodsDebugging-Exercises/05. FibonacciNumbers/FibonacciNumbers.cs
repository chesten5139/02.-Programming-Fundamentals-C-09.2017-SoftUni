using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(Fib(input));
        }

        static int Fib(int n)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int sum = firstNumber+secondNumber;
            for (int i = 0; i < n; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
            return sum;
        }
    }
}
