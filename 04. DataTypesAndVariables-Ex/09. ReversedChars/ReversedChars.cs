using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReversedChars
{
    class ReversedChars
    {
        static void Main()
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdInput}{secondInput}{firstInput}");
        }
    }
}
