using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class NeighbourWars
    {
        static void Main()
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int cnt = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                cnt++;
                if (cnt % 2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                }
                else if (cnt % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                }
                if (cnt % 3 == 0 && goshoHealth > 0 && peshoHealth > 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
            if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {cnt}th round.");
            }
            else if (goshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {cnt}th round.");
            }
        }
    }
}
