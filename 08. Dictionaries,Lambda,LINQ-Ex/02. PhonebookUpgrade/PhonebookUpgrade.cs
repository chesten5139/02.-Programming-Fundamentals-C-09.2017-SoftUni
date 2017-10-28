using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var phonebook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                var inputLine = input.Split(' ').ToList();
                var command = inputLine[0];

                if (command == "A")
                {
                    var name = inputLine[1];
                    var phoneNumber = inputLine[2];

                    phonebook[name] = phoneNumber;
                }
                else if (command == "S")
                {
                    var name = inputLine[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
