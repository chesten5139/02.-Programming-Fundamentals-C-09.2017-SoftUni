using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (input != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (result.ContainsKey(input))
                {
                    result[input] += quantity;
                }
                else
                {
                    result.Add(input, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var resource in result)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}
