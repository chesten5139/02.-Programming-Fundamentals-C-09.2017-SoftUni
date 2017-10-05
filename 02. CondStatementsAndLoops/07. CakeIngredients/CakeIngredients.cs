using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            int counter = 0;

            for (; true;)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", counter);
                    break;
                }
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                counter += 1;
            }
        }
    }
}
