using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            long startNumber = long.Parse(Console.ReadLine());
            long endNumber = long.Parse(Console.ReadLine());

            var primeNumbers = new List<long>();

            for (long i = startNumber; i <= endNumber; i++)
            {
                if (i > 2 && i % 2 == 0)
                {
                    continue;
                }
                if (IsPrime(i) == true)
                {
                    primeNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", primeNumbers));
        }

        public static bool IsPrime(long number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
