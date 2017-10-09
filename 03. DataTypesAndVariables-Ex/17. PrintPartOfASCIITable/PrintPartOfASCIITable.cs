using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main()
        {
            int startChar = int.Parse(Console.ReadLine());
            int finalChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= finalChar ; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
