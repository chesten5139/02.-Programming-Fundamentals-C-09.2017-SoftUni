using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class MagicLetter
    {
        static void Main()
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char k = letter1; k <= letter2; k++)
                    {
                        if (i != letter3 && j != letter3 && k != letter3) Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
