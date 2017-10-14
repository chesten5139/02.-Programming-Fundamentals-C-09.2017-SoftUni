using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(n);
            Console.WriteLine(GetTrailingZeroes(factorial));
        }

        static BigInteger GetFactorial(BigInteger n)
        {
            BigInteger factorial = 1;

            do
            {
                factorial = factorial * n;
                n--;
            } while (n > 1);

            return factorial;
        }

        static BigInteger GetTrailingZeroes(BigInteger num)
        {
            BigInteger counter = 0;
            while (num % 10 == 0)
            {
                num = num / 10;
                counter++;
            }
            return counter;
        }
    }
}
