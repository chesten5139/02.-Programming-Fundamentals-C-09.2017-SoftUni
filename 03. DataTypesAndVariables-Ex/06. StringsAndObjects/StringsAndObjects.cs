using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string firstInput = "Hello";
            string secondInput = "World";
            object concatenated = firstInput + " " + secondInput;
            string toString = (string)concatenated;

            Console.WriteLine(toString);

        }
    }
}
