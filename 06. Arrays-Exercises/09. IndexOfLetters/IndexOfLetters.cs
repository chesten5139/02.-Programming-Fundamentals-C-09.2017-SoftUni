using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {

            var userInput = Console.ReadLine().ToCharArray();

            for (int i = 0; i <= userInput.Length - 1; i++)
            {
                Console.WriteLine("{0} -> {1}", userInput[i], (int)userInput[i] - 97);
            }

            //with foreach

            //var input = Console.ReadLine().ToCharArray();
            //foreach (var character in input)
            //{
            //    Console.WriteLine($"{character} -> {((int)character) - 97}");
            //}
        }
    }
}
