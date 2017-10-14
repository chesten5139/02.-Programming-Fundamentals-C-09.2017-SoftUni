using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            a = b;
            b = 5;

            Console.WriteLine("Before:\na = 5\nb = 10\nAfter:\na = 10\nb = 5");
        }
    }
}
