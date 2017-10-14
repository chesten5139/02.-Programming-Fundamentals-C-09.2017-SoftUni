using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            char userInput = char.Parse(Console.ReadLine());

            if (userInput == 'a' || userInput == 'e' || userInput == 'o' || userInput == 'u' || userInput == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (userInput >= 48 && userInput <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
