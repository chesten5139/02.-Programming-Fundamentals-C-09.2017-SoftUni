using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseADrink2._0
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 1;

            if (profession == "Athlete")
            {
                price *= quantity * 0.70;
                Console.WriteLine("The {0} has to pay {1:f2}.",profession,price);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price *= quantity * 1.00;
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
            }
            else if (profession == "SoftUni Student")
            {
                price *= quantity * 1.70;
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
            }
            else
            {
                price *= quantity * 1.20;
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
            }

        }
    }
}
