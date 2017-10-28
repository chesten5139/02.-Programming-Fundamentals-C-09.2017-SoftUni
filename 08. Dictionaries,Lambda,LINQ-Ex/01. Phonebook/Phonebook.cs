using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var phonebook = new Dictionary<string, string>();

            while (input != "END")
            {
                var inputLine = input.Split(' ').ToList();
                var command = inputLine[0];
                var name = inputLine[1];

                if (command == "A")
                {
                    var phoneNumber = inputLine[2];

                    phonebook[name] = phoneNumber;
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
