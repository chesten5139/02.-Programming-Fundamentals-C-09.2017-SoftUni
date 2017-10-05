using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int suger = int.Parse(Console.ReadLine());
            double energyContent = ((double)volume / 100) * energy;
            double sugarContent = ((double)volume / 100) * suger;

            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars",volume,name, energyContent,sugarContent);
        }
    }
}
