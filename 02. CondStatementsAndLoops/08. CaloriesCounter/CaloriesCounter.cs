using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "cheese":
                        totalCalories += 500;
                        break;

                    case "tomato sauce":
                        totalCalories += 150;
                        break;

                    case "salami":
                        totalCalories += 600;
                        break;

                    case "pepper":
                        totalCalories += 50;
                        break;
                }
            }

            Console.WriteLine("Total calories: {0}", totalCalories);
        }
    }
}
