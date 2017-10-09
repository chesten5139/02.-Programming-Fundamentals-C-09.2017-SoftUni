using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main()
        {

            int userInput = Convert.ToInt32(Console.ReadLine(),16);

            Console.WriteLine(userInput);
        }
    }
}
