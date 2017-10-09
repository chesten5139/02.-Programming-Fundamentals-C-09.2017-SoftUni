using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(input,16).ToUpper();
            string binar = Convert.ToString(input, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binar);

        }
    }
}
