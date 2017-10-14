using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Console.WriteLine("{0:f2}", PropertiesOfTheCube(input,parameter));
        }

        static double PropertiesOfTheCube(double input, string parameter)
        {
            double result = 0;
            switch (parameter)
            {
                case "face":
                     result = Math.Sqrt(2 * input * input);
                    break;

                case "space":
                    result = Math.Sqrt(3 * input * input);
                    break;

                case "volume":
                    result = input * input * input;
                    break;

                case "area":
                    result = 6 * input * input;
                    break; 
            }
            return result;
        }
    }
}