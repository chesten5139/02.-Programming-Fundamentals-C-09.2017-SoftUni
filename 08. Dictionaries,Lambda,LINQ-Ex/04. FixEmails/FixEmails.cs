using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, string>();

            while (input != "stop")
            {
                var email = Console.ReadLine();

                if (email.EndsWith("us".ToLower()) || email.EndsWith("uk".ToLower()))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!result.ContainsKey(input))
                {
                    result.Add(input, email);
                }

                input = Console.ReadLine();
            }
            foreach (var data in result)
            {
                Console.WriteLine("{0} -> {1}", data.Key, data.Value);
            }
        }
    }
}
