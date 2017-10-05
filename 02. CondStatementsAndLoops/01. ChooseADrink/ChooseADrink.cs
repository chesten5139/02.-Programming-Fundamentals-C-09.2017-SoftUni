using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseADrink
{
    class ChooseADrink
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            if (input == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (input == "businessman" || input == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (input == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
