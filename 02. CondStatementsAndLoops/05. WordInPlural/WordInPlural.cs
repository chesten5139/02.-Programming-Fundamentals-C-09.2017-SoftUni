using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WordInPlural
{
    class WordInPlural
    {
        static void Main()
        {
            string input = Console.ReadLine();

            bool addIES = input.EndsWith("y");
            bool addES = input.EndsWith("ch") || input.EndsWith("sh") || input.EndsWith("o") || input.EndsWith("s") || input.EndsWith("x") || input.EndsWith("z");

            int length = input.Length;

            if (addIES)
            {
                input = input.Remove(length - 1, 1) + "ies";
            }
            else if (addES)
            {
                input = input + "es";
            }
            else
            {
                input = input + "s";
            }
            Console.WriteLine(input);
        }
    }
}
