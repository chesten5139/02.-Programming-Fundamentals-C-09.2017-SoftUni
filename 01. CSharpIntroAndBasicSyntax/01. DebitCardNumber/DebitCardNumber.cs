using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main()
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());
            int fourthInput = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:0000} {1:0000} {2:0000} {3:0000}",firstInput,secondInput,thirdInput,fourthInput);
        }
    }
}
